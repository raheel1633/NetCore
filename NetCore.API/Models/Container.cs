using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Container
    {
        public Container()
        {
            Shipment = new HashSet<Shipment>();
        }

        public int ContainerId { get; set; }
        public int ClientId { get; set; }
        public int RouteId { get; set; }
        public string ContainerNo { get; set; }
        public string SealNo { get; set; }
        public decimal? Size { get; set; }

        public Client Client { get; set; }
        public Route Route { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
