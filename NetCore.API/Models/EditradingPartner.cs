using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EditradingPartner
    {
        public EditradingPartner()
        {
            EdidocumentClientEditradingpartner = new HashSet<Edidocument>();
            EdidocumentEditradingpartner = new HashSet<Edidocument>();
            EditradingPartnerAlias = new HashSet<EditradingPartnerAlias>();
        }

        public int EditradingpartnerId { get; set; }
        public string Qualifier { get; set; }
        public string Id { get; set; }
        public string Configuration { get; set; }
        public int EntityId { get; set; }

        public Entity Entity { get; set; }
        public ICollection<Edidocument> EdidocumentClientEditradingpartner { get; set; }
        public ICollection<Edidocument> EdidocumentEditradingpartner { get; set; }
        public ICollection<EditradingPartnerAlias> EditradingPartnerAlias { get; set; }
    }
}
