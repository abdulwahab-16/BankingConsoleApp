using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class TransactionService : ITransactionService
    {
        public void CreateTransaction(int MoneyRecived, int MoneyTransfered, string UserEmail, TransactionStatus TransactionStatus)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(string TransactionId)
        {
            throw new NotImplementedException();
        }

        public Transaction GetAllTransaction()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionByAccountId(string AccountId)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionByDate(DateTime DateOfTransaction)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionByTransactionId(string TransactionId)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionByUserEmail(string UserEmail)
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(int MoneyRecived, int MoneyTransfered, string UserEmail, TransactionStatus TransactionStatus)
        {
            throw new NotImplementedException();
        }
    }
}