using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IReciptService 
    {
          public void CreateRecipt(string UserEmail,TransactionStatus TransactionStatus,DateTime DateOfIssuedRecipt); 
       public Recipt GetReciptByUserEmail(string Email); 
       public Recipt GetReciptByTranSactionDate( DateTime TransactionDate);
       public Recipt GetAllRecipt(); 
        public void UpdateRecipt(string UserEmail,TransactionStatus TransactionStatus,DateTime DateOfIssuedRecipt); 
        public void DeleteRecipt(string ReciptId); 
    }
}