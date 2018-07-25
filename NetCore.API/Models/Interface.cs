using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Interface
    {
        public int InterfaceId { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }
    }
}
