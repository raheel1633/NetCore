using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AssignmentInvoice
    {
        public int AssignmentinvoiceId { get; set; }
        public int AssignmentId { get; set; }
        public int InvoiceId { get; set; }

        public Assignment Assignment { get; set; }
        public Invoice Invoice { get; set; }
    }
}
