using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface ICustomerRepository
    {
       public void CreateCustomer(Customer customer); 
       public Customer GetCustomerByEmail(string Email); 
       public Customer GetCustomerById( int id);
       public List<Customer> GetAllCustomer(); 
    }
}