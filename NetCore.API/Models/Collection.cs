using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Collection
    {
        public int CollectionId { get; set; }
        public string CollectionCode { get; set; }
        public string Description { get; set; }
        public int? SeasonId { get; set; }
        public int? ClientId { get; set; }
    }
}
