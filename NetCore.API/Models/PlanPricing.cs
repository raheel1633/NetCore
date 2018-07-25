using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class PlanPricing
    {
        public int PlanpricingId { get; set; }
        public int ClientId { get; set; }
        public int PlanoptionId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public Client Client { get; set; }
        public PlanOption Planoption { get; set; }
    }
}
