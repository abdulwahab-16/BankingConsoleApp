using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;
using BankingConsoleProject.Repository;
using BankingConsoleProject.Repository.Implementation;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository = new CustomerRepository();
        public void CreateCustomer(string Nin, string UserEmail,Role role)
        {
           var getByEmail = customerRepository.GetCustomerByEmail(UserEmail);
            if (getByEmail.UserEmail == UserEmail)
            {
                System.Console.WriteLine("Email Already Exist");
            }
           var newCustomer = new Customer(ContextClass.customers.Count+1,$"TGYHGDXCVBNMUYTRDGC//gvvbn/4567{ContextClass.customers.Count+1}{ContextClass.customers.Count+5}{ContextClass.customers.Count+7}",Nin,UserEmail,$"4567Acc/{ContextClass.customers.Count+6}/{ContextClass.customers.Count+7}",role);
           customerRepository.CreateCustomer(newCustomer);
        }

        public void DeleteCustomer(string UserEmail)
        {
            var getByEmail = customerRepository.GetCustomerByEmail(UserEmail);
            if (getByEmail==null)
            {
                System.Console.WriteLine("Customer does not exist");
            }
            else
            {
                ContextClass.customers.Remove(getByEmail);
            }
        }

        public Customer GetAllCustomer()
        {
            var getAll = customerRepository.GetAllCustomer();
           foreach (var item in getAll)
           {
              return item;
           }
           return null;
        }

        public Customer GetCustomerByEmail(string Email)
        {
            var getByEmail = customerRepository.GetCustomerByEmail(Email);
            if (getByEmail == null)
            {
                    System.Console.WriteLine("customer does not exist");
                    return null;
            }
            else
            {
                return getByEmail;
            }
        }

        public Customer GetCustomerById(int id)
        {
              var getByEmail = customerRepository.GetCustomerById(id);
            if (getByEmail == null)
            {
                    System.Console.WriteLine("customer does not exist");
                    return null;
            }
            else
            {
                return getByEmail;
            }
        }

        public void UpdateCustomer(string Nin, string UserEmail)
        {
          var getByEmail = customerRepository.GetCustomerByEmail(UserEmail);
             if (getByEmail == null)
             {
                System.Console.WriteLine("customer does not exist");
             }
             else
             {
                getByEmail.Nin = Nin;
             }
        }
    }
}