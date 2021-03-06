﻿using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleColorInventoryRegion
    {
        public int StylecolorinventoryregionId { get; set; }
        public int ClientId { get; set; }
        public int StylecolorId { get; set; }
        public int InventoryregionId { get; set; }
        public decimal? FactoryCost { get; set; }
        public decimal? LandedCost { get; set; }
        public int LandedCostCurrencyId { get; set; }
        public int FactorCostCurrencyId { get; set; }

        public Client Client { get; set; }
        public Currency FactorCostCurrency { get; set; }
        public InventoryRegion Inventoryregion { get; set; }
        public Currency LandedCostCurrency { get; set; }
        public StyleColor Stylecolor { get; set; }
    }
}
