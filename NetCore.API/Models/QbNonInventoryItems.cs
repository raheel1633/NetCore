using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbNonInventoryItems
    {
        public int QbNonInventoryItemsId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string ListId { get; set; }
        public string FullName { get; set; }
        public string Item { get; set; }
        public bool? Active { get; set; }
    }
}
