using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Catalogue
    {
        public Catalogue()
        {
            ProductCatalogue = new HashSet<ProductCatalogue>();
        }

        public int CatalogueId { get; set; }
        public string CatalogueName { get; set; }
        public int? EntityId { get; set; }
        public bool? HasSelection { get; set; }
        public bool? HasLogin { get; set; }
        public bool? HasName { get; set; }

        public ICollection<ProductCatalogue> ProductCatalogue { get; set; }
    }
}
