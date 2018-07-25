using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Lfsobject
    {
        public int LfsobjectId { get; set; }
        public int ObjecttypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Dto { get; set; }
        public int? ClientId { get; set; }

        public Client Client { get; set; }
        public ObjectType Objecttype { get; set; }
    }
}
