using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Service.Interface
{
    public interface IDataAndAirtimeService 
    {
        public void CreateDataAndAirtime(string UserEmail,string SimType,string AirtimeBundle,string DataBundle,double Price,TransactionStatus TransactionStatus); 
       public DataAndAirtime GetDataAndAirtimeByPrice(double Price); 
       public DataAndAirtime GetDataAndAirtimeBySimType( string SimType);
       public DataAndAirtime GetAllDataAndAirtime(); 
        public void UpdateDataAndAirtime(string UserEmail,string SimType,string AirtimeBundle ,string DataBundle ,double Price,TransactionStatus TransactionStatus); 
        public void DeleteDataAndAirtime(string DataBundle,double Price ); 
    }
}