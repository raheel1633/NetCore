using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CreditLog
    {
        public int CreditlogId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? ActionDate { get; set; }
        public Guid? UserId { get; set; }
        public int? DecisionId { get; set; }

        public Order Order { get; set; }
    }
}
