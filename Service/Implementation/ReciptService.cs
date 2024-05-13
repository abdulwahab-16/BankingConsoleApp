using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class ReciptService : IReciptService
    {
        public void CreateRecipt(string UserEmail, TransactionStatus TransactionStatus, DateTime DateOfIssuedRecipt)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipt(string ReciptId)
        {
            throw new NotImplementedException();
        }

        public Recipt GetAllRecipt()
        {
            throw new NotImplementedException();
        }

        public Recipt GetReciptByTranSactionDate(DateTime TransactionDate)
        {
            throw new NotImplementedException();
        }

        public Recipt GetReciptByUserEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipt(string UserEmail, TransactionStatus TransactionStatus, DateTime DateOfIssuedRecipt)
        {
            throw new NotImplementedException();
        }
    }
}