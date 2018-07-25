using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Size
    {
        public Size()
        {
            CasePackCaseSize = new HashSet<CasePack>();
            CasePackPackSize = new HashSet<CasePack>();
            Product = new HashSet<Product>();
            SizeMatrixSize = new HashSet<SizeMatrixSize>();
            SizePrice = new HashSet<SizePrice>();
        }

        public int SizeId { get; set; }
        public int ClientId { get; set; }
        public string SizeCode { get; set; }
        public string DisplaySizeCode { get; set; }
        public string NrfCode { get; set; }
        public string Description { get; set; }
        public int? BaseId { get; set; }
        public int? Sort { get; set; }
        public bool? Active { get; set; }
        public byte[] Rowversion { get; set; }
        public int? Pack { get; set; }
        public string QrsSize { get; set; }
        public bool? DynamicProducts { get; set; }

        public Base Base { get; set; }
        public ICollection<CasePack> CasePackCaseSize { get; set; }
        public ICollection<CasePack> CasePackPackSize { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<SizeMatrixSize> SizeMatrixSize { get; set; }
        public ICollection<SizePrice> SizePrice { get; set; }
    }
}
