using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class ReciptRepository : IReceoptRepository
    {
        public void CreateRecipt(Recipt recipt)
        {
            var context = ContextClass.recipts;
            context.Add(recipt);

        }

        public List<Recipt> GetAllRecipt()
        {
             var context = ContextClass.recipts;
           return context;
        }

        public Recipt GetReciptByTranSactionDate(DateTime TransactionDate)
        {
             var context = ContextClass.recipts;
            foreach (var item in context)
            {
              if (item.DateOfIssuedRecipt == TransactionDate)
              {
                 return item;
              }
            }
            return null;
        }

        public Recipt GetReciptByUserEmail(string Email)
        {
            var context = ContextClass.recipts;
            foreach (var item in context)
            {
              if (item.UserEmail == Email)
              {
                 return item;
              }
            }
            return null;
        }
    }
}