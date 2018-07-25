using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Priya
    {
        public int PriyaId { get; set; }
        public string Name { get; set; }
        public string ExportType { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
        public string TableName { get; set; }
        public int? EntityId { get; set; }
        public byte[] Startversion { get; set; }
        public byte[] Endversion { get; set; }
    }
}
