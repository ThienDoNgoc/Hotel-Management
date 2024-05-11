using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepo
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> SearchCustomerByName(string keyword);

        Customer GetCustomerByID(int id);
        List<String> GetCustomerEmailList();
        bool CheckCustomerEmailExist(string email);
        bool CheckUserLogin(string email, string password);
        Customer GetCustomerByEmail(string email);
        int GetCustomerIdByEmail(string email);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
