using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ProductAlias
    {
        public ProductAlias()
        {
            OrderLine = new HashSet<OrderLine>();
        }

        public int ProductaliasId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int? EntityId { get; set; }
        public byte[] Productalias1 { get; set; }
        public int ProductaliasType { get; set; }
        public string Alias { get; set; }
        public int? Checksum { get; set; }
        public decimal? Price { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? InactiveDate { get; set; }
        public int? InventoryLevel { get; set; }
        public DateTime? InventoryDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public int? ExpectedQuantity { get; set; }

        public Currency Currency { get; set; }
        public Entity Entity { get; set; }
        public Product Product { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
    }
}
