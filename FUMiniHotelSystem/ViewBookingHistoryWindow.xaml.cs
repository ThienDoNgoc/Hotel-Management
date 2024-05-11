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
    /// Interaction logic for ViewBookingHistoryWindow.xaml
    /// </summary>
    public partial class ViewBookingHistoryWindow : Window
    {
        IBookingReservationRepository bookingReservationRepository;
        IBookingDetailRepository bookingDetailRepository;
        IRoomInformationRepository roomInformationRepository;
        ICustomerRepository customerRepository;
        string email;
        public ViewBookingHistoryWindow(IBookingReservationRepository repository
                                       , IBookingDetailRepository _bookingDetailRepository
                                       , IRoomInformationRepository roomInformationRepository
                                       , ICustomerRepository customerRepository
                                       , string email)
        {
            InitializeComponent();
            bookingReservationRepository = repository;          
            bookingDetailRepository=_bookingDetailRepository;
            this.roomInformationRepository=roomInformationRepository;
            this.customerRepository=customerRepository;
            this.email=email;
            LoadbookingReservationList();
        }

        public void LoadbookingReservationList()
        {
            var customer = customerRepository.GetCustomerByEmail(email);
            lvBookingReservation.ItemsSource = bookingReservationRepository.GetBookingReservationByUserId(customer.CustomerId);
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
            this.Close();
        }
    }
}
