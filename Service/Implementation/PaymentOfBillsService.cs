using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;
using BankingConsoleProject.Service.Interface;

namespace BankingConsoleProject.Service.Implementation
{
    public class paymentOfBillsService : IPaymentOfBillsService
    {
        public void CreatePaymentOfBills(string UserEmail, string BillType, TransactionStatus TransactionStatus)
        {
            throw new NotImplementedException();
        }

        public void DeletePaymentOfBills(string BillType)
        {
            throw new NotImplementedException();
        }

        public PaymentOfBills GetAllPaymentOfBills()
        {
            throw new NotImplementedException();
        }

        public PaymentOfBills GetPaymentOfBillsByBillType(string BillType)
        {
            throw new NotImplementedException();
        }

        public PaymentOfBills GetPaymentOfBillsByPrice(double Price)
        {
            throw new NotImplementedException();
        }

        public void UpdatePaymentOfBills(string UserEmail, string BillType, TransactionStatus TransactionStatus)
        {
            throw new NotImplementedException();
        }
    }
}