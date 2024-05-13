using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class PaymentOfBillsRepository : IPaymentOfBills
    {
        public void CreatePaymentOBills(PaymentOfBills paymentOfBills)
        {
            var context = ContextClass.paymentOfBills;
            context.Add(paymentOfBills);

        }

        public List<PaymentOfBills> GetAllPaymentOBills()
        {
            var context = ContextClass.paymentOfBills;
            return context;

        }

        public PaymentOfBills GetPaymentOBillsByBillType(string BillType)
        {
             var context = ContextClass.paymentOfBills;
             foreach (var item in context)
             {
                if (item.BillType == BillType)
                {
                    return item;
                }
             }
             return null;

        }

        public PaymentOfBills GetPaymentOBillsByPrice(double Price)
        {
           
             var context = ContextClass.paymentOfBills;
             foreach (var item in context)
             {
                if (item.Price == Price)
                {
                    return item;
                }
             }
             return null;
        }
    }
}