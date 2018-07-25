using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Route
    {
        public Route()
        {
            Container = new HashSet<Container>();
        }

        public int RouteId { get; set; }
        public int ClientId { get; set; }
        public int RoutetypeId { get; set; }
        public string VesselNumber { get; set; }
        public string TruckNumber { get; set; }

        public Client Client { get; set; }
        public ICollection<Container> Container { get; set; }
    }
}
