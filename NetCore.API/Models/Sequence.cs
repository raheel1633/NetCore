using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Sequence
    {
        public int SequenceId { get; set; }
        public int ClientId { get; set; }
        public string SequenceCode { get; set; }
        public int Sequence1 { get; set; }
        public short? ZeroPadding { get; set; }
        public string Prefix { get; set; }
        public byte[] Rowversion { get; set; }
        public int? Rollover { get; set; }
        public int? Start { get; set; }
    }
}
