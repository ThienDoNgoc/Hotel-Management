using BusinessObjects;
using Repositories.IRepo;
using Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FUMiniHotelSystem
{
    /// <summary>
    /// Interaction logic for CreateBookingReservationWindow.xaml
    /// </summary>
    public partial class CreateBookingReservationWindow : Window
    {
        IBookingDetailRepository bookingDetailRepository;
        IBookingReservationRepository bookingReservationRepository;
        ICustomerRepository customerRepository;
        IRoomInformationRepository roomInformationRepository;
        public CreateBookingReservationWindow(ICustomerRepository customerRepository
                                            , IBookingReservationRepository bookingReservationRepository
                                            , IRoomInformationRepository roomInformationRepository
                                            , IBookingDetailRepository bookingDetailRepository)
        {
            InitializeComponent();
            this.customerRepository=customerRepository;
            this.bookingReservationRepository=bookingReservationRepository;
            this.roomInformationRepository=roomInformationRepository;
            this.bookingDetailRepository=bookingDetailRepository;
            LoadBase();
        }
        public void LoadBase()
        {
            CustomerEmailcb.ItemsSource = customerRepository.GetCustomerEmailList();
            RoomIdcb.ItemsSource = roomInformationRepository.GetRoomValidList();
        }

        private void Insertbtn_Click(object sender, RoutedEventArgs e)
        {
            decimal? totalPrice = 0;
            bool checkOverlap = false;
            if (RoomIdcb.Text != "")
            {
                if (StartDatePicker.SelectedDate.HasValue && EndDatePicker.SelectedDate.HasValue)
                {
                    if ((StartDatePicker.SelectedDate.Value < EndDatePicker.SelectedDate.Value)
                        &&(StartDatePicker.SelectedDate.Value >= DateTime.Today))
                    {
                        BookingDetail bookingDetail = new BookingDetail()
                        {
                            RoomId = int.Parse(RoomIdcb.Text),
                            StartDate = StartDatePicker.SelectedDate.Value,
                            EndDate = EndDatePicker.SelectedDate.Value,
                            ActualPrice = roomInformationRepository.GetRoomPriceById(int.Parse(RoomIdcb.Text))
                        };

                        if (lvBookingDetails.Items!=null)
                        {
                            foreach (var detail in lvBookingDetails.Items)
                            {
                                var bookingDetails = detail as BookingDetail;
                                if (bookingDetails.RoomId == bookingDetail.RoomId &&
                                    ((bookingDetail.StartDate >= bookingDetails.StartDate && bookingDetail.StartDate <= bookingDetails.EndDate) ||
                                    (bookingDetail.EndDate >= bookingDetails.StartDate && bookingDetail.EndDate <= bookingDetails.EndDate)))
                                {
                                    checkOverlap = true;
                                }
                            }

                            if (checkOverlap)
                            {
                                MessageBox.Show("Please input booking detail again its overlap!");
                            }
                            else
                            {
                                lvBookingDetails.Items.Add(bookingDetail);

                                foreach (var detail in lvBookingDetails.Items)
                                {
                                    var bookingDetails = detail as BookingDetail;
                                    if (bookingDetails != null)
                                    {
                                        totalPrice += bookingDetails.ActualPrice;
                                    }
                                }
                                TotalPricelb.Content = totalPrice.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input Start Date and End Date correctly!");

                    }

                }
                else
                {
                    MessageBox.Show("Please input Start Date or End Date!");
                }
            }
            else
            {
                MessageBox.Show("Please input Room ID");
            }


        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Bookingbtn_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerEmailcb.Text=="")
            {
                MessageBox.Show("Please input customer email!");
            }
            else
            {
                if (lvBookingDetails.Items.Count !=0)
                {
                    int newbookingId = bookingReservationRepository.GetMaxBookingReservationId()+1;
                    BookingReservation bookingReservation = new BookingReservation()
                    {
                        BookingReservationId = newbookingId,
                        BookingDate = DateTime.Now,
                        TotalPrice = decimal.Parse(TotalPricelb.Content.ToString()),
                        CustomerId = customerRepository.GetCustomerIdByEmail(CustomerEmailcb.Text),
                        BookingStatus = 1,
                    };

                    try
                    {
                        bookingReservationRepository.InsertBookingReservation(bookingReservation);

                        if (lvBookingDetails.Items!=null)
                        {
                            foreach (var detail in lvBookingDetails.Items)
                            {
                                var bookingDetails = detail as BookingDetail;
                                bookingDetails.BookingReservationId = newbookingId;
                                bookingDetailRepository.InsertBookingDetail(bookingDetails);
                            }
                        }

                        MessageBox.Show($"{bookingReservation.BookingReservationId} Insert successfully ", "Inserted room");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Insert booking reservation");
                    }
                }
                else
                {
                    MessageBox.Show("Please chooes your schedule");
                }
            }
        }
    }
}
