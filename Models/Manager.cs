using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class Manager : BaseEntity
    {
        public string ManagerId {get; set;}
        public string UserEmail{get;set;}
        public Role Role{get;set;}

        public Manager(int id,string managerId,string userEmail,Role role) : base(id)
        {
            Id = id;
            Role = role;
            ManagerId = managerId;
            UserEmail = userEmail;
        }
    }
}