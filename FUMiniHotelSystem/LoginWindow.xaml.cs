using Microsoft.Extensions.Configuration;
using Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        ICustomerRepository _customerRepository;
        IBookingDetailRepository _bookingDetailRepository;
        IBookingReservationRepository _bookingReservationRepository;
        IRoomInformationRepository _roomInformationRepository;
        public LoginWindow(IBookingDetailRepository bookingDetailRepository
                         , IBookingReservationRepository bookingReservationRepository
                         , IRoomInformationRepository roomInformationRepository
                         , ICustomerRepository customerRepository)
        {
            InitializeComponent();
            _bookingDetailRepository=bookingDetailRepository;
            _bookingReservationRepository=bookingReservationRepository;
            _roomInformationRepository=roomInformationRepository;
            _customerRepository=customerRepository;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["account:adminAccount:email"];
                string password = config["account:adminAccount:password"];

                if (EmailTextBox.Text == email && PasswordBox.Password == password)
                {
                    AdminMainWindow adminWindow = new AdminMainWindow(_customerRepository, _roomInformationRepository, _bookingReservationRepository, _bookingDetailRepository);
                    adminWindow.Closed += (s, args) => this.Close();
                    this.Close();
                    adminWindow.Show();
                }
                else if (_customerRepository.CheckUserLogin(EmailTextBox.Text, PasswordBox.Password))
                {
                    UserMainWindow userWindow = new UserMainWindow(_bookingDetailRepository, _bookingReservationRepository, _customerRepository, EmailTextBox.Text, _roomInformationRepository);
                    userWindow.Closed += (s, args) => this.Close();
                    this.Close();
                    userWindow.Show();
                }
                else
                {
                    MessageBox.Show("Your email/password is incorrect");
                }
            }
        }
    }
}
