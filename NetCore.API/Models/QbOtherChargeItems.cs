using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbOtherChargeItems
    {
        public int QbOtherChargeItemsId { get; set; }
        public int? QbcId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ListId { get; set; }
    }
}
