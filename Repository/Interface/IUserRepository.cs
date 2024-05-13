using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IUserRepository
    {
       public void CreateUser(User user); 
       public User GetUserByEmail(string Email); 
       public User GetUserById( int id);
       public List<User> GetAllUser(); 
    }
}