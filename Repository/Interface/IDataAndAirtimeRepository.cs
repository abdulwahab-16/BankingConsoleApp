using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository
{
    public interface IDataAndAirtimeRepository
    {
       public void CreateDataAndAirtime(DataAndAirtime dataAndAirtime); 
       public DataAndAirtime GetDataAndAirtimeByPrice(double Price); 
       public DataAndAirtime GetDataAndAirtimeBySimType( string SimType);
       public List<DataAndAirtime> GetAllDataAndAirtime(); 
    }
}