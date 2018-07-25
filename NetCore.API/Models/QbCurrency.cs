using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbCurrency
    {
        public QbCurrency()
        {
            Currency = new HashSet<Currency>();
        }

        public int QbCurrencyId { get; set; }
        public int? QbcId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ListId { get; set; }
        public string CurrencyCode { get; set; }
        public string Xml { get; set; }

        public Client Client { get; set; }
        public Qbc Qbc { get; set; }
        public ICollection<Currency> Currency { get; set; }
    }
}
