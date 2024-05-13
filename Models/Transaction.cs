using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingConsoleProject.Models
{
    public class Transaction : BaseEntity
    {
         public int MoneyRecived{ get; set; }
        public int MoneyTransfered{ get; set; }
        public string TransactionId { get; set; }
        public string UserEmail{get;set;}
        public DateTime DateOfTransaction { get; set; }
        // public PaymentOfBills PaymentOfBills{get;set;}
        // public DataAndAirtime DataAndAirtime{get;set;}
        public string AccountId { get; set; }
         public string CustomerBvn{ get; set; }
          public string ReciptId { get; set; }
        public TransactionStatus TransactionStatus{ get; set; }

        public Transaction(int id,int moneyRecived,int moneyTransfered,string transactionId,string userEmail,string accountId,string customerBvn,PaymentOfBills paymentOfBills,DataAndAirtime dataAndAirtime,string reciptId,TransactionStatus transactionStatus,DateTime dateOfTransaction) : base(id)
        {
            Id = id;
            DateOfTransaction = dateOfTransaction;
            // PaymentOfBills = paymentOfBills ;
            // DataAndAirtime = dataAndAirtime ;
            ReciptId = reciptId ;
            TransactionStatus = transactionStatus ;
            MoneyRecived  = moneyRecived ;
            MoneyTransfered = moneyTransfered ;
            TransactionId  = transactionId ;
            UserEmail = userEmail ;
            AccountId =accountId  ;
            CustomerBvn =  customerBvn;
     
        }


    }
}
       