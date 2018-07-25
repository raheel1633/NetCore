using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Base
    {
        public Base()
        {
            Size = new HashSet<Size>();
            SolidPack = new HashSet<SolidPack>();
            Style = new HashSet<Style>();
        }

        public int BaseId { get; set; }
        public int ClientId { get; set; }
        public string BaseCode { get; set; }
        public string Description { get; set; }
        public byte[] Rowversion { get; set; }
        public string Gender { get; set; }
        public bool Assortment { get; set; }
        public bool? ShowCreatedOnly { get; set; }
        public bool PerSizePricing { get; set; }

        public Client Client { get; set; }
        public ICollection<Size> Size { get; set; }
        public ICollection<SolidPack> SolidPack { get; set; }
        public ICollection<Style> Style { get; set; }
    }
}
