using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class EdidocumentState
    {
        public EdidocumentState()
        {
            Edidocument = new HashSet<Edidocument>();
        }

        public byte DocumentState { get; set; }
        public string StateName { get; set; }
        public string Comment { get; set; }

        public ICollection<Edidocument> Edidocument { get; set; }
    }
}
