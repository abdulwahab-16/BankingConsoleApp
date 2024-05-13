using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class User : BaseEntity
    {
        public string UserEmail {get; set;}
        public string FirstName {get; set;}
        public string UserId { get; set; }
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public int Age {get; set;}
        public string Address {get; set;}
        public Gender Gender{get;set;}

        public User( int id,string userEmail,string firstName, string userId,string lastName, string phoneNumber,int age, string address,Gender gender) : base(id)
        {
            Id = id;
            Gender = gender;
            UserEmail =userEmail;
            FirstName = firstName;
            UserId = userId;
            LastName =lastName;
            PhoneNumber = phoneNumber;
            Age =age;
            Address = address;
        }




    }
}