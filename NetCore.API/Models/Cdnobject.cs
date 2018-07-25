using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Cdnobject
    {
        public int CdnobjectId { get; set; }
        public int CdnId { get; set; }
        public int ClientId { get; set; }
        public string Etag { get; set; }
        public int Objecttype { get; set; }
        public int Key { get; set; }
        public string Configuration { get; set; }
        public int? UserId { get; set; }
        public string Comments { get; set; }
        public byte[] Rowversion { get; set; }

        public Cdn Cdn { get; set; }
        public Client Client { get; set; }
        public User User { get; set; }
    }
}
