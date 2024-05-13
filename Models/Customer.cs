    
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class Customer : BaseEntity
    {
         public string Bvn {get; set;}
        public string Nin {get; set;}
        public string UserEmail{get;set;}
        public string AccountId { get; set; }
        public Role Role{get;set;}
        public Customer(int id,string bvn,string nin,string userEmail,string accountId,Role role) : base(id)
        {
            Id = id;
            Bvn  =  bvn;
            Nin = nin;
            Role = role;
            UserEmail = userEmail;
            AccountId  = accountId;
        }


    }
}
    
    
    
   