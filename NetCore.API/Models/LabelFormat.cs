using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class LabelFormat
    {
        public LabelFormat()
        {
            Major = new HashSet<Major>();
        }

        public int LabelformatId { get; set; }
        public string LabelformatCode { get; set; }

        public ICollection<Major> Major { get; set; }
    }
}
