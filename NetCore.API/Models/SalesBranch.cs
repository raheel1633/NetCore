using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SalesBranch
    {
        public SalesBranch()
        {
            Lot = new HashSet<Lot>();
            SalespersonNavigation = new HashSet<Salesperson>();
        }

        public int SalesbranchId { get; set; }
        public string SalesbranchCode { get; set; }
        public string SalesbranchName { get; set; }
        public int? SalespersonId { get; set; }
        public int? ClientId { get; set; }
        public string NotificationEmail { get; set; }

        public Salesperson Salesperson { get; set; }
        public ICollection<Lot> Lot { get; set; }
        public ICollection<Salesperson> SalespersonNavigation { get; set; }
    }
}
