using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbClasses
    {
        public QbClasses()
        {
            Brand = new HashSet<Brand>();
            Division = new HashSet<Division>();
        }

        public int QbClassesId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string ListId { get; set; }
        public string FullName { get; set; }
        public string Item { get; set; }
        public bool? Active { get; set; }

        public ICollection<Brand> Brand { get; set; }
        public ICollection<Division> Division { get; set; }
    }
}
