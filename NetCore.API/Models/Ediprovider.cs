using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Ediprovider
    {
        public Ediprovider()
        {
            Edidocument = new HashSet<Edidocument>();
            EditradingPartnerAlias = new HashSet<EditradingPartnerAlias>();
            EntityEdiprovider = new HashSet<EntityEdiprovider>();
        }

        public int EdiproviderId { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }
        public bool RequireReference { get; set; }
        public string Configuration { get; set; }

        public Entity Entity { get; set; }
        public ICollection<Edidocument> Edidocument { get; set; }
        public ICollection<EditradingPartnerAlias> EditradingPartnerAlias { get; set; }
        public ICollection<EntityEdiprovider> EntityEdiprovider { get; set; }
    }
}
