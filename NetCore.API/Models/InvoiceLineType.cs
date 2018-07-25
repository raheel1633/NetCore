using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InvoiceLineType
    {
        public int InvoicelinetypeId { get; set; }
        public string InvoicelinetypeCode { get; set; }
        public string QbAccount { get; set; }
        public string QbAccounttype { get; set; }
        public string ReportGroup { get; set; }

        public QbItem QbItem { get; set; }
    }
}
