using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Location
    {
        public Location()
        {
            Asn = new HashSet<Asn>();
            InverseParentLocation = new HashSet<Location>();
            LocationInventory = new HashSet<LocationInventory>();
            Session = new HashSet<Session>();
        }

        public int LocationId { get; set; }
        public int EntityId { get; set; }
        public string LocationCode { get; set; }
        public string Barcode { get; set; }
        public int? ParentLocationId { get; set; }
        public int LocationtypeId { get; set; }
        public string Configuration { get; set; }
        public string CDisplay { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public Entity Entity { get; set; }
        public LocationType Locationtype { get; set; }
        public Location ParentLocation { get; set; }
        public ICollection<Asn> Asn { get; set; }
        public ICollection<Location> InverseParentLocation { get; set; }
        public ICollection<LocationInventory> LocationInventory { get; set; }
        public ICollection<Session> Session { get; set; }
    }
}
