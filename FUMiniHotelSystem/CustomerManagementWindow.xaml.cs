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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FUMiniHotelSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CustomerManagementWindow : Window
    {
        ICustomerRepository customerRepository;
        public CustomerManagementWindow(ICustomerRepository repository)
        {
            InitializeComponent();
            customerRepository = repository;
            LoadCustomerList();
        }

        private Customer GetCustomerObject()
        {
            Customer customer = new Customer();
            try
            {
                customer = new Customer
                {
                    CustomerId = int.Parse(CustomerIdtxt.Text),
                    CustomerFullName = CustomerFullNametxt.Text,
                    Telephone = Telephonetxt.Text,
                    EmailAddress = EmailAddresstxt.Text,
                    CustomerBirthday = DateTime.Parse(CustomerBirthdaytxt.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get customer");
            }
            return customer;
        }

        public void LoadCustomerList()
        {
            lvCustomers.ItemsSource = customerRepository.GetCustomers();
        }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (EmailAddresstxt.Text!="")
            {
                Customer customer = GetCustomerObject();
                UpdateCustomerWindow createWindow = new UpdateCustomerWindow(customerRepository, customer);
                createWindow.Closed += (s, eventarg) =>
                {
                    LoadCustomerList();
                };
                // Show the child window
                createWindow.Show();
            }
            else
            {
                MessageBox.Show("Please choose customer you want to update!");
            }
        }

        private void Closebtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            if (EmailAddresstxt.Text!="")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Customer customer = GetCustomerObject();
                        customerRepository.DeleteCustomer(customer);
                        LoadCustomerList();
                        MessageBox.Show($"{customer.CustomerFullName} delete successfully ", "Delete customer");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete customer");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose customer you want to delete!");
            }
        }

        private void Insertbtn_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomerWindow createWindow = new CreateCustomerWindow(customerRepository);
            createWindow.Closed += (s, eventarg) =>
            {
                LoadCustomerList();
            };
            createWindow.Show();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (keyWordtxt.Text=="")
            {
                LoadCustomerList();
            }
            else
            {
                lvCustomers.ItemsSource = customerRepository.SearchCustomerByName(keyWordtxt.Text);
            }
        }
    }
}
