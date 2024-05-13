using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface ICustomerService 
    {
         public void CreateCustomer(string Nin,string UserEmail,Role role); 
       public Customer GetCustomerByEmail(string Email); 
       public Customer GetCustomerById( int id);
       public Customer GetAllCustomer(); 
        public void UpdateCustomer(string Nin,string UserEmail); 
         public void DeleteCustomer(string UserEmail); 
    }
}