using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Audit
    {
        public Audit()
        {
            AuditValue = new HashSet<AuditValue>();
        }

        public int AuditId { get; set; }
        public string Title { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public int? TableKey { get; set; }
        public string UserName { get; set; }
        public DateTime AuditDate { get; set; }
        public byte[] LastModified { get; set; }

        public ICollection<AuditValue> AuditValue { get; set; }
    }
}
