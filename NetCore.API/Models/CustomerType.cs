using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CustomerType
    {
        public int CustomertypeId { get; set; }
        public string Name { get; set; }
        public int? ClientId { get; set; }
    }
}
