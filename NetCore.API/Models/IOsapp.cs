using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class IOsapp
    {
        public int IosappId { get; set; }
        public Guid UserId { get; set; }
        public int ObjectType { get; set; }
        public string Xml { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? SyncDate { get; set; }
        public int ClientId { get; set; }
    }
}
