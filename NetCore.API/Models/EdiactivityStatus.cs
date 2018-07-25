using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EdiactivityStatus
    {
        public EdiactivityStatus()
        {
            EdidocumentLog = new HashSet<EdidocumentLog>();
        }

        public byte ActivityStatus { get; set; }
        public string StatusName { get; set; }

        public ICollection<EdidocumentLog> EdidocumentLog { get; set; }
    }
}
