using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class TradingPartnerAlias
    {
        public int DirectediitemId { get; set; }
        public int ClientId { get; set; }
        public string Xml { get; set; }
        public int? AliasId { get; set; }
        public int? TradingpartnerId { get; set; }
        public int? Aliastype { get; set; }

        public TradingPartner Tradingpartner { get; set; }
    }
}
