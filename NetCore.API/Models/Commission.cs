using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Commission
    {
        public int CommissionId { get; set; }
        public int ClientId { get; set; }
        public int SalespersonId { get; set; }
        public int? OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public decimal? Rate { get; set; }

        public Client Client { get; set; }
        public Order Order { get; set; }
        public Salesperson Salesperson { get; set; }
    }
}
