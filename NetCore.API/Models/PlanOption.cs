using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class PlanOption
    {
        public PlanOption()
        {
            ClientInvoiceLine = new HashSet<ClientInvoiceLine>();
            PlanPricing = new HashSet<PlanPricing>();
        }

        public int PlanoptionId { get; set; }
        public int PlanId { get; set; }
        public int OptionId { get; set; }
        public decimal Price { get; set; }
        public decimal? Price2 { get; set; }
        public bool? Required { get; set; }
        public int? Quantity { get; set; }
        public string QuantityType { get; set; }
        public decimal? Setup { get; set; }

        public Option Option { get; set; }
        public Plan Plan { get; set; }
        public ICollection<ClientInvoiceLine> ClientInvoiceLine { get; set; }
        public ICollection<PlanPricing> PlanPricing { get; set; }
    }
}
