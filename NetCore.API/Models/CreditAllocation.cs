using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CreditAllocation
    {
        public int CreditallocationId { get; set; }
        public int CreditrequestId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public byte[] Rownumber { get; set; }

        public CreditRequest Creditrequest { get; set; }
        public Invoice Invoice { get; set; }
    }
}
