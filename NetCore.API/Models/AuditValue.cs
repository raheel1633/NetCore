using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class AuditValue
    {
        public int AuditvalueId { get; set; }
        public int AuditId { get; set; }
        public string MemberName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public Audit Audit { get; set; }
    }
}
