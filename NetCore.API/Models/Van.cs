using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Van
    {
        public int VanId { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }
        public string Configuration { get; set; }

        public Entity Entity { get; set; }
    }
}
