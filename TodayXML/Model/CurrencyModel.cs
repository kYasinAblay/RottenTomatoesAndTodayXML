using System;
using System.Collections.Generic;
using System.Text;

namespace TodayXML.Model
{
  public  class CurrencyModel
    {
        public int Unit { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public string CrossRateUsd { get; set; }
        public decimal ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BankNoteSelling { get; set; }
        public string BankNoteBuying { get; set; }

        public static CurrencyModel Map(Tarih_DateCurrency x)
        {
            return new CurrencyModel
            {
                Unit = x.Unit,
                Name = x.CurrencyName,
                CurrencyCode = x.CurrencyCode,
                BankNoteSelling = x.BanknoteSelling,
                BankNoteBuying = x.BanknoteBuying,
                ForexBuying = x.ForexBuying,
                ForexSelling = x.ForexSelling,
                CrossRateUsd = x.CrossRateUSD
            };
        }
    }
}
