using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class InvoiceSendHistory
    {
        public int InvoicesendhistoryId { get; set; }
        public int ClientId { get; set; }
        public int InvoiceId { get; set; }
        public int? Transport { get; set; }
        public DateTime? SendDate { get; set; }
        public Guid? UserId { get; set; }
        public int? DirectediId { get; set; }
        public string Email { get; set; }

        public Invoice Invoice { get; set; }
    }
}
