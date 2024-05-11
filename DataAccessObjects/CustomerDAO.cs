using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccessObjects
{
    public class CustomerDAO
    {
        FUMiniHotelManagementContext myDB = new FUMiniHotelManagementContext();

        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public bool CheckUserLogin(string email, string password)
        {
            bool check = false;
            try
            {
                var customers = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0 && s.EmailAddress == email && s.Password == password).FirstOrDefault();
                if (customers!=null)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;

        }

        public IEnumerable<Customer> GetCustomerList()
        {
            List<Customer> customers;
            try
            {
                customers = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

        public IEnumerable<Customer> SearchUserByFullName(string keyword)
        {
            List<Customer> customers;
            try
            {
                customers = myDB.Customers.Where(c => c.CustomerStatus !=0 && c.CustomerFullName.ToLower().Contains(keyword.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

        public List<String> GetCustomerEmailList()
        {
            List<String> customerEmails = new List<string>();
            try
            {
                var customers = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0).ToList();
                foreach (var customer in customers)
                {
                    customerEmails.Add(customer.EmailAddress);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customerEmails;
        }

        public int GetCustomerIdByEmail(string email)
        {
            int customerId;
            try
            {
                var customers = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0 && s.EmailAddress == email).FirstOrDefault();
                customerId = customers.CustomerId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customerId;
        }

        public bool CheckCustomerExist(string email)
        {
            bool check = false;
            try
            {
                var customers = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0 && s.EmailAddress == email).FirstOrDefault();
                if (customers!=null)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }

        public Customer GetCustomerByID(int customerID)
        {
            Customer customer = null;
            try
            {
                customer = myDB.Customers.AsNoTracking().SingleOrDefault(s => s.CustomerId == customerID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }

        public Customer GetCustomerByEmail(string email)
        {
            Customer customer = new Customer();
            try
            {
                customer = myDB.Customers.AsNoTracking().Where(s => s.CustomerStatus != 0 && s.EmailAddress == email).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }

        public void AddNew(Customer customer)
        {
            try
            {
                Customer checkCustomer = GetCustomerByID(customer.CustomerId);
                if (checkCustomer == null)
                {
                    myDB.Customers.Add(customer);
                    myDB.SaveChanges();
                    myDB.Entry(customer).State = EntityState.Detached;
                }
                else
                {
                    throw new Exception("Customer is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Customer customer)
        {
            try
            {
                Customer _customer = GetCustomerByID(customer.CustomerId);
                if (_customer != null)
                {
                    myDB.Entry<Customer>(customer).State = EntityState.Modified;
                    myDB.SaveChanges();
                    myDB.Entry(customer).State = EntityState.Detached;
                }
                else
                {
                    throw new Exception("The customer not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Customer customer)
        {
            try
            {
                Customer _customer = GetCustomerByID(customer.CustomerId);
                if (_customer != null)
                {
                    customer.CustomerStatus = 0;
                    myDB.Entry<Customer>(customer).State = EntityState.Modified;
                    myDB.SaveChanges();
                    myDB.Entry(customer).State = EntityState.Detached;
                }
                else
                {
                    throw new Exception("The customer not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
