using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Upcblock
    {
        public Upcblock()
        {
            Division = new HashSet<Division>();
            Product = new HashSet<Product>();
            Upcreuse = new HashSet<Upcreuse>();
        }

        public int UpcblockId { get; set; }
        public int ClientId { get; set; }
        public string CompanyPrefix { get; set; }
        public int? Sequence { get; set; }
        public int? Size { get; set; }
        public int? OriginalBlockId { get; set; }
        public byte[] Rowversion { get; set; }
        public bool Internal { get; set; }
        public byte[] CertificateImage { get; set; }

        public ICollection<Division> Division { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Upcreuse> Upcreuse { get; set; }
    }
}
