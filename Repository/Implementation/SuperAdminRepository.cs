using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class SuperAdminRepository : ISuperAdminRepository
    {
        public List<SuperAdmin> GetAllSuperAdmin()
        {
            var context = ContextClass.superAdmins;
            return context;

        }

        public SuperAdmin GetSuperAdminByEmail(string Email)
        {
             var context = ContextClass.superAdmins;
            foreach (var item in context)
            {
              if (item.UserEmail == Email)
              {
                 return item;
              }
            }
            return null;
        }

        public SuperAdmin GetSuperAdminById(int id)
        {
            var context = ContextClass.superAdmins;
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