using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AllocationBatch
    {
        public int AllocationbatchId { get; set; }
        public int ClientId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ProcessedTime { get; set; }
        public bool Intransit { get; set; }
        public int? EntityId { get; set; }
        public string Criteria { get; set; }
    }
}
