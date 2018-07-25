using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbItems
    {
        public int AliasId { get; set; }
        public int AliasType { get; set; }
        public int QbRequestId { get; set; }
        public int QbcId { get; set; }
        public int QbItemsId { get; set; }
        public int QbItemsTypeId { get; set; }
        public string ListId { get; set; }
        public string Name { get; set; }
        public int? QbwcId { get; set; }
        public int? LatestQbwcId { get; set; }
        public string Xml { get; set; }
    }
}
