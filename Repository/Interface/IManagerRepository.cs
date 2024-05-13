using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IManagerRepository
    {
       public void CreateManager(Manager manager); 
       public Manager GetManagerByEmail(string Email); 
       public Manager GetManagerById( int id);
       public List<Manager> GetAllManager(); 
    }
}