using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InvoicePayment
    {
        public int InvoicepaymentId { get; set; }
        public int InvoiceId { get; set; }
        public int ClientId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public decimal Amount { get; set; }
        public string ReferenceNo { get; set; }
        public string TxnId { get; set; }
        public int PaymentType { get; set; }
        public string QbAccountListid { get; set; }
    }
}
