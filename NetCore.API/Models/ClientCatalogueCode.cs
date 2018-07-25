using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientCatalogueCode
    {
        public int ClientcataloguecodeId { get; set; }
        public int ClientcatalogueId { get; set; }
        public string SelectionCode { get; set; }
        public string Description { get; set; }
    }
}
