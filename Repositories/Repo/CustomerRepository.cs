using BusinessObjects;
using DataAccessObjects;
using Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Repo
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool CheckCustomerEmailExist(string email) => CustomerDAO.Instance.CheckCustomerExist(email);

        public bool CheckUserLogin(string email, string password) => CustomerDAO.Instance.CheckUserLogin(email, password);  

        public void DeleteCustomer(Customer customer) => CustomerDAO.Instance.Remove(customer);

        public Customer GetCustomerByEmail(string email) => CustomerDAO.Instance.GetCustomerByEmail(email);

        public Customer GetCustomerByID(int id) => CustomerDAO.Instance.GetCustomerByID(id);

        public List<string> GetCustomerEmailList() => CustomerDAO.Instance.GetCustomerEmailList();

        public int GetCustomerIdByEmail(string email) => CustomerDAO.Instance.GetCustomerIdByEmail(email);

        public IEnumerable<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomerList();

        public void InsertCustomer(Customer customer) => CustomerDAO.Instance.AddNew(customer);

        public IEnumerable<Customer> SearchCustomerByName(string keyword) => CustomerDAO.Instance.SearchUserByFullName(keyword);    

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.Update(customer);
    }
}
