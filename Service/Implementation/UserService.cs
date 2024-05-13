using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class UserService : IUserService
    {
        public void CreateUser(string UserEmail, string FirstName, string LastName, string PhoneNumber, int Age, string Address, Gender Gender)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string Email)
        {
            throw new NotImplementedException();
        }

        public User GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string OldEmail, string UserEmail, string FirstName, string LastName, string PhoneNumber, int Age, string Address)
        {
            throw new NotImplementedException();
        }
    }
}