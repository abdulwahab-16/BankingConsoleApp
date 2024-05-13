using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface ISuperAdminService 
    {
         public SuperAdmin GetSuperAdminByEmail(string Email); 
       public SuperAdmin GetSuperAdminById( int id);
       public SuperAdmin GetAllSuperAdmin(); 
        public void UpdateSuperAdmin(string Email); 
     
    }
}