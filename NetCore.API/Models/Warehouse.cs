using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Warehouse
    {
        public int WarehouseId { get; set; }
        public int EntityId { get; set; }
        public string WarehouseCode { get; set; }
        public string HostWarehouseCode { get; set; }
        public string Configuration { get; set; }
    }
}
