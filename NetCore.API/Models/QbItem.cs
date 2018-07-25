using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbItem
    {
        public int QbItemId { get; set; }
        public int ClientId { get; set; }
        public int InvoicelinetypeId { get; set; }
        public string Item { get; set; }

        public Client Client { get; set; }
        public InvoiceLineType QbItemNavigation { get; set; }
    }
}
