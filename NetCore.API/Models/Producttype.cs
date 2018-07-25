using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Producttype
    {
        public Producttype()
        {
            InverseParentProducttype = new HashSet<Producttype>();
            Style = new HashSet<Style>();
        }

        public int ProducttypeId { get; set; }
        public string Name { get; set; }
        public int? ClientId { get; set; }
        public string Configuration { get; set; }
        public decimal? PricePoints { get; set; }
        public int? ParentProducttypeId { get; set; }

        public Client Client { get; set; }
        public Producttype ParentProducttype { get; set; }
        public ICollection<Producttype> InverseParentProducttype { get; set; }
        public ICollection<Style> Style { get; set; }
    }
}
