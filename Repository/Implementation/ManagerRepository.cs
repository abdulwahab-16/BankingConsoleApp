using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class ManagerRepository : IManagerRepository
    {
        public void CreateManager(Manager manager)
        {
            var context = ContextClass.managers;
            context.Add(manager);

        }

        public List<Manager> GetAllManager()
        {
             var context = ContextClass.managers;
             return context;

        }

        public Manager GetManagerByEmail(string Email)
        {            
            var context = ContextClass.managers;
            foreach (var item in context)
            {
                if (item.UserEmail == Email)
                {
                    return item; 
                }
            }
            return null;

        }

        public Manager GetManagerById(int id)
        {
            var context = ContextClass.managers;
            foreach (var item in context)
            {
                if (item.Id == id)
                {
                    return item; 
                }
            }
            return null;
        }
    }
}