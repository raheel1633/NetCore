using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Client
    {
        public Client()
        {
            AllocationBatchDetail = new HashSet<AllocationBatchDetail>();
            AllocationBatchLog = new HashSet<AllocationBatchLog>();
            Assignment = new HashSet<Assignment>();
            Assortment = new HashSet<Assortment>();
            Base = new HashSet<Base>();
            BillOfLading = new HashSet<BillOfLading>();
            Box = new HashSet<Box>();
            Brand = new HashSet<Brand>();
            Buyer = new HashSet<Buyer>();
            CasePack = new HashSet<CasePack>();
            Cdn = new HashSet<Cdn>();
            Cdnobject = new HashSet<Cdnobject>();
            ClientEntity = new HashSet<ClientEntity>();
            ClientInvoiceLine = new HashSet<ClientInvoiceLine>();
            ClientUser = new HashSet<ClientUser>();
            Commission = new HashSet<Commission>();
            CommissionRule = new HashSet<CommissionRule>();
            Container = new HashSet<Container>();
            CreditRequest = new HashSet<CreditRequest>();
            Detail = new HashSet<Detail>();
            DirectEdiitem = new HashSet<DirectEdiitem>();
            Division = new HashSet<Division>();
            Edidocument = new HashSet<Edidocument>();
            EdidocumentType = new HashSet<EdidocumentType>();
            Feeditem = new HashSet<Feeditem>();
            Inventory = new HashSet<Inventory>();
            InventoryRegion = new HashSet<InventoryRegion>();
            InverseParentClient = new HashSet<Client>();
            InvoiceLine = new HashSet<InvoiceLine>();
            Lfsobject = new HashSet<Lfsobject>();
            Licensor = new HashSet<Licensor>();
            Linesheet = new HashSet<Linesheet>();
            Location = new HashSet<Location>();
            LocationAllocation = new HashSet<LocationAllocation>();
            LocationInventory = new HashSet<LocationInventory>();
            LocationType = new HashSet<LocationType>();
            Lot = new HashSet<Lot>();
            Material = new HashSet<Material>();
            MontisvirLocation = new HashSet<MontisvirLocation>();
            Note = new HashSet<Note>();
            Order = new HashSet<Order>();
            OrderLine = new HashSet<OrderLine>();
            OrderLineHistory = new HashSet<OrderLineHistory>();
            PlanPricing = new HashSet<PlanPricing>();
            Po = new HashSet<Po>();
            Product = new HashSet<Product>();
            Producttype = new HashSet<Producttype>();
            QbCurrency = new HashSet<QbCurrency>();
            QbItemNavigation = new HashSet<QbItem>();
            Role = new HashSet<Role>();
            Route = new HashSet<Route>();
            Salesperson = new HashSet<Salesperson>();
            Season = new HashSet<Season>();
            Shipment = new HashSet<Shipment>();
            ShipmentLine = new HashSet<ShipmentLine>();
            Show = new HashSet<Show>();
            SizeMatrix = new HashSet<SizeMatrix>();
            SizeMatrixSize = new HashSet<SizeMatrixSize>();
            SizePriceGroup = new HashSet<SizePriceGroup>();
            Style = new HashSet<Style>();
            StyleColorInventoryRegion = new HashSet<StyleColorInventoryRegion>();
            StyleCost = new HashSet<StyleCost>();
            StyleCostGroup = new HashSet<StyleCostGroup>();
            StyleInventoryRegion = new HashSet<StyleInventoryRegion>();
            Template = new HashSet<Template>();
            UserRole = new HashSet<UserRole>();
        }

        public int ClientId { get; set; }
        public string ClientCode { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }
        public int? Dbid { get; set; }
        public string Datasource { get; set; }
        public string Catalog { get; set; }
        public string OwnerCode { get; set; }
        public string QbItem { get; set; }
        public decimal? QbPercentage { get; set; }
        public int? QbTermdays { get; set; }
        public string QbClass { get; set; }
        public byte? Billingbase { get; set; }
        public bool HasDivisions { get; set; }
        public string EdiId { get; set; }
        public string EdiQualifier { get; set; }
        public byte[] Rowversion { get; set; }
        public bool? Active { get; set; }
        public bool? UseStyleCode { get; set; }
        public bool? UseStyleName { get; set; }
        public bool? UseColorCode { get; set; }
        public bool? UseColorDesc { get; set; }
        public bool? UseNrfColor { get; set; }
        public bool? UseSizeCode { get; set; }
        public bool? UseDisplaySize { get; set; }
        public bool? UseNrfSize { get; set; }
        public int? UpcblockId { get; set; }
        public int InvoiceSequence { get; set; }
        public string InvoicePrefix { get; set; }
        public int InvoiceZeropadding { get; set; }
        public int? BillSequence { get; set; }
        public string BillPrefix { get; set; }
        public int? BillZeropadding { get; set; }
        public int? OrderSequence { get; set; }
        public string OrderPrefix { get; set; }
        public int? OrderZeropadding { get; set; }
        public int? BolSeed { get; set; }
        public int? PlanId { get; set; }
        public DateTime? SubscriptionDate { get; set; }
        public Guid Id { get; set; }
        public string LogoContentType { get; set; }
        public string LogoFileName { get; set; }
        public byte[] LogoFileContent { get; set; }
        public DateTime? MontisvirDate { get; set; }
        public byte[] ClientLogo { get; set; }
        public decimal? QbMinimumPerOrder { get; set; }
        public decimal? QbMinimumPerMonth { get; set; }
        public int? ParentClientId { get; set; }
        public int? CurrencyId { get; set; }
        public string Configuration { get; set; }

        public Currency Currency { get; set; }
        public Entity Entity { get; set; }
        public Client ParentClient { get; set; }
        public ICollection<AllocationBatchDetail> AllocationBatchDetail { get; set; }
        public ICollection<AllocationBatchLog> AllocationBatchLog { get; set; }
        public ICollection<Assignment> Assignment { get; set; }
        public ICollection<Assortment> Assortment { get; set; }
        public ICollection<Base> Base { get; set; }
        public ICollection<BillOfLading> BillOfLading { get; set; }
        public ICollection<Box> Box { get; set; }
        public ICollection<Brand> Brand { get; set; }
        public ICollection<Buyer> Buyer { get; set; }
        public ICollection<CasePack> CasePack { get; set; }
        public ICollection<Cdn> Cdn { get; set; }
        public ICollection<Cdnobject> Cdnobject { get; set; }
        public ICollection<ClientEntity> ClientEntity { get; set; }
        public ICollection<ClientInvoiceLine> ClientInvoiceLine { get; set; }
        public ICollection<ClientUser> ClientUser { get; set; }
        public ICollection<Commission> Commission { get; set; }
        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Container> Container { get; set; }
        public ICollection<CreditRequest> CreditRequest { get; set; }
        public ICollection<Detail> Detail { get; set; }
        public ICollection<DirectEdiitem> DirectEdiitem { get; set; }
        public ICollection<Division> Division { get; set; }
        public ICollection<Edidocument> Edidocument { get; set; }
        public ICollection<EdidocumentType> EdidocumentType { get; set; }
        public ICollection<Feeditem> Feeditem { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        public ICollection<InventoryRegion> InventoryRegion { get; set; }
        public ICollection<Client> InverseParentClient { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
        public ICollection<Lfsobject> Lfsobject { get; set; }
        public ICollection<Licensor> Licensor { get; set; }
        public ICollection<Linesheet> Linesheet { get; set; }
        public ICollection<Location> Location { get; set; }
        public ICollection<LocationAllocation> LocationAllocation { get; set; }
        public ICollection<LocationInventory> LocationInventory { get; set; }
        public ICollection<LocationType> LocationType { get; set; }
        public ICollection<Lot> Lot { get; set; }
        public ICollection<Material> Material { get; set; }
        public ICollection<MontisvirLocation> MontisvirLocation { get; set; }
        public ICollection<Note> Note { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<OrderLineHistory> OrderLineHistory { get; set; }
        public ICollection<PlanPricing> PlanPricing { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Producttype> Producttype { get; set; }
        public ICollection<QbCurrency> QbCurrency { get; set; }
        public ICollection<QbItem> QbItemNavigation { get; set; }
        public ICollection<Role> Role { get; set; }
        public ICollection<Route> Route { get; set; }
        public ICollection<Salesperson> Salesperson { get; set; }
        public ICollection<Season> Season { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
        public ICollection<ShipmentLine> ShipmentLine { get; set; }
        public ICollection<Show> Show { get; set; }
        public ICollection<SizeMatrix> SizeMatrix { get; set; }
        public ICollection<SizeMatrixSize> SizeMatrixSize { get; set; }
        public ICollection<SizePriceGroup> SizePriceGroup { get; set; }
        public ICollection<Style> Style { get; set; }
        public ICollection<StyleColorInventoryRegion> StyleColorInventoryRegion { get; set; }
        public ICollection<StyleCost> StyleCost { get; set; }
        public ICollection<StyleCostGroup> StyleCostGroup { get; set; }
        public ICollection<StyleInventoryRegion> StyleInventoryRegion { get; set; }
        public ICollection<Template> Template { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
