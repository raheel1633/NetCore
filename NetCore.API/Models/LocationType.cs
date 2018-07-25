using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            Location = new HashSet<Location>();
        }

        public int LocationtypeId { get; set; }
        public int? ClientId { get; set; }
        public string LocationtypeCode { get; set; }
        public string Configuration { get; set; }

        public Client Client { get; set; }
        public ICollection<Location> Location { get; set; }
    }
}
