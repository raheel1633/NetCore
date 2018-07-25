using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Country
    {
        public Country()
        {
            Entity = new HashSet<Entity>();
            InventoryRegion = new HashSet<InventoryRegion>();
            Show = new HashSet<Show>();
            StateProvence = new HashSet<StateProvence>();
            Style = new HashSet<Style>();
        }

        public int CountryId { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public string VatValidation { get; set; }
        public string VatValidationDescription { get; set; }

        public ICollection<Entity> Entity { get; set; }
        public ICollection<InventoryRegion> InventoryRegion { get; set; }
        public ICollection<Show> Show { get; set; }
        public ICollection<StateProvence> StateProvence { get; set; }
        public ICollection<Style> Style { get; set; }
    }
}
