using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class DirectEdi
    {
        public DirectEdi()
        {
            ClientWarehouse = new HashSet<ClientWarehouse>();
            Invoice = new HashSet<Invoice>();
            Shipment = new HashSet<Shipment>();
        }

        public int DirectediId { get; set; }
        public short SchemaType { get; set; }
        public string BodName { get; set; }
        public string Bod { get; set; }
        public string Creatorworkflow { get; set; }
        public string Xml { get; set; }
        public bool? IsProcessed { get; set; }
        public int? OrderId { get; set; }
        public string Creationdatetime { get; set; }
        public string Usageindicator { get; set; }
        public int? ClientId { get; set; }
        public bool? Direction { get; set; }
        public long? ReferenceId { get; set; }
        public short? ReferenceType { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string Tradingpartner { get; set; }
        public string Owner { get; set; }
        public string Poxml { get; set; }
        public int? EntityId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Reference { get; set; }

        public Entity Entity { get; set; }
        public Order Order { get; set; }
        public ICollection<ClientWarehouse> ClientWarehouse { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
