using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IPaymentOfBillsService 
    {
          public void CreatePaymentOfBills(string UserEmail,string BillType,TransactionStatus TransactionStatus); 
       public PaymentOfBills GetPaymentOfBillsByPrice(double Price); 
       public PaymentOfBills GetPaymentOfBillsByBillType( string BillType);
       public PaymentOfBills GetAllPaymentOfBills(); 
        public void UpdatePaymentOfBills(string UserEmail,string BillType,TransactionStatus TransactionStatus); 
         public void DeletePaymentOfBills(string BillType); 
    }
}