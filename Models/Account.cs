using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class Account : BaseEntity
    {
        public AccountType AccountType {get; set;}
        public String AccountName {get; set;}
        public String Description { get; set; }
        public string AccountId { get; set; }
        public string UserEmail{get;set;}


        public Account(int id,String accountName, String description, string accountId,AccountType accountType,string userEmail ) : base(id)
        {
            Id = id;
            UserEmail = userEmail;
            AccountType = accountType;
            AccountName = accountName;
            Description = description;
            AccountId =accountId;

        }
    }
}