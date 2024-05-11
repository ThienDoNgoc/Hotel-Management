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
    /// Interaction logic for AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        ICustomerRepository customerRepository;
        IRoomInformationRepository roomInformationRepository;
        IBookingReservationRepository bookingReservationRepository;
        IBookingDetailRepository bookingDetailRepository;
        public AdminMainWindow(ICustomerRepository customerRepository
                             , IRoomInformationRepository roomInformationRepository
                             , IBookingReservationRepository bookingReservationRepository
                             , IBookingDetailRepository bookingDetailRepository)
        {
            InitializeComponent();
            this.customerRepository = customerRepository;
            this.roomInformationRepository=roomInformationRepository;
            this.bookingReservationRepository=bookingReservationRepository;
            this.bookingDetailRepository=bookingDetailRepository;
        }

        private void ManageCustomerbtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagementWindow customerWindow = new CustomerManagementWindow(customerRepository);          
            customerWindow.Show();
        }

        private void ManageRoomInformationbtn_Click(object sender, RoutedEventArgs e)
        {
            RoomInformationManagementWindow newWindow = new RoomInformationManagementWindow(roomInformationRepository);
            newWindow.Show();
        }

        private void BookingReservationBtn_Click(object sender, RoutedEventArgs e)
        {
            BookingReservationWindow newWindow = new BookingReservationWindow(bookingReservationRepository, bookingDetailRepository, roomInformationRepository, customerRepository);
            newWindow.Show();
        }

        private void StatisticBtn_Click(object sender, RoutedEventArgs e)
        {
            ReportStatisticWindow newWindow = new ReportStatisticWindow(bookingDetailRepository);
            newWindow.Show();
        }

        private void SignOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    LoginWindow newWindow = new LoginWindow(bookingDetailRepository, bookingReservationRepository, roomInformationRepository, customerRepository);
                    this.Close();
                    newWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
