using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingConsoleProject.DbContext;
using BankingConsoleProject.Models;

namespace BankingConsoleProject.Repository.Implementation
{
    public class DataAndAirtimeRepository : IDataAndAirtimeRepository
    {
        public void CreateDataAndAirtime(DataAndAirtime dataAndAirtime)
        {
            var context = ContextClass.dataAndAirtimes;
            context.Add(dataAndAirtime);

        }

        public List<DataAndAirtime> GetAllDataAndAirtime()
        {
            var context = ContextClass.dataAndAirtimes;
            return context;

        }

        public DataAndAirtime GetDataAndAirtimeByPrice(double Price)
        {
            var context = ContextClass.dataAndAirtimes;
            foreach (var item in context)
            {
                if (item.Price == Price)
                {
                    return item; 
                }
            }
            return null;
        }

        public DataAndAirtime GetDataAndAirtimeBySimType(string SimType)
        {
            var context = ContextClass.dataAndAirtimes;
            foreach (var item in context)
            {
                if (item.SimType == SimType)
                {
                    return item; 
                }
            }
            return null;
        }
    }
}