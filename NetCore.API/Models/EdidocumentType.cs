using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EdidocumentType
    {
        public EdidocumentType()
        {
            Edidocument = new HashSet<Edidocument>();
        }

        public int EdidocumenttypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }

        public Client Client { get; set; }
        public ICollection<Edidocument> Edidocument { get; set; }
    }
}
