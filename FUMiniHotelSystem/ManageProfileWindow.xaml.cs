using BusinessObjects;
using Repositories.IRepo;
using Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ManageProfileWindow.xaml
    /// </summary>
    public partial class ManageProfileWindow : Window
    {
        ICustomerRepository customerRepository;
        string email;
        public ManageProfileWindow(ICustomerRepository customerRepository, string email)
        {
            InitializeComponent();
            this.customerRepository = customerRepository;
            this.email=email;
            LoadBase();
        }

        public void LoadBase()
        {
            var _customer = customerRepository.GetCustomerByEmail(email);

            CustomerFullNametxt.Text = _customer.CustomerFullName;
            Telephonetxt.Text = _customer.Telephone;
            EmailAddresstxt.Text = _customer.EmailAddress;
            CustomerBirthdaytxt.Text = _customer.CustomerBirthday.ToString();
            Passwordtxt.Text = _customer.Password;
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to Update?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var _customer = customerRepository.GetCustomerByEmail(email);
                string telephonePattern = "^0\\d{9}$";
                string emailAddressPattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
                Regex telephoneCheck = new Regex(telephonePattern);
                Regex EmailCheck = new Regex(emailAddressPattern);



                if (CustomerFullNametxt.Text!="")
                {
                    if (telephoneCheck.IsMatch(Telephonetxt.Text))
                    {
                        if (EmailCheck.IsMatch(EmailAddresstxt.Text))
                        {
                            if (CustomerBirthdaytxt.SelectedDate.HasValue && CustomerBirthdaytxt.SelectedDate.Value < DateTime.Now)
                            {
                                if (Passwordtxt.Text!="")
                                {
                                    DateTime birthday = CustomerBirthdaytxt.SelectedDate.Value;
                                    var customer = new Customer
                                    {
                                        CustomerId = _customer.CustomerId,
                                        CustomerFullName = CustomerFullNametxt.Text,
                                        Telephone = Telephonetxt.Text,
                                        EmailAddress = EmailAddresstxt.Text,
                                        CustomerBirthday = birthday,
                                        Password = Passwordtxt.Text,
                                    };

                                    try
                                    {
                                        customerRepository.UpdateCustomer(customer);
                                        MessageBox.Show($"Email Address: {customer.EmailAddress} update successfully ", "updated room");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Update customer");
                                    }
                                    LoadBase();
                                }
                                else
                                {
                                    MessageBox.Show("Please Input Password!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Input Your Birthday correctly!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please input email correctly!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input telephone correctly(start with 0 and have 10 digits)!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input Customer Name!");
                }
            }
            
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
