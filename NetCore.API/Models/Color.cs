using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Color
    {
        public int ColorId { get; set; }
        public int ClientId { get; set; }
        public string ColorCode { get; set; }
        public string Description { get; set; }
        public string NrfCode { get; set; }
        public string QrsDesc { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
