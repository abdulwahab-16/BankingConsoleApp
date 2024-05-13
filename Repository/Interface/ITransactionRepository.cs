using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface ITransactionRepository
    {
       public void CreateTransaction(Transaction transaction); 
       public Transaction GetTransactionByTransactionId(string TransactionId); 
       public Transaction GetTransactionByDate( DateTime DateOfTransaction);
       public Transaction GetTransactionByUserEmail( string UserEmail);
       public Transaction GetTransactionByAccountId( string AccountId);
       public List<Transaction> GetAllTransaction(); 
    }
}