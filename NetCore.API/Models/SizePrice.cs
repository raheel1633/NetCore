using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SizePrice
    {
        public int? StylecolorId { get; set; }
        public int? StyleId { get; set; }
        public int SizeId { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? CurrencyId { get; set; }
        public int SizepriceId { get; set; }
        public decimal? PromoPrice { get; set; }
        public decimal? CPromoRetail { get; set; }
        public int? SizepricegroupId { get; set; }

        public Currency Currency { get; set; }
        public Size Size { get; set; }
        public SizePriceGroup Sizepricegroup { get; set; }
        public Style Style { get; set; }
        public StyleColor Stylecolor { get; set; }
    }
}
