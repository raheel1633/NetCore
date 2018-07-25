using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbInvoices
    {
        public int QbInvoicesId { get; set; }
        public int InvoiceId { get; set; }
        public int QbRequestId { get; set; }
        public int QbcId { get; set; }
        public string TxnId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public string Name { get; set; }
        public int? QbwcId { get; set; }
        public int? LatestQbwcId { get; set; }
    }
}
