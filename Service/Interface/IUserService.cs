using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IUserService
    {
        public void CreateUser(string UserEmail,string FirstName,string LastName,string PhoneNumber,int Age,string Address,Gender Gender);
        public User GetUserByEmail(string Email);
        public User GetUserById(int id);
        public User GetAllUser();
        public void UpdateUser(string OldEmail,string UserEmail, string FirstName, string LastName, string PhoneNumber, int Age, string Address);
        public void DeleteUser(string Email);

    }
}