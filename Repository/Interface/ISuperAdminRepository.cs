using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface ISuperAdminRepository
    {
       public SuperAdmin GetSuperAdminByEmail(string Email); 
       public SuperAdmin GetSuperAdminById( int id);
       public List<SuperAdmin> GetAllSuperAdmin(); 
    }
}