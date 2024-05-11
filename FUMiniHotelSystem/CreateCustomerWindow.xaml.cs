using BusinessObjects;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Repositories.IRepo;
using Repositories.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for CreateCustomerWindow.xaml
    /// </summary>
    public partial class CreateCustomerWindow : Window
    {
        ICustomerRepository customerRepository;
        public CreateCustomerWindow(ICustomerRepository repository)
        {
            InitializeComponent();
            customerRepository = repository;
        }



        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
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
                        if (customerRepository.CheckCustomerEmailExist(EmailAddresstxt.Text)==false)
                        {
                            if (CustomerBirthdaytxt.SelectedDate.HasValue && CustomerBirthdaytxt.SelectedDate.Value < DateTime.Now)
                            {
                                if (Passwordtxt.Text!="")
                                {
                                    DateTime birthday = CustomerBirthdaytxt.SelectedDate.Value;
                                    var customer = new Customer
                                    {
                                        CustomerFullName = CustomerFullNametxt.Text,
                                        Telephone = Telephonetxt.Text,
                                        EmailAddress = EmailAddresstxt.Text,
                                        CustomerBirthday = birthday,
                                        Password = Passwordtxt.Text,
                                    };

                                    try
                                    {
                                        customerRepository.InsertCustomer(customer);
                                        MessageBox.Show($"Email Address: {customer.EmailAddress} Insert successfully ", "Inserted room");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Insert customer");
                                    }
                                    this.Close();
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
                            MessageBox.Show("This email has been used, please use another email!");
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
