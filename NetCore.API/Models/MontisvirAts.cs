using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class MontisvirAts
    {
        public int MontisviratsId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int? Inprod { get; set; }
        public int? Xfact { get; set; }
        public int? Intrans { get; set; }
        public int? Alloc { get; set; }
        public int? Instk { get; set; }
        public int? Open { get; set; }
        public int? Ats { get; set; }
    }
}
