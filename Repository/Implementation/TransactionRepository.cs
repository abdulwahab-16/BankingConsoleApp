using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class Transactionrepository : ITransactionRepository
    {
        public void CreateTransaction(Transaction transaction)
        {
            var context = ContextClass.transactions;
            context.Add(transaction);

        }

        public List<Transaction> GetAllTransaction()
        {
            var context = ContextClass.transactions;
            return context;
        }

        public Transaction GetTransactionByAccountId(string AccountId)
        {
            var context = ContextClass.transactions;
            foreach (var item in context)
            {
                if (item.AccountId == AccountId)
                {
                    return item;
                }
            }
            return null;
        }

        public Transaction GetTransactionByDate(DateTime DateOfTransaction)
        {
            var context = ContextClass.transactions;
            foreach (var item in context)
            {
                if (item.DateOfTransaction == DateOfTransaction)
                {
                    return item;
                }
            }
            return null;        
        }

        public Transaction GetTransactionByTransactionId(string TransactionId)
        {
            var context = ContextClass.transactions;
            foreach (var item in context)
            {
                if (item.TransactionId == TransactionId)
                {
                    return item;
                }
            }
            return null;
        }

        public Transaction GetTransactionByUserEmail(string UserEmail)
        {
              var context = ContextClass.transactions;
            foreach (var item in context)
            {
                if (item.UserEmail == UserEmail)
                {
                    return item;
                }
            }
            return null;
        }
    }
}