using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingConsoleProject.Models
{
    public class DataAndAirtime : BaseEntity
    {
        public string CustomerBvn {get; set;}
        public string UserEmail{get;set;}
        public string SimType {get; set;}
        public string AirtimeBundle { get; set; }
        public string DataBundle { get; set; }
        public double Price { get; set; }
        public string ReciptId { get; set; }
        public string TransactionId { get; set; }
        public TransactionStatus TransactionStatus{ get; set; }


        public DataAndAirtime( int id,string userEmail, string simType,string airtimeBundle,string dataBundle, double price,string customerBvn,string reciptId,string transactionId,TransactionStatus transactionStatus) : base (id)
        {
            Id = id;
            ReciptId  = reciptId;
            TransactionId = transactionId ;
            TransactionStatus   = transactionStatus;
            UserEmail = userEmail;
            SimType = simType;
            AirtimeBundle = airtimeBundle;
            DataBundle = dataBundle;
            CustomerBvn = customerBvn;
            Price = price;

        }

    }
}