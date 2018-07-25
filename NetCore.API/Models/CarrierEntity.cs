using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CarrierEntity
    {
        public int CarrierentityId { get; set; }
        public int CarrierId { get; set; }
        public int EntityId { get; set; }
        public string AccountNo { get; set; }
        public string Configuration { get; set; }

        public Carrier Carrier { get; set; }
        public Entity Entity { get; set; }
    }
}
