using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Assortment
    {
        public int AssortmentId { get; set; }
        public int ClientId { get; set; }
        public int AssortmentProductId { get; set; }
        public int ComponentProductId { get; set; }
        public short Quantity { get; set; }
        public byte[] Rowversion { get; set; }

        public Product AssortmentProduct { get; set; }
        public Client Client { get; set; }
        public Product ComponentProduct { get; set; }
    }
}
