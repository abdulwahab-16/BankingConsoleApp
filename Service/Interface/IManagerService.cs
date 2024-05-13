using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IMangerService 
    {
        public void CreateManager(string UserEmail); 
       public Manager GetManagerByEmail(string Email); 
       public Manager GetManagerById( int id);
       public Manager GetAllManager(); 
        public void UpdateManager(string UserEmail); 
         public void DeleteManager(string UserEmail); 
    }
}