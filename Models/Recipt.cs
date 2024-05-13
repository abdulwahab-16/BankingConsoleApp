using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingConsoleProject.Models
{
    public class Recipt : BaseEntity
    {
          public string CustomerBvn {get; set;}
        public string UserEmail{get;set;}
        public string ReciptId { get; set; }
        public string TransactionId{ get; set; }
        public TransactionStatus TransactionStatus{ get; set; }
        public DateTime DateOfIssuedRecipt{ get; set; }
        // public PaymentOfBills PaymentOfBills{get;set;}
        // public DataAndAirtime DataAndAirtime{get;set;}

        public Recipt(int id,string userEmail,string reciptId,string customerBvn,string transactionId,TransactionStatus transactionStatus,PaymentOfBills paymentOfBills,DataAndAirtime dataAndAirtime,DateTime dateOfIssuedRecipt) : base(id)
        {
            Id = id;
            TransactionId = transactionId ;
            TransactionStatus = transactionStatus ;
            DateOfIssuedRecipt = dateOfIssuedRecipt;
            // PaymentOfBills = paymentOfBills ;
            // DataAndAirtime = dataAndAirtime ;
            CustomerBvn = customerBvn ;
            UserEmail =userEmail;
            ReciptId = reciptId;
        }
    }
}