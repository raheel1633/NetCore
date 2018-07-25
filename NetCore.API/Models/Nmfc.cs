using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Nmfc
    {
        public Nmfc()
        {
            Style = new HashSet<Style>();
        }

        public int NmfcId { get; set; }
        public string NmfcCode { get; set; }
        public decimal? NmfcClass { get; set; }
        public string Description { get; set; }
        public string NmfcSubclass { get; set; }

        public ICollection<Style> Style { get; set; }
    }
}
