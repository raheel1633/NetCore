using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Box
    {
        public Box()
        {
            Asn = new HashSet<Asn>();
        }

        public int BoxId { get; set; }
        public int? ClientId { get; set; }
        public string BoxCode { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int? WeightDimensionId { get; set; }
        public int? LengthDimensionId { get; set; }
        public string Configuration { get; set; }
        public int? ProductId { get; set; }

        public Client Client { get; set; }
        public Dimension LengthDimension { get; set; }
        public Product Product { get; set; }
        public Dimension WeightDimension { get; set; }
        public ICollection<Asn> Asn { get; set; }
    }
}
