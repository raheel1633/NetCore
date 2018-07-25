using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SizeMatrixSize
    {
        public int SizematrixId { get; set; }
        public int ClientId { get; set; }
        public int SizeId { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int? X2 { get; set; }
        public int? Y2 { get; set; }

        public Client Client { get; set; }
        public Size Size { get; set; }
        public SizeMatrix Sizematrix { get; set; }
    }
}
