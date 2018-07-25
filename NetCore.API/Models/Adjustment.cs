using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Adjustment
    {
        public int AdjustmentId { get; set; }
        public int ClientId { get; set; }
        public int? ShipmentlineId { get; set; }
        public int ReasonId { get; set; }
        public DateTime TransactionTime { get; set; }
        public int? ParentLotId { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
        public Guid? TransactionId { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid? UserId { get; set; }
        public int? AdjustmentType { get; set; }
        public string Comment { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? ActivityTime { get; set; }
        public DateTime CActivityTime { get; set; }

        public Inventory Inventory { get; set; }
        public Lot ParentLot { get; set; }
        public AdjustmentReason Reason { get; set; }
    }
}
