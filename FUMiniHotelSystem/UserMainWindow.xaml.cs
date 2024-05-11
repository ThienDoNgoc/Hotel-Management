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
    /// Interaction logic for UserMainWindow.xaml
    /// </summary>
    public partial class UserMainWindow : Window
    {
        ICustomerRepository customerRepository;
        IBookingDetailRepository bookingDetailRepository;
        IBookingReservationRepository bookingReservationRepository;
        IRoomInformationRepository roomInformationRepository;
        string email;
        public UserMainWindow(IBookingDetailRepository bookingDetailRepository
                            , IBookingReservationRepository bookingReservationRepository
                            , ICustomerRepository customerRepository
                            , string email
                            , IRoomInformationRepository roomInformationRepository            )
        {
            InitializeComponent();
            this.bookingDetailRepository=bookingDetailRepository;
            this.bookingReservationRepository=bookingReservationRepository;
            this.customerRepository=customerRepository;
            this.email=email;
            this.roomInformationRepository=roomInformationRepository;
        }

        private void ManageProfilebtn_Click(object sender, RoutedEventArgs e)
        {
            ManageProfileWindow newWindow = new ManageProfileWindow(customerRepository, email);
            newWindow.Show();
        }

        private void BookingHistorybtn_Click(object sender, RoutedEventArgs e)
        {
            ViewBookingHistoryWindow newWindow = new ViewBookingHistoryWindow(bookingReservationRepository, bookingDetailRepository, roomInformationRepository, customerRepository, email);
            newWindow.Show();
        }

        private void SignOutbtn_Click(object sender, RoutedEventArgs e)
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
