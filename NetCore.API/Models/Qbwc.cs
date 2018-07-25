using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Qbwc
    {
        public int QbwcId { get; set; }
        public int AliasId { get; set; }
        public int AliasType { get; set; }
        public bool Acknowledged { get; set; }
        public bool IsNew { get; set; }
        public int Status { get; set; }
        public int? Action { get; set; }
        public string QbaliasId { get; set; }
        public int? ClientId { get; set; }
        public int? TrandingpartnerId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int QbRequestTypeId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string Ticket { get; set; }
        public int? EdidocumentId { get; set; }

        public Edidocument Edidocument { get; set; }
    }
}
