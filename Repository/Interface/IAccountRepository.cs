using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IAccountRepository
    {
       public void CreateAccount(Account account); 
       public Account GetAccountByEmail(string Email); 
       public Account GetAccountByAccountId( int id);
       public List<Account> GetAllAcounts(); 

    }
}