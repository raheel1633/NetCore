using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientCatalogueWebService
    {
        public int CatalogueWebServiceLoginId { get; set; }
        public int CatalogueId { get; set; }
        public int ClientId { get; set; }
        public string AccountCode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string NetworkId { get; set; }
        public string CatalogueName { get; set; }
        public byte[] Rowversion { get; set; }
        public bool Demo { get; set; }
    }
}
