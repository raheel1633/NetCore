using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ClientUser
    {
        public int ClientuserId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }

        public Client Client { get; set; }
        public User User { get; set; }
    }
}
