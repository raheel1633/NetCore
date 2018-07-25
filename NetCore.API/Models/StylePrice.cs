using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StylePrice
    {
        public int? StyleId { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? CurrencyId { get; set; }
        public int StylepriceId { get; set; }
        public decimal? PromoPrice { get; set; }
        public decimal? CPromoRetail { get; set; }
        public int? SizepricegroupId { get; set; }
        public byte[] Rowversion { get; set; }
        public decimal? CloseoutPrice { get; set; }
        public decimal? CloseoutRetailPrice { get; set; }

        public Currency Currency { get; set; }
        public SizePriceGroup Sizepricegroup { get; set; }
        public Style Style { get; set; }
    }
}
