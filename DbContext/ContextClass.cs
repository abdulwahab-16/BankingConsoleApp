using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.DbContext
{
    public class ContextClass
    {
        public static List<Account> accounts = new List<Account>();
        public static List<Customer> customers = new List<Customer>();
        public static List<DataAndAirtime> dataAndAirtimes = new List<DataAndAirtime>();
        public static List<Manager> managers = new List<Manager>();
        public static List<PaymentOfBills> paymentOfBills = new List<PaymentOfBills>();
        public static List<Recipt> recipts = new List<Recipt>();
        public static List<SuperAdmin> superAdmins = new List<SuperAdmin>()
        {
            new SuperAdmin(1,"SuperAdmin001jw","Abdulwahab@gmail.com",Role.SuperAdmin)
        };
        public static List<Transaction> transactions = new List<Transaction>();
        public static List<User> users = new List<User>();



    }
}