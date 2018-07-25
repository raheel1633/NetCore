using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Entity
    {
        public Entity()
        {
            Carrier = new HashSet<Carrier>();
            CarrierEntity = new HashSet<CarrierEntity>();
            Client = new HashSet<Client>();
            ClientEntity = new HashSet<ClientEntity>();
            DirectEdi = new HashSet<DirectEdi>();
            Division = new HashSet<Division>();
            Ediprovider = new HashSet<Ediprovider>();
            EditradingPartner = new HashSet<EditradingPartner>();
            EditradingPartnerAlias = new HashSet<EditradingPartnerAlias>();
            EntityEdiprovider = new HashSet<EntityEdiprovider>();
            Factor = new HashSet<Factor>();
            Inventory = new HashSet<Inventory>();
            InverseBilltoEntity = new HashSet<Entity>();
            InverseDcEntity = new HashSet<Entity>();
            InverseParentEntity = new HashSet<Entity>();
            Licensor = new HashSet<Licensor>();
            Location = new HashSet<Location>();
            Major = new HashSet<Major>();
            MontisvirEntity = new HashSet<MontisvirEntity>();
            ProductAlias = new HashSet<ProductAlias>();
            Van = new HashSet<Van>();
        }

        public int EntityId { get; set; }
        public string EntityCode { get; set; }
        public string Name { get; set; }
        public string Store { get; set; }
        public bool IsBillto { get; set; }
        public bool IsShipto { get; set; }
        public bool IsVendor { get; set; }
        public bool IsFactory { get; set; }
        public bool IsRemitto { get; set; }
        public bool IsDc { get; set; }
        public bool IsWarehouse { get; set; }
        public int? ParentEntityId { get; set; }
        public int? RegionId { get; set; }
        public string Attention { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public int? DcEntityId { get; set; }
        public int? BilltoEntityId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int? ReferenceCount { get; set; }
        public bool? Active { get; set; }
        public byte[] Rowversion { get; set; }
        public string ContactName { get; set; }
        public int? CurrencyId { get; set; }
        public int? MaxDiscount { get; set; }
        public int CountryId { get; set; }
        public int? StateprovenceId { get; set; }
        public string Unloccode { get; set; }
        public bool? IsDropship { get; set; }
        public string San { get; set; }
        public bool IsConsolidator { get; set; }
        public string Contact { get; set; }
        public string Duns4 { get; set; }
        public bool IsAgent { get; set; }

        public Entity BilltoEntity { get; set; }
        public Country CountryNavigation { get; set; }
        public Currency Currency { get; set; }
        public Entity DcEntity { get; set; }
        public Entity ParentEntity { get; set; }
        public Region Region { get; set; }
        public StateProvence Stateprovence { get; set; }
        public ICollection<Carrier> Carrier { get; set; }
        public ICollection<CarrierEntity> CarrierEntity { get; set; }
        public ICollection<Client> Client { get; set; }
        public ICollection<ClientEntity> ClientEntity { get; set; }
        public ICollection<DirectEdi> DirectEdi { get; set; }
        public ICollection<Division> Division { get; set; }
        public ICollection<Ediprovider> Ediprovider { get; set; }
        public ICollection<EditradingPartner> EditradingPartner { get; set; }
        public ICollection<EditradingPartnerAlias> EditradingPartnerAlias { get; set; }
        public ICollection<EntityEdiprovider> EntityEdiprovider { get; set; }
        public ICollection<Factor> Factor { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<Entity> InverseBilltoEntity { get; set; }
        public ICollection<Entity> InverseDcEntity { get; set; }
        public ICollection<Entity> InverseParentEntity { get; set; }
        public ICollection<Licensor> Licensor { get; set; }
        public ICollection<Location> Location { get; set; }
        public ICollection<Major> Major { get; set; }
        public ICollection<MontisvirEntity> MontisvirEntity { get; set; }
        public ICollection<ProductAlias> ProductAlias { get; set; }
        public ICollection<Van> Van { get; set; }
    }
}
