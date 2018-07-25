using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class SolidPack
    {
        public int SolidpackId { get; set; }
        public int ClientId { get; set; }
        public int BaseId { get; set; }
        public byte PackageLevel { get; set; }
        public short Pack { get; set; }

        public Base Base { get; set; }
    }
}
