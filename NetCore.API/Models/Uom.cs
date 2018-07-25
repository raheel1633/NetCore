using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Uom
    {
        public Uom()
        {
            Style = new HashSet<Style>();
        }

        public int UomId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<Style> Style { get; set; }
    }
}
