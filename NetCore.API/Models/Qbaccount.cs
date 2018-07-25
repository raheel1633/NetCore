using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Qbaccount
    {
        public int QbaccountId { get; set; }
        public int ClientId { get; set; }
        public int InvoicelinetypeId { get; set; }
        public string QbAccount1 { get; set; }
        public string QbAccounttype { get; set; }
    }
}
