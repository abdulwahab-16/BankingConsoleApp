using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class SuperAdmin : BaseEntity
    {
        public string SuperAdminId {get; set;}
        public string UserEmail{get;set;}
        public Role Role{get;set;}

        public SuperAdmin(int id,string superAdminId,string userEmail,Role role) : base(id)
        {
             Id = id;
             Role = role;
            SuperAdminId  = superAdminId;
            UserEmail = userEmail;
        }
    }
}