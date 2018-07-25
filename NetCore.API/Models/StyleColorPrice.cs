using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleColorPrice
    {
        public int? StylecolorId { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? CurrencyId { get; set; }
        public int StylecolorpriceId { get; set; }
        public decimal? PromoPrice { get; set; }
        public decimal? CPromoRetail { get; set; }
        public int? SizepricegroupId { get; set; }
        public decimal? CloseoutPrice { get; set; }
        public decimal? CloseoutRetailPrice { get; set; }

        public Currency Currency { get; set; }
        public SizePriceGroup Sizepricegroup { get; set; }
        public StyleColor Stylecolor { get; set; }
    }
}
