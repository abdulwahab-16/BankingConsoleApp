using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        public void CreateCustomer(Customer customer)
        {
            var context = ContextClass.customers;
            context.Add(customer);

        }

        public List<Customer> GetAllCustomer()
        {
            var context = ContextClass.customers;
            return context;
        }

        public Customer GetCustomerByEmail(string Email)
        {
              var context = ContextClass.customers;
            foreach (var item in context)
            {
                if (item.UserEmail == Email)
                {
                    return item; 
                }
            }
            return null;
        }

        public Customer GetCustomerById(int id)
        {
            var context = ContextClass.customers;
            foreach (var item in context)
            {
                if (item.Id == id)
                {
                    return item; 
                }
            }
            return null;        
        }
    }
}