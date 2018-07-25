using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Price
    {
        public int PriceId { get; set; }
        public string Name { get; set; }
        public int? CurrencyId { get; set; }

        public Currency Currency { get; set; }
    }
}
