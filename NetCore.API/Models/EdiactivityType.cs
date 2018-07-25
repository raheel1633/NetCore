using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EdiactivityType
    {
        public EdiactivityType()
        {
            EdidocumentLog = new HashSet<EdidocumentLog>();
        }

        public byte ActivityType { get; set; }
        public string ActivityName { get; set; }

        public ICollection<EdidocumentLog> EdidocumentLog { get; set; }
    }
}
