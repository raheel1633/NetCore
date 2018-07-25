using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EdidocumentLog
    {
        public EdidocumentLog()
        {
            Edidocument = new HashSet<Edidocument>();
        }

        public int EdidocumentlogId { get; set; }
        public int EdidocumentId { get; set; }
        public byte ActivityType { get; set; }
        public string ActivityData { get; set; }
        public DateTime ActivityStart { get; set; }
        public DateTime ActivityEnd { get; set; }
        public byte ActivityStatus { get; set; }
        public string DocumentQueue { get; set; }
        public int? OutputDocumentId { get; set; }
        public Guid? UserId { get; set; }

        public EdiactivityStatus ActivityStatusNavigation { get; set; }
        public EdiactivityType ActivityTypeNavigation { get; set; }
        public Edidocument EdidocumentNavigation { get; set; }
        public Edidocument OutputDocument { get; set; }
        public ICollection<Edidocument> Edidocument { get; set; }
    }
}
