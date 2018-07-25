using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CasePack
    {
        public int CasepackId { get; set; }
        public int ClientId { get; set; }
        public int CaseSizeId { get; set; }
        public int PackSizeId { get; set; }
        public short Quantity { get; set; }
        public byte[] Rowversion { get; set; }

        public Size CaseSize { get; set; }
        public Client Client { get; set; }
        public Size PackSize { get; set; }
    }
}
