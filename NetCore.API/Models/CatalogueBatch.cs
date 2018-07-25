using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CatalogueBatch
    {
        public int BatchId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
    }
}
