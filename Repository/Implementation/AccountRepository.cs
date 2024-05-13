using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class AccountReposirory : IAccountRepository
    {
        public void CreateAccount(Account account)
        {
            var context = ContextClass.accounts;
            // var newAccount = new Account(context.Count+1,accountName,description,$"ACC/456/00{context.Count+1}",accountType,email);
            context.Add(account);
        }

        public Account GetAccountByAccountId(int id)
        {
            var context = ContextClass.accounts;
            foreach (var item in context)
            {
                if (item.Id == id)
                {
                    return item; 
                }
            }
            return null;

        }

        public Account GetAccountByEmail(string Email)
        {
            var context = ContextClass.accounts;
            foreach (var item in context)
            {
                if (item.UserEmail == Email)
                {
                    return item; 
                }
            }
            return null;
        }

        public List<Account> GetAllAcounts()
        {
            return ContextClass.accounts;
        }
    }
}