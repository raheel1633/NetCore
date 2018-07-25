using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EditradingPartnerAlias
    {
        public int EditradingpartneraliasId { get; set; }
        public int EdiproviderId { get; set; }
        public int EditradingpartnerId { get; set; }
        public int ClientId { get; set; }
        public int EntityId { get; set; }
        public string Alias { get; set; }
        public int? Checksum { get; set; }

        public Ediprovider Ediprovider { get; set; }
        public EditradingPartner Editradingpartner { get; set; }
        public Entity Entity { get; set; }
    }
}
