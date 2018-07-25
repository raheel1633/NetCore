using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class TradingPartner
    {
        public TradingPartner()
        {
            TradingPartnerAlias = new HashSet<TradingPartnerAlias>();
        }

        public int TradingpartnerId { get; set; }
        public string TradingPartnerId1 { get; set; }
        public int EntityId { get; set; }
        public int ClientId { get; set; }
        public int? Connectiontype { get; set; }
        public bool? RequiresAsn { get; set; }

        public ICollection<TradingPartnerAlias> TradingPartnerAlias { get; set; }
    }
}
