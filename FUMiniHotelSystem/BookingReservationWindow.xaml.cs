using BusinessObjects;
using Repositories.IRepo;
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
    /// Interaction logic for BookingReservationWindow.xaml
    /// </summary>
    public partial class BookingReservationWindow : Window
    {
        IBookingReservationRepository bookingReservationRepository;
        IBookingDetailRepository bookingDetailRepository;
        IRoomInformationRepository roomInformationRepository;
        ICustomerRepository customerRepository;

        public BookingReservationWindow(IBookingReservationRepository repository
                                      , IBookingDetailRepository _bookingDetailRepository
                                      , IRoomInformationRepository roomInformationRepository
                                      , ICustomerRepository customerRepository)
        {
            InitializeComponent();
            bookingReservationRepository = repository;
            LoadbookingReservationList();
            bookingDetailRepository=_bookingDetailRepository;
            this.roomInformationRepository=roomInformationRepository;
            this.customerRepository=customerRepository;
        }

        private BookingReservation GetBookingReservationObject()
        {
            BookingReservation bookingReservation = new BookingReservation();
            try
            {
                bookingReservation = new BookingReservation
                {
                    BookingReservationId = int.Parse(BookingReservationIdtxt.Text),
                    BookingDate = DateTime.Parse(BookingDatetxt.Text),
                    TotalPrice = decimal.Parse(TotalPricetxt.Text),
                    CustomerId = customerRepository.GetCustomerIdByEmail(CustomerEmailAddresstxt.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Room");
            }
            return bookingReservation;
        }

        public void LoadbookingReservationList()
        {
            lvBookingReservation.ItemsSource = bookingReservationRepository.GetBookingReservations();
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null)
            {
                var data = item.Content as BookingReservation;
                if (data != null)
                {
                    var bookingReservationId = data.BookingReservationId;
                    lvBookingDetails.ItemsSource = bookingDetailRepository.GetBookingDetailByBookingReserId(bookingReservationId);
                }
            }
        }


        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (BookingReservationIdtxt.Text!="")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {

                        BookingReservation bookingReservation = GetBookingReservationObject();
                        var test = bookingReservation;
                        bookingReservationRepository.DeleteBookingReservation(bookingReservation);
                        LoadbookingReservationList();
                        MessageBox.Show($"{bookingReservation.BookingReservationId} delete successfully ", "Deleted Booking");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete Booking");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Chose booking reservation you want to delete!");
            }
            
        }

        private void Insertbtn_Click(object sender, RoutedEventArgs e)
        {
            CreateBookingReservationWindow createWindow = new CreateBookingReservationWindow(customerRepository, bookingReservationRepository, roomInformationRepository, bookingDetailRepository);
            createWindow.Closed += (s, eventarg) =>
            {
                LoadbookingReservationList();
            };
            createWindow.Show();
        }


    }
}
