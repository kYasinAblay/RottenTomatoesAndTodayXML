using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodayXML.Model;

namespace TodayXML
{
    public interface ICurrencyService
    {
        Task<CurrencyModel[]> GetToday();
        Task<CurrencyModel[]> GetByDate(DateTime date);
    }
}
