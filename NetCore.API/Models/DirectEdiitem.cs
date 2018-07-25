using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class DirectEdiitem
    {
        public int DirectediitemId { get; set; }
        public int ClientId { get; set; }
        public string Item { get; set; }
        public int? Hashkey { get; set; }
        public int? ProductId { get; set; }
        public int? EntityId { get; set; }
        public byte[] Hash { get; set; }
        public int? Checksum { get; set; }

        public Client Client { get; set; }
        public Product Product { get; set; }
    }
}
