using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Salesperson
    {
        public Salesperson()
        {
            CommissionNavigation = new HashSet<Commission>();
            CommissionRule = new HashSet<CommissionRule>();
            Detail = new HashSet<Detail>();
            Invoice = new HashSet<Invoice>();
            Po = new HashSet<Po>();
            SalesBranch = new HashSet<SalesBranch>();
        }

        public int SalespersonId { get; set; }
        public int ClientId { get; set; }
        public string SalespersonCode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? UserId { get; set; }
        public int? SalesbranchId { get; set; }
        public byte[] Rowversion { get; set; }
        public string Commission { get; set; }
        public DateTime? InactiveDate { get; set; }
        public bool? Viewgroupsales { get; set; }
        public string Email { get; set; }
        public string NotificationEmail { get; set; }
        public int? InventoryregionId { get; set; }
        public string ListId { get; set; }
        public int? QboId { get; set; }

        public Client Client { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public SalesBranch Salesbranch { get; set; }
        public ICollection<Commission> CommissionNavigation { get; set; }
        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Detail> Detail { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<SalesBranch> SalesBranch { get; set; }
    }
}
