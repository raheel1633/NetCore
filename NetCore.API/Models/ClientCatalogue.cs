using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientCatalogue
    {
        public int ClientcatalogueId { get; set; }
        public int ClientId { get; set; }
        public int CatalogueId { get; set; }
        public string AccountCode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool AutoSend { get; set; }
        public string ClientcatalogueName { get; set; }
        public bool? Enabled { get; set; }
    }
}
