using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EntityEdiprovider
    {
        public int EntityId { get; set; }
        public int EdiproviderId { get; set; }
        public string Configuration { get; set; }

        public Ediprovider Ediprovider { get; set; }
        public Entity Entity { get; set; }
    }
}
