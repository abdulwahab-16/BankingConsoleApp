using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;
using BankingConsoleProject.Repository;
using BankingConsoleProject.Repository.Implementation;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class AccountService : IAccountService
    {
        IAccountRepository accountRepository = new AccountReposirory();
        public void CreateAccount(string AccountName, string Description, string UserEmail,AccountType accountType)
        {
            var getByEmail = accountRepository.GetAccountByEmail(UserEmail);
            if (getByEmail.UserEmail == UserEmail)
            {
                System.Console.WriteLine("Email Already Exist");
            }
           var newAccount = new Account(ContextClass.accounts.Count+1,AccountName,Description,$"Acc/445/6/0{ContextClass.accounts.Count+1}",accountType,UserEmail);
           accountRepository.CreateAccount(newAccount);
        }

        public void DeleteAccount(string UserEmail)
        {
            var getByEmail = accountRepository.GetAccountByEmail(UserEmail);
            if (getByEmail==null)
            {
                System.Console.WriteLine("Account does not exist");
            }
            else
            {
                ContextClass.accounts.Remove(getByEmail);
            }
        }

        public Account GetAccountByAccountId(int id)
        {
          var getById = accountRepository.GetAccountByAccountId(id);
          if (getById == null)
          {
                System.Console.WriteLine("Account does not exist");
                return null;
          }
          else
          {
            return getById;
          }
        }

        public Account GetAccountByEmail(string Email)
        {
            var getByEmail = accountRepository.GetAccountByEmail(Email);
            if (getByEmail == null)
            {
                    System.Console.WriteLine("Account does not exist");
                    return null;
            }
            else
            {
                return getByEmail;
            }
        }

        public Account GetAllAcounts()
        {
            var getAll = accountRepository.GetAllAcounts();
            
           foreach (var item in getAll)
           {
              return item;
           }
           return null;
        }

        public void UpdateAccount(string AccountName, string Description, string UserEmail)
        {
             var getByEmail = accountRepository.GetAccountByEmail(UserEmail);
             if (getByEmail == null)
             {
                System.Console.WriteLine("Account does not exist");
             }
             else
             {
                getByEmail.AccountName = AccountName;
                getByEmail.Description = Description;

             }

        }
    }
}