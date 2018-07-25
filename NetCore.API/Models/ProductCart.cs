using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ProductCart
    {
        public int ProductcartId { get; set; }
        public string PartnerId { get; set; }
        public string PartnerPassword { get; set; }
        public string PartnerKey { get; set; }
        public string Endpoint { get; set; }
        public int? ClientId { get; set; }
    }
}
