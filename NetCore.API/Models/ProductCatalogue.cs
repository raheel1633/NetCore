using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ProductCatalogue
    {
        public int ProductcatalogueId { get; set; }
        public int CatalogueId { get; set; }
        public int ProductId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public int BatchId { get; set; }
        public int ClientId { get; set; }

        public Catalogue Catalogue { get; set; }
    }
}
