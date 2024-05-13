using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IReceoptRepository
    {
       public void CreateRecipt(Recipt recipt); 
       public Recipt GetReciptByUserEmail(string Email); 
       public Recipt GetReciptByTranSactionDate( DateTime TransactionDate);
       public List<Recipt> GetAllRecipt(); 
    }
}