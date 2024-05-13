using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingConsoleProject.Service.Interface
{
    public interface ITransactionService 
    {
        public void CreateTransaction(int MoneyRecived,int MoneyTransfered,string UserEmail,TransactionStatus TransactionStatus); 
       public Transaction GetTransactionByTransactionId(string TransactionId); 
       public Transaction GetTransactionByDate( DateTime DateOfTransaction);
       public Transaction GetTransactionByUserEmail( string UserEmail);
       public Transaction GetTransactionByAccountId( string AccountId);
       public Transaction GetAllTransaction(); 
        public void UpdateTransaction(int MoneyRecived,int MoneyTransfered,string UserEmail,TransactionStatus TransactionStatus); 
        public void DeleteTransaction(string TransactionId); 
    }
}