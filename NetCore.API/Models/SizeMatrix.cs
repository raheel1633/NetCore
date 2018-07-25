using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SizeMatrix
    {
        public SizeMatrix()
        {
            SizeMatrixSize = new HashSet<SizeMatrixSize>();
            SizePriceGroup = new HashSet<SizePriceGroup>();
        }

        public int SizematrixId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int X1Positions { get; set; }
        public int Y1Positions { get; set; }
        public int X2Positions { get; set; }
        public int Y2Positions { get; set; }
        public string X1Headings { get; set; }
        public string Y1Headings { get; set; }
        public string X2Headings { get; set; }
        public string Y2Headings { get; set; }

        public Client Client { get; set; }
        public ICollection<SizeMatrixSize> SizeMatrixSize { get; set; }
        public ICollection<SizePriceGroup> SizePriceGroup { get; set; }
    }
}
