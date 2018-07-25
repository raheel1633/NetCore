using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ExchangeRate
    {
        public int ExchangerateId { get; set; }
        public int BaseCurrencyId { get; set; }
        public int TargetCurrencyId { get; set; }
        public decimal Rate { get; set; }
        public DateTime Date { get; set; }

        public Currency BaseCurrency { get; set; }
        public Currency TargetCurrency { get; set; }
    }
}
