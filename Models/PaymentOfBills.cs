using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingConsoleProject.Models
{
    public class PaymentOfBills : BaseEntity
    {
        public string CustomerBvn {get; set;}
         public string UserEmail{get;set;}
        public string BillType {get; set;}
        public double Price { get; set; }
        public string ReciptId { get; set; }
        public string TransactionId { get; set; }
        public TransactionStatus TransactionStatus{ get; set; }

        public PaymentOfBills(int id,string userEmail,string billType, double price,string customerBvn,string reciptId,string transactionId,TransactionStatus transactionStatus) : base (id)
        {
            Id = id;
            ReciptId =  reciptId;
            TransactionId = transactionId;
            TransactionStatus = transactionStatus;
            UserEmail  =  userEmail;
            BillType = billType;
            Price  = price;
            CustomerBvn = customerBvn;
        }
    }
}