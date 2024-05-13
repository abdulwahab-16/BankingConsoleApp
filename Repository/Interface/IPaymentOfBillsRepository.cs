using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IPaymentOfBills
    {
       public void CreatePaymentOBills(PaymentOfBills paymentOfBills); 
       public PaymentOfBills GetPaymentOBillsByPrice(double Price); 
       public PaymentOfBills GetPaymentOBillsByBillType( string BillType);
       public List<PaymentOfBills> GetAllPaymentOBills(); 
    }
}