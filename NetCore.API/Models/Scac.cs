using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Scac
    {
        public int ScacId { get; set; }
        public string Scac1 { get; set; }
        public string Mcn { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string SymS { get; set; }
        public string SymM { get; set; }
        public string SymN { get; set; }
        public string SymX { get; set; }
        public string USDot { get; set; }
        public string EquipmentMarkType { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
