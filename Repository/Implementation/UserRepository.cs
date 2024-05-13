using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
             var context = ContextClass.users;
            context.Add(user);
        }

        public List<User> GetAllUser()
        {
            var context = ContextClass.users;
            return context;
        }

        public User GetUserByEmail(string Email)
        {
            var context = ContextClass.users;
            foreach (var item in context)
            {
                if (item.UserEmail == Email)
                {
                    return item;
                }
            }
            return null;
        }

        public User GetUserById(int id)
        {
             var context = ContextClass.users;
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