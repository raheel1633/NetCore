using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Upcreuse
    {
        public int UpcreuseId { get; set; }
        public int UpcblockId { get; set; }
        public int Sequence { get; set; }
        public DateTime? ReuseDate { get; set; }
        public byte[] Rowversion { get; set; }

        public Upcblock Upcblock { get; set; }
    }
}
