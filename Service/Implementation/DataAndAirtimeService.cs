using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;
using BankingConsoleProject.Repository;
using BankingConsoleProject.Repository.Implementation;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class DataAndAirtimeService : IDataAndAirtimeService
    {
        IDataAndAirtimeRepository dataAndAirtimeRepository = new DataAndAirtimeRepository();
        public void CreateDataAndAirtime(string UserEmail, string SimType, string AirtimeBundle, string DataBundle, double Price, TransactionStatus TransactionStatus)
        {
             var getByEmail = dataAndAirtimeRepository.(UserEmail);
            if (getByEmail.UserEmail == UserEmail)
            {
                System.Console.WriteLine("Email Already Exist");
            }
           var newCustomer = new Customer(ContextClass.customers.Count+1,$"TGYHGDXCVBNMUYTRDGC//gvvbn/4567{ContextClass.customers.Count+1}{ContextClass.customers.Count+5}{ContextClass.customers.Count+7}",Nin,UserEmail,$"4567Acc/{ContextClass.customers.Count+6}/{ContextClass.customers.Count+7}",role);
           customerRepository.CreateCustomer(newCustomer);
        }

        public void DeleteDataAndAirtime(string DataBundle, double Price)
        {
            throw new NotImplementedException();
        }

        public DataAndAirtime GetAllDataAndAirtime()
        {
            throw new NotImplementedException();
        }

        public DataAndAirtime GetDataAndAirtimeByPrice(double Price)
        {
            throw new NotImplementedException();
        }

        public DataAndAirtime GetDataAndAirtimeBySimType(string SimType)
        {
            throw new NotImplementedException();
        }

        public void UpdateDataAndAirtime(string UserEmail, string SimType, string AirtimeBundle, string DataBundle, double Price, TransactionStatus TransactionStatus)
        {
            throw new NotImplementedException();
        }
    }
}