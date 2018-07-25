using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbAccounts
    {
        public int QbAccountsId { get; set; }
        public int? QbcId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ListId { get; set; }
        public string Xml { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyListid { get; set; }
    }
}
