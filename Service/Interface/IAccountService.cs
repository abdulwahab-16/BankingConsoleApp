using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IAccountService 
    {
        public void CreateAccount(String AccountName,String Description,string UserEmail,AccountType accountType); 
       public Account GetAccountByEmail(string Email); 
       public Account GetAccountByAccountId( int id);
       public Account GetAllAcounts(); 
        public void UpdateAccount(String AccountName,String Description,string UserEmail); 
         public void DeleteAccount(string UserEmail); 
    }
}