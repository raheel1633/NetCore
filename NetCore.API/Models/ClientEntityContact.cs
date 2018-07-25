using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientEntityContact
    {
        public int CliententitycontactId { get; set; }
        public int CliententityId { get; set; }
        public string Contact { get; set; }

        public ClientEntity Cliententity { get; set; }
    }
}
