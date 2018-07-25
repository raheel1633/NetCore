using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class MontisvirEntity
    {
        public int MontisvirentityId { get; set; }
        public int ClientId { get; set; }
        public int EntityId { get; set; }
        public string ClientXref { get; set; }
        public string MontisvirCode { get; set; }
        public string MontisvirSearchkey { get; set; }

        public Entity Entity { get; set; }
    }
}
