using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Major
    {
        public int MajorId { get; set; }
        public int EntityId { get; set; }
        public bool? HasDepartments { get; set; }
        public bool? HasRegions { get; set; }
        public bool? HasDcs { get; set; }
        public bool? HasStores { get; set; }
        public string DirectEdiId { get; set; }
        public bool? InvoiceByComponent { get; set; }
        public string Name { get; set; }
        public bool? InvoicePerStore { get; set; }
        public byte? AsnPerStore { get; set; }
        public string Rules { get; set; }
        public int? LabelformatId { get; set; }
        public bool? AsnByComponent { get; set; }
        public bool? ValidateTrackingnumber { get; set; }
        public bool? OutboundEdiRequires850 { get; set; }

        public Entity Entity { get; set; }
        public LabelFormat Labelformat { get; set; }
    }
}
