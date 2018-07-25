using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientWarehouse
    {
        public int ClientwarehouseId { get; set; }
        public int ClientId { get; set; }
        public string WarehouseCode { get; set; }
        public int? WarehouseId { get; set; }
        public int? InventorystatusId { get; set; }
        public string _3plWarehouseCode { get; set; }
        public string _3plInventorystatus { get; set; }
        public int? CliententityId { get; set; }
        public int? DirectediId { get; set; }
        public int? EdidocumentId { get; set; }

        public DirectEdi Directedi { get; set; }
        public Edidocument Edidocument { get; set; }
        public InventoryStatus Inventorystatus { get; set; }
    }
}
