using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LFSCore.Models
{
    public partial class QLCContext : DbContext
    {
        public QLCContext()
        {
        }

        public QLCContext(DbContextOptions<QLCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<Adjustment> Adjustment { get; set; }
        public virtual DbSet<AdjustmentReason> AdjustmentReason { get; set; }
        public virtual DbSet<Aisle> Aisle { get; set; }
        public virtual DbSet<AllocationBatch> AllocationBatch { get; set; }
        public virtual DbSet<AllocationBatchDetail> AllocationBatchDetail { get; set; }
        public virtual DbSet<AllocationBatchLog> AllocationBatchLog { get; set; }
        public virtual DbSet<Allowance> Allowance { get; set; }
        public virtual DbSet<Asn> Asn { get; set; }
        public virtual DbSet<Asndetail> Asndetail { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<AssignmentInvoice> AssignmentInvoice { get; set; }
        public virtual DbSet<Assortment> Assortment { get; set; }
        public virtual DbSet<Atschange> Atschange { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AuditValue> AuditValue { get; set; }
        public virtual DbSet<Base> Base { get; set; }
        public virtual DbSet<BillOfLading> BillOfLading { get; set; }
        public virtual DbSet<Bin> Bin { get; set; }
        public virtual DbSet<Box> Box { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Carrier> Carrier { get; set; }
        public virtual DbSet<CarrierEntity> CarrierEntity { get; set; }
        public virtual DbSet<CarrierServiceLevel> CarrierServiceLevel { get; set; }
        public virtual DbSet<CasePack> CasePack { get; set; }
        public virtual DbSet<Catalogue> Catalogue { get; set; }
        public virtual DbSet<CatalogueBatch> CatalogueBatch { get; set; }
        public virtual DbSet<Cdn> Cdn { get; set; }
        public virtual DbSet<Cdnobject> Cdnobject { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientCatalogue> ClientCatalogue { get; set; }
        public virtual DbSet<ClientCatalogueCode> ClientCatalogueCode { get; set; }
        public virtual DbSet<ClientCatalogueWebService> ClientCatalogueWebService { get; set; }
        public virtual DbSet<ClientEntity> ClientEntity { get; set; }
        public virtual DbSet<ClientEntityContact> ClientEntityContact { get; set; }
        public virtual DbSet<ClientExport> ClientExport { get; set; }
        public virtual DbSet<ClientInvoice> ClientInvoice { get; set; }
        public virtual DbSet<ClientInvoiceLine> ClientInvoiceLine { get; set; }
        public virtual DbSet<ClientUser> ClientUser { get; set; }
        public virtual DbSet<ClientWarehouse> ClientWarehouse { get; set; }
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Commission> Commission { get; set; }
        public virtual DbSet<CommissionRule> CommissionRule { get; set; }
        public virtual DbSet<Connection> Connection { get; set; }
        public virtual DbSet<ConnectionType> ConnectionType { get; set; }
        public virtual DbSet<Container> Container { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CreditAllocation> CreditAllocation { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<CreditLog> CreditLog { get; set; }
        public virtual DbSet<CreditRequest> CreditRequest { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<Dimension> Dimension { get; set; }
        public virtual DbSet<DimensionType> DimensionType { get; set; }
        public virtual DbSet<DirectEdi> DirectEdi { get; set; }
        public virtual DbSet<DirectEdiitem> DirectEdiitem { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<EdiactivityStatus> EdiactivityStatus { get; set; }
        public virtual DbSet<EdiactivityType> EdiactivityType { get; set; }
        public virtual DbSet<Edidocument> Edidocument { get; set; }
        public virtual DbSet<EdidocumentLog> EdidocumentLog { get; set; }
        public virtual DbSet<EdidocumentState> EdidocumentState { get; set; }
        public virtual DbSet<EdidocumentType> EdidocumentType { get; set; }
        public virtual DbSet<Ediprovider> Ediprovider { get; set; }
        public virtual DbSet<EditradingPartner> EditradingPartner { get; set; }
        public virtual DbSet<EditradingPartnerAlias> EditradingPartnerAlias { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityEdiprovider> EntityEdiprovider { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<Factor> Factor { get; set; }
        public virtual DbSet<Feed> Feed { get; set; }
        public virtual DbSet<Feeditem> Feeditem { get; set; }
        public virtual DbSet<Grillbotline> Grillbotline { get; set; }
        public virtual DbSet<Grillbotorder> Grillbotorder { get; set; }
        public virtual DbSet<Interface> Interface { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryRegion> InventoryRegion { get; set; }
        public virtual DbSet<InventoryStatus> InventoryStatus { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<InvoiceLineType> InvoiceLineType { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayment { get; set; }
        public virtual DbSet<InvoiceSendHistory> InvoiceSendHistory { get; set; }
        public virtual DbSet<IOsapp> IOsapp { get; set; }
        public virtual DbSet<LabelFormat> LabelFormat { get; set; }
        public virtual DbSet<Lfsobject> Lfsobject { get; set; }
        public virtual DbSet<Licensor> Licensor { get; set; }
        public virtual DbSet<Linesheet> Linesheet { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationAdjustment> LocationAdjustment { get; set; }
        public virtual DbSet<LocationAllocation> LocationAllocation { get; set; }
        public virtual DbSet<LocationInventory> LocationInventory { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<LongRunQueries> LongRunQueries { get; set; }
        public virtual DbSet<LongRunQueries2> LongRunQueries2 { get; set; }
        public virtual DbSet<Lot> Lot { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MontisvirAts> MontisvirAts { get; set; }
        public virtual DbSet<MontisvirBrand> MontisvirBrand { get; set; }
        public virtual DbSet<MontisvirCancelCode> MontisvirCancelCode { get; set; }
        public virtual DbSet<MontisvirDivision> MontisvirDivision { get; set; }
        public virtual DbSet<MontisvirEntity> MontisvirEntity { get; set; }
        public virtual DbSet<MontisvirLineStatus> MontisvirLineStatus { get; set; }
        public virtual DbSet<MontisvirLocation> MontisvirLocation { get; set; }
        public virtual DbSet<MontisvirOrderLine> MontisvirOrderLine { get; set; }
        public virtual DbSet<MontisvirOrderStatus> MontisvirOrderStatus { get; set; }
        public virtual DbSet<Nmfc> Nmfc { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<ObjectType> ObjectType { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<OrderLineHistory> OrderLineHistory { get; set; }
        public virtual DbSet<OrderReason> OrderReason { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<PcProducts> PcProducts { get; set; }
        public virtual DbSet<PcStylecolors> PcStylecolors { get; set; }
        public virtual DbSet<PcStyles> PcStyles { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<PlanOption> PlanOption { get; set; }
        public virtual DbSet<PlanPricing> PlanPricing { get; set; }
        public virtual DbSet<Po> Po { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Priya> Priya { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAlias> ProductAlias { get; set; }
        public virtual DbSet<ProductCart> ProductCart { get; set; }
        public virtual DbSet<ProductCatalogue> ProductCatalogue { get; set; }
        public virtual DbSet<Producttype> Producttype { get; set; }
        public virtual DbSet<Qbaccount> Qbaccount { get; set; }
        public virtual DbSet<QbAccounts> QbAccounts { get; set; }
        public virtual DbSet<Qbc> Qbc { get; set; }
        public virtual DbSet<QbClasses> QbClasses { get; set; }
        public virtual DbSet<QbCredits> QbCredits { get; set; }
        public virtual DbSet<QbCurrency> QbCurrency { get; set; }
        public virtual DbSet<QbCustomers> QbCustomers { get; set; }
        public virtual DbSet<QbDiscountItems> QbDiscountItems { get; set; }
        public virtual DbSet<QbInvoices> QbInvoices { get; set; }
        public virtual DbSet<QbItem> QbItem { get; set; }
        public virtual DbSet<QbItems> QbItems { get; set; }
        public virtual DbSet<QbItemsType> QbItemsType { get; set; }
        public virtual DbSet<QbNonInventoryItems> QbNonInventoryItems { get; set; }
        public virtual DbSet<QbOtherChargeItems> QbOtherChargeItems { get; set; }
        public virtual DbSet<QbRequest> QbRequest { get; set; }
        public virtual DbSet<QbRequestType> QbRequestType { get; set; }
        public virtual DbSet<QbSalesrep> QbSalesrep { get; set; }
        public virtual DbSet<QbTerms> QbTerms { get; set; }
        public virtual DbSet<QbVersion> QbVersion { get; set; }
        public virtual DbSet<Qbwc> Qbwc { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<SalesBranch> SalesBranch { get; set; }
        public virtual DbSet<Salesperson> Salesperson { get; set; }
        public virtual DbSet<Scac> Scac { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Sequence> Sequence { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<ShipAdvise> ShipAdvise { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentLine> ShipmentLine { get; set; }
        public virtual DbSet<ShipmentMop> ShipmentMop { get; set; }
        public virtual DbSet<ShipOrder> ShipOrder { get; set; }
        public virtual DbSet<ShipVia> ShipVia { get; set; }
        public virtual DbSet<Shopify> Shopify { get; set; }
        public virtual DbSet<Show> Show { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<SizeMatrix> SizeMatrix { get; set; }
        public virtual DbSet<SizeMatrixSize> SizeMatrixSize { get; set; }
        public virtual DbSet<SizePrice> SizePrice { get; set; }
        public virtual DbSet<SizePriceGroup> SizePriceGroup { get; set; }
        public virtual DbSet<SolidPack> SolidPack { get; set; }
        public virtual DbSet<StateProvence> StateProvence { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<StyleColor> StyleColor { get; set; }
        public virtual DbSet<StyleColorCost> StyleColorCost { get; set; }
        public virtual DbSet<StyleColorInventoryRegion> StyleColorInventoryRegion { get; set; }
        public virtual DbSet<StyleColorPrice> StyleColorPrice { get; set; }
        public virtual DbSet<StyleColorSeason> StyleColorSeason { get; set; }
        public virtual DbSet<StyleCost> StyleCost { get; set; }
        public virtual DbSet<StyleCostGroup> StyleCostGroup { get; set; }
        public virtual DbSet<StyleDimension> StyleDimension { get; set; }
        public virtual DbSet<StyleImage> StyleImage { get; set; }
        public virtual DbSet<StyleImageType> StyleImageType { get; set; }
        public virtual DbSet<StyleInventoryRegion> StyleInventoryRegion { get; set; }
        public virtual DbSet<StylePrice> StylePrice { get; set; }
        public virtual DbSet<TagCom> TagCom { get; set; }
        public virtual DbSet<TagLines> TagLines { get; set; }
        public virtual DbSet<TagLineSheet> TagLineSheet { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<TemplateType> TemplateType { get; set; }
        public virtual DbSet<Terms> Terms { get; set; }
        public virtual DbSet<TradingPartner> TradingPartner { get; set; }
        public virtual DbSet<TradingPartnerAlias> TradingPartnerAlias { get; set; }
        public virtual DbSet<TransportationMethod> TransportationMethod { get; set; }
        public virtual DbSet<Tuser> Tuser { get; set; }
        public virtual DbSet<Uom> Uom { get; set; }
        public virtual DbSet<Upcblock> Upcblock { get; set; }
        public virtual DbSet<Upcreuse> Upcreuse { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Van> Van { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WebApplication> WebApplication { get; set; }

        // Unable to generate entity type for table 'dbo.SeasonTemplate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ddscan'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CustomerEntity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.qb_aging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WebApplicationRole'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NRFSizeAll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TAB_shippinglocation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TAG_shippinglocation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.wscustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TAG_customer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NRFSize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NRFColor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.grillbot'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TAG_FactoryControl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ClientMontisvirTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MontisvirTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.motivational'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.danadavisupc'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
              //  optionsBuilder.UseSqlServer("Server=192.168.23.150;Database=QLC;user id=sa;password=sa;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.ActionCode)
                    .HasColumnName("action_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adjustment>(entity =>
            {
                entity.HasIndex(e => e.InventoryId)
                    .HasName("IX_Adjustment_inventory");

                entity.HasIndex(e => e.ShipmentlineId)
                    .HasName("IX_Adjustment");

                entity.HasIndex(e => e.TransactionDate)
                    .HasName("adjustment_date_IX");

                entity.HasIndex(e => new { e.ClientId, e.CActivityTime })
                    .HasName("adjustment_activity_date_IX");

                entity.HasIndex(e => new { e.ClientId, e.TransactionTime })
                    .HasName("IX_Adjustment_client");

                entity.Property(e => e.AdjustmentId).HasColumnName("adjustment_id");

                entity.Property(e => e.ActivityTime)
                    .HasColumnName("activity_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdjustmentType).HasColumnName("adjustment_type");

                entity.Property(e => e.CActivityTime)
                    .HasColumnName("c_activity_time")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(isnull([activity_time],[transaction_time]))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.ParentLotId).HasColumnName("parent_lot_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReasonId).HasColumnName("reason_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transaction_date")
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[transaction_time],0))");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.TransactionTime)
                    .HasColumnName("transaction_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_Adjustment_Inventory");

                entity.HasOne(d => d.ParentLot)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.ParentLotId)
                    .HasConstraintName("FK_Adjustment_ParentLot");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.Adjustment)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Adjustment_Reason_FK");
            });

            modelBuilder.Entity<AdjustmentReason>(entity =>
            {
                entity.Property(e => e.AdjustmentreasonId).HasColumnName("adjustmentreason_id");

                entity.Property(e => e.Decrease).HasColumnName("decrease");

                entity.Property(e => e.Increase).HasColumnName("increase");

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reason_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aisle>(entity =>
            {
                entity.Property(e => e.AisleId).HasColumnName("aisle_id");

                entity.Property(e => e.AisleCode)
                    .HasColumnName("aisle_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<AllocationBatch>(entity =>
            {
                entity.Property(e => e.AllocationbatchId).HasColumnName("allocationbatch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Criteria)
                    .HasColumnName("criteria")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Intransit).HasColumnName("intransit");

                entity.Property(e => e.ProcessedTime)
                    .HasColumnName("processed_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AllocationBatchDetail>(entity =>
            {
                entity.Property(e => e.AllocationbatchdetailId).HasColumnName("allocationbatchdetail_id");

                entity.Property(e => e.AllocationbatchId).HasColumnName("allocationbatch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.QuantityRequested).HasColumnName("quantity_requested");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AllocationBatchDetail)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_AllocationBatchDetail_Client");

                entity.HasOne(d => d.Orderline)
                    .WithMany(p => p.AllocationBatchDetail)
                    .HasForeignKey(d => d.OrderlineId)
                    .HasConstraintName("FK_AllocationBatchDetail_OrderLine");
            });

            modelBuilder.Entity<AllocationBatchLog>(entity =>
            {
                entity.HasIndex(e => e.InventoryId)
                    .HasName("AllocationBatchLog_Inventory_IX");

                entity.Property(e => e.AllocationbatchlogId).HasColumnName("allocationbatchlog_id");

                entity.Property(e => e.AllocationbatchdetailId).HasColumnName("allocationbatchdetail_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AllocationBatchLog)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_AllocationBatchLog_Client");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.AllocationBatchLog)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK_AllocationBatchLog_Inventory");
            });

            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.ToTable("allowance");

                entity.HasIndex(e => e.ClientId)
                    .HasName("allowance_client_id");

                entity.HasIndex(e => e.OrderId)
                    .HasName("allowance_U")
                    .IsUnique();

                entity.Property(e => e.AllowanceId).HasColumnName("allowance_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EdiType)
                    .HasColumnName("edi_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PercentBasisCode).HasColumnName("percent_basis_code");

                entity.Property(e => e.Percentage)
                    .HasColumnName("percentage")
                    .HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<Asn>(entity =>
            {
                entity.ToTable("ASN");

                entity.HasIndex(e => e.ReferencedOrderId)
                    .HasName("ASN_OrderReference_IX");

                entity.HasIndex(e => e.ShipmentId)
                    .HasName("ASN_Shipment_NC");

                entity.HasIndex(e => new { e.ClientId, e.Sscc18, e.ShipmentId })
                    .HasName("ASN_U")
                    .IsUnique();

                entity.Property(e => e.AsnId).HasColumnName("asn_id");

                entity.Property(e => e.AsnCartonNo)
                    .HasColumnName("asn_carton_no")
                    .HasComputedColumnSql("([dbo].[asn_carton_number]([shipment_id],[asn_id]))");

                entity.Property(e => e.Bin)
                    .HasColumnName("bin")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BoxId).HasColumnName("box_id");

                entity.Property(e => e.CartonNumber).HasColumnName("carton_number");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContainerAsnId).HasColumnName("container_asn_id");

                entity.Property(e => e.Cube)
                    .HasColumnName("cube")
                    .HasColumnType("numeric(5, 1)");

                entity.Property(e => e.CubeDimension)
                    .HasColumnName("cube_dimension")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(5, 1)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.MasterTrackingNumber)
                    .HasColumnName("master_tracking_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferencedOrderId).HasColumnName("referenced_order_id");

                entity.Property(e => e.ReturnLabel).HasColumnName("return_label");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("shipping_charge")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ShippingLabel).HasColumnName("shipping_label");

                entity.Property(e => e.Sscc18)
                    .IsRequired()
                    .HasColumnName("sscc18")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .HasColumnName("tracking_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.WeightDimension)
                    .HasColumnName("weight_dimension")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(5, 1)");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.Asn)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_ASN_Box");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Asn)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__ASN__location_id__735627D4");

                entity.HasOne(d => d.ReferencedOrder)
                    .WithMany(p => p.Asn)
                    .HasForeignKey(d => d.ReferencedOrderId)
                    .HasConstraintName("FK__ASN__referenced___327545C2");
            });

            modelBuilder.Entity<Asndetail>(entity =>
            {
                entity.ToTable("ASNDetail");

                entity.HasIndex(e => e.AsnId)
                    .HasName("IX_ASNDetail_ASN");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_ASNDetail_Client");

                entity.HasIndex(e => new { e.Quantity, e.ShipmentlineId })
                    .HasName("IX_ASNDetail_ShipmentLine");

                entity.Property(e => e.AsndetailId).HasColumnName("asndetail_id");

                entity.Property(e => e.AsnId).HasColumnName("asn_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.HasOne(d => d.Asn)
                    .WithMany(p => p.Asndetail)
                    .HasForeignKey(d => d.AsnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASNDetail_ASN");
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasIndex(e => e.EdidocumentId)
                    .HasName("Assignment_EDIDocument_IX");

                entity.HasIndex(e => new { e.ClientId, e.CreationDate })
                    .HasName("Assignment_Client_IX");

                entity.HasIndex(e => new { e.FactorId, e.AccountNo })
                    .HasName("Assignment_Factor_IX");

                entity.HasIndex(e => new { e.RemittoCliententityId, e.SubmissionDate })
                    .HasName("Assignment_ClientEntity_IX");

                entity.Property(e => e.AssignmentId).HasColumnName("assignment_id");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasColumnName("account_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.FactorId).HasColumnName("factor_id");

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnName("submission_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Assignmen__clien__2E6EFC3C");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__Assignmen__edido__323F8D20");

                entity.HasOne(d => d.Factor)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.FactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Assignmen__facto__2F632075");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Assignmen__remit__305744AE");
            });

            modelBuilder.Entity<AssignmentInvoice>(entity =>
            {
                entity.HasIndex(e => new { e.AssignmentId, e.InvoiceId })
                    .HasName("Assignment_U")
                    .IsUnique();

                entity.Property(e => e.AssignmentinvoiceId).HasColumnName("assignmentinvoice_id");

                entity.Property(e => e.AssignmentId).HasColumnName("assignment_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.AssignmentInvoice)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK__Assignmen__assig__36101E04");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.AssignmentInvoice)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Assignmen__invoi__3704423D");
            });

            modelBuilder.Entity<Assortment>(entity =>
            {
                entity.HasIndex(e => new { e.AssortmentProductId, e.ComponentProductId })
                    .HasName("Assortment_U")
                    .IsUnique();

                entity.Property(e => e.AssortmentId).HasColumnName("assortment_id");

                entity.Property(e => e.AssortmentProductId).HasColumnName("assortment_product_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ComponentProductId).HasColumnName("component_product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.HasOne(d => d.AssortmentProduct)
                    .WithMany(p => p.AssortmentAssortmentProduct)
                    .HasForeignKey(d => d.AssortmentProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assortment_Product1");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Assortment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assortment_Client");

                entity.HasOne(d => d.ComponentProduct)
                    .WithMany(p => p.AssortmentComponentProduct)
                    .HasForeignKey(d => d.ComponentProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assortment_Product2");
            });

            modelBuilder.Entity<Atschange>(entity =>
            {
                entity.ToTable("ATSChange");

                entity.HasIndex(e => new { e.ClientId, e.ProductId })
                    .HasName("IX_ATSChange");

                entity.Property(e => e.AtschangeId).HasColumnName("atschange_id");

                entity.Property(e => e.Changedate)
                    .HasColumnName("changedate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasIndex(e => new { e.TableKey, e.TableName })
                    .HasName("Audit_TableKey_IX");

                entity.Property(e => e.AuditId).HasColumnName("Audit_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditDate).HasColumnType("datetime");

                entity.Property(e => e.LastModified)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AuditValue>(entity =>
            {
                entity.HasIndex(e => e.AuditId)
                    .HasName("AuditValue_Audit_IX");

                entity.Property(e => e.AuditvalueId).HasColumnName("Auditvalue_id");

                entity.Property(e => e.AuditId).HasColumnName("Audit_id");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Audit)
                    .WithMany(p => p.AuditValue)
                    .HasForeignKey(d => d.AuditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditValue_Audit");
            });

            modelBuilder.Entity<Base>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.BaseCode })
                    .HasName("Base_U")
                    .IsUnique();

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.Assortment).HasColumnName("assortment");

                entity.Property(e => e.BaseCode)
                    .HasColumnName("base_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PerSizePricing).HasColumnName("per_size_pricing");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ShowCreatedOnly)
                    .HasColumnName("show_created_only")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Base)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Base_Client");
            });

            modelBuilder.Entity<BillOfLading>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.BolNumber })
                    .HasName("bol_U")
                    .IsUnique();

                entity.Property(e => e.BillofladingId).HasColumnName("billoflading_id");

                entity.Property(e => e.BilltoCliententityId).HasColumnName("billto_cliententity_id");

                entity.Property(e => e.BolNumber)
                    .IsRequired()
                    .HasColumnName("bol_number")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierCliententityId).HasColumnName("carrier_cliententity_id");

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.ConsolidatorCliententityId).HasColumnName("consolidator_cliententity_id");

                entity.Property(e => e.ExpectedShipDate)
                    .HasColumnName("expected_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fob).HasColumnName("fob");

                entity.Property(e => e.FreightChargeTerms).HasColumnName("freight_charge_terms");

                entity.Property(e => e.LoadId)
                    .HasColumnName("load_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MasterGroup).HasColumnName("master_group");

                entity.Property(e => e.ProNumber)
                    .HasColumnName("pro_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rownumber)
                    .IsRequired()
                    .HasColumnName("rownumber")
                    .IsRowVersion();

                entity.Property(e => e.SealNo)
                    .HasColumnName("seal_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipfromCliententityId).HasColumnName("shipfrom_cliententity_id");

                entity.Property(e => e.ShipmentType)
                    .HasColumnName("shipment_type")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ShiptoClietnentityId).HasColumnName("shipto_clietnentity_id");

                entity.Property(e => e.SpecialInstructions)
                    .HasColumnName("special_instructions")
                    .HasMaxLength(512);

                entity.Property(e => e.TrailerNo)
                    .HasColumnName("trailer_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CarrierCliententity)
                    .WithMany(p => p.BillOfLadingCarrierCliententity)
                    .HasForeignKey(d => d.CarrierCliententityId)
                    .HasConstraintName("FK_bol_ClientEntity1");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.BillOfLading)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillOfLading_Client");

                entity.HasOne(d => d.ConsolidatorCliententity)
                    .WithMany(p => p.BillOfLadingConsolidatorCliententity)
                    .HasForeignKey(d => d.ConsolidatorCliententityId)
                    .HasConstraintName("FK__BillOfLad__conso__1A2654B1");

                entity.HasOne(d => d.ShipfromCliententity)
                    .WithMany(p => p.BillOfLadingShipfromCliententity)
                    .HasForeignKey(d => d.ShipfromCliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bol_ClientEntity2");

                entity.HasOne(d => d.ShiptoClietnentity)
                    .WithMany(p => p.BillOfLadingShiptoClietnentity)
                    .HasForeignKey(d => d.ShiptoClietnentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bol_ClientEntity3");
            });

            modelBuilder.Entity<Bin>(entity =>
            {
                entity.Property(e => e.BinId).HasColumnName("bin_id");

                entity.Property(e => e.AisleId).HasColumnName("aisle_id");

                entity.Property(e => e.BinCode)
                    .HasColumnName("bin_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");
            });

            modelBuilder.Entity<Box>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.BoxCode })
                    .HasName("box_u")
                    .IsUnique();

                entity.Property(e => e.BoxId).HasColumnName("box_id");

                entity.Property(e => e.BoxCode)
                    .HasColumnName("box_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.LengthDimensionId).HasColumnName("length_dimension_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.WeightDimensionId).HasColumnName("weight_dimension_id");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Box)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Box__client_id__72C12AF7");

                entity.HasOne(d => d.LengthDimension)
                    .WithMany(p => p.BoxLengthDimension)
                    .HasForeignKey(d => d.LengthDimensionId)
                    .HasConstraintName("FK__Box__length_dime__0DFF3118");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Box)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Box__product_id__119B8329");

                entity.HasOne(d => d.WeightDimension)
                    .WithMany(p => p.BoxWeightDimension)
                    .HasForeignKey(d => d.WeightDimensionId)
                    .HasConstraintName("FK__Box__weight_dime__0D0B0CDF");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__Brand__3214EC263C4F8F69")
                    .IsUnique();

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BrandImage).HasColumnName("brand_image");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("brand_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CdnId).HasColumnName("cdn_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.FcRoyaltyPercentage)
                    .HasColumnName("fc_royalty_percentage")
                    .HasColumnType("numeric(6, 3)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LicensorId).HasColumnName("licensor_id");

                entity.Property(e => e.LogoContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoFileName).HasMaxLength(255);

                entity.Property(e => e.QbClassesId).HasColumnName("qb_classes_id");

                entity.Property(e => e.RoyaltyPercentage)
                    .HasColumnName("royalty_percentage")
                    .HasColumnType("numeric(6, 3)");

                entity.HasOne(d => d.Cdn)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.CdnId)
                    .HasConstraintName("FK__Brand__cdn_id__7C9F9AEC");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brand_Client1");

                entity.HasOne(d => d.Licensor)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.LicensorId)
                    .HasConstraintName("FK_Brand_Licensor");

                entity.HasOne(d => d.QbClasses)
                    .WithMany(p => p.Brand)
                    .HasForeignKey(d => d.QbClassesId)
                    .HasConstraintName("FK_Brand_qb_Classes");
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.Property(e => e.BuyerId).HasColumnName("buyer_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.BuyerCode)
                    .IsRequired()
                    .HasColumnName("buyer_code")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Buyer)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Buyer__brand_id__387F7AC9");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Buyer)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Buyer__client_id__4D9151E1");

                entity.HasOne(d => d.Cliententity)
                    .WithMany(p => p.Buyer)
                    .HasForeignKey(d => d.CliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Buyer__clientent__46E45452");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Buyer)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK__Buyer__division___378B5690");
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.HasIndex(e => e.ScacCode)
                    .HasName("IX_Carrier")
                    .IsUnique();

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.CarrierCode)
                    .HasColumnName("carrier_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Manifest).HasColumnName("manifest");

                entity.Property(e => e.MasterBol).HasColumnName("master_bol");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ScacCode)
                    .IsRequired()
                    .HasColumnName("scac_code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceLevels)
                    .HasColumnName("service_levels")
                    .HasColumnType("xml");

                entity.Property(e => e.SmallParcel).HasColumnName("small_parcel");

                entity.Property(e => e.TrackingNumbers).HasColumnName("tracking_numbers");

                entity.Property(e => e.TrackingValidation)
                    .HasColumnName("tracking_validation")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingValidationDescription)
                    .HasColumnName("tracking_validation_description")
                    .HasMaxLength(800);

                entity.Property(e => e.TransportationMethod)
                    .HasColumnName("transportation_method")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VicsBol).HasColumnName("vics_bol");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Carrier)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_Carrier_Entity");
            });

            modelBuilder.Entity<CarrierEntity>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.CarrierId })
                    .HasName("CarrierEntity_U")
                    .IsUnique();

                entity.Property(e => e.CarrierentityId).HasColumnName("carrierentity_id");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("account_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierEntity)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierEntity_Carrier");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.CarrierEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierEntity_Entity");
            });

            modelBuilder.Entity<CarrierServiceLevel>(entity =>
            {
                entity.HasKey(e => e.CarrierserviceId);

                entity.Property(e => e.CarrierserviceId).HasColumnName("carrierservice_id");

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.WsKey)
                    .HasColumnName("ws_key")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CasePack>(entity =>
            {
                entity.HasIndex(e => e.Rowversion)
                    .HasName("CasePack_V");

                entity.HasIndex(e => new { e.CaseSizeId, e.PackSizeId })
                    .HasName("CasePack_U")
                    .IsUnique();

                entity.Property(e => e.CasepackId).HasColumnName("casepack_id");

                entity.Property(e => e.CaseSizeId).HasColumnName("case_size_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.PackSizeId).HasColumnName("pack_size_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.HasOne(d => d.CaseSize)
                    .WithMany(p => p.CasePackCaseSize)
                    .HasForeignKey(d => d.CaseSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasePack_CaseSize");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CasePack)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasePack_Client");

                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.CasePackPackSize)
                    .HasForeignKey(d => d.PackSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasePack_PackSize");
            });

            modelBuilder.Entity<Catalogue>(entity =>
            {
                entity.HasIndex(e => e.CatalogueName)
                    .HasName("UC_catalogue_name")
                    .IsUnique();

                entity.Property(e => e.CatalogueId).HasColumnName("catalogue_id");

                entity.Property(e => e.CatalogueName)
                    .IsRequired()
                    .HasColumnName("catalogue_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.HasLogin)
                    .HasColumnName("has_login")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HasName)
                    .HasColumnName("has_name")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HasSelection)
                    .HasColumnName("has_selection")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CatalogueBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Cdn>(entity =>
            {
                entity.ToTable("CDN");

                entity.Property(e => e.CdnId).HasColumnName("cdn_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("content_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Etag)
                    .HasColumnName("ETag")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublicUrl)
                    .HasColumnName("public_url")
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Cdn)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__CDN__client_id__464CE085");
            });

            modelBuilder.Entity<Cdnobject>(entity =>
            {
                entity.ToTable("CDNobject");

                entity.Property(e => e.CdnobjectId).HasColumnName("cdnobject_id");

                entity.Property(e => e.CdnId).HasColumnName("cdn_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Etag)
                    .HasColumnName("ETag")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Objecttype).HasColumnName("objecttype");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Cdn)
                    .WithMany(p => p.Cdnobject)
                    .HasForeignKey(d => d.CdnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CDNobject__cdn_i__1D95AF0C");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Cdnobject)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CDNobject__clien__1E89D345");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cdnobject)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CDNobject__user___1F7DF77E");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ClientCode)
                    .HasName("Client_U")
                    .IsUnique();

                entity.HasIndex(e => e.ClientId)
                    .HasName("Cllient_PK")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__Client__3214EC2634AE6DA1")
                    .IsUnique();

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BillPrefix)
                    .HasColumnName("bill_prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.BillSequence)
                    .HasColumnName("bill_sequence")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillZeropadding)
                    .HasColumnName("bill_zeropadding")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Billingbase).HasColumnName("billingbase");

                entity.Property(e => e.BolSeed).HasColumnName("bol_seed");

                entity.Property(e => e.Catalog)
                    .HasColumnName("catalog")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasColumnName("client_code")
                    .HasMaxLength(10);

                entity.Property(e => e.ClientLogo).HasColumnName("client_logo");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Datasource)
                    .HasColumnName("datasource")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dbid).HasColumnName("dbid");

                entity.Property(e => e.EdiId)
                    .HasColumnName("edi_id")
                    .HasMaxLength(10);

                entity.Property(e => e.EdiQualifier)
                    .HasColumnName("edi_qualifier")
                    .HasMaxLength(50);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.HasDivisions).HasColumnName("has_divisions");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.InvoicePrefix)
                    .HasColumnName("invoice_prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.InvoiceSequence).HasColumnName("invoice_sequence");

                entity.Property(e => e.InvoiceZeropadding)
                    .HasColumnName("invoice_zeropadding")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.LogoContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogoFileName).HasMaxLength(255);

                entity.Property(e => e.MontisvirDate)
                    .HasColumnName("montisvir_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrderPrefix)
                    .HasColumnName("order_prefix")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSequence).HasColumnName("order_sequence");

                entity.Property(e => e.OrderZeropadding).HasColumnName("order_zeropadding");

                entity.Property(e => e.OwnerCode)
                    .HasColumnName("owner_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ParentClientId).HasColumnName("parent_client_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.QbClass)
                    .HasColumnName("qb_class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbItem)
                    .HasColumnName("qb_item")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QbMinimumPerMonth)
                    .HasColumnName("qb_minimum_per_month")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.QbMinimumPerOrder)
                    .HasColumnName("qb_minimum_per_order")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.QbPercentage)
                    .HasColumnName("qb_percentage")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.QbTermdays).HasColumnName("qb_termdays");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SubscriptionDate)
                    .HasColumnName("subscription_date")
                    .HasColumnType("date");

                entity.Property(e => e.UpcblockId).HasColumnName("upcblock_id");

                entity.Property(e => e.UseColorCode)
                    .HasColumnName("use_color_code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseColorDesc)
                    .HasColumnName("use_color_desc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseDisplaySize)
                    .HasColumnName("use_display_size")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseNrfColor)
                    .HasColumnName("use_nrf_color")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseNrfSize)
                    .HasColumnName("use_nrf_size")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSizeCode)
                    .HasColumnName("use_size_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseStyleCode)
                    .HasColumnName("use_style_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseStyleName)
                    .HasColumnName("use_style_name")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK__Client__currency__4058856E");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_Client_Entity");

                entity.HasOne(d => d.ParentClient)
                    .WithMany(p => p.InverseParentClient)
                    .HasForeignKey(d => d.ParentClientId)
                    .HasConstraintName("FK__Client__parent_c__3F646135");
            });

            modelBuilder.Entity<ClientCatalogue>(entity =>
            {
                entity.Property(e => e.ClientcatalogueId).HasColumnName("clientcatalogue_id");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasColumnName("account_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AutoSend).HasColumnName("auto_send");

                entity.Property(e => e.CatalogueId).HasColumnName("catalogue_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientcatalogueName)
                    .IsRequired()
                    .HasColumnName("clientcatalogue_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientCatalogueCode>(entity =>
            {
                entity.HasIndex(e => new { e.ClientcatalogueId, e.SelectionCode })
                    .HasName("UC_clientcatalogue_selectioncode")
                    .IsUnique();

                entity.Property(e => e.ClientcataloguecodeId).HasColumnName("clientcataloguecode_id");

                entity.Property(e => e.ClientcatalogueId).HasColumnName("clientcatalogue_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectionCode)
                    .IsRequired()
                    .HasColumnName("selection_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientCatalogueWebService>(entity =>
            {
                entity.HasKey(e => e.CatalogueWebServiceLoginId);

                entity.Property(e => e.CatalogueWebServiceLoginId).HasColumnName("CatalogueWebServiceLogin_id");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasColumnName("Account_Code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogueId).HasColumnName("Catalogue_id");

                entity.Property(e => e.CatalogueName)
                    .HasColumnName("Catalogue_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ClientId).HasColumnName("Client_id");

                entity.Property(e => e.Demo).HasColumnName("demo");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("Network_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ClientEntity>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.EntityId })
                    .HasName("ClientEntity_U")
                    .IsUnique();

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("account_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.CreditLimit)
                    .HasColumnName("credit_limit")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(20);

                entity.Property(e => e.DiscountLimit).HasColumnName("discount_limit");

                entity.Property(e => e.DropshipConfiguration)
                    .HasColumnName("dropship_configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.DunsNumber)
                    .HasColumnName("duns_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdiConfiguration)
                    .HasColumnName("edi_configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EmailShipConfirm)
                    .HasColumnName("email_ship_confirm")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.FactorId).HasColumnName("factor_id");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.PriceBase).HasColumnName("price_base");

                entity.Property(e => e.PricePoints)
                    .HasColumnName("price_points")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.RemittoEntityId).HasColumnName("remitto_entity_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ShipviaId).HasColumnName("shipvia_id");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uuid).HasColumnName("uuid");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("vendor_no")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientEntity)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientEntity_Client");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ClientEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientEntity_Entity");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.ClientEntity)
                    .HasForeignKey(d => d.InventoryregionId)
                    .HasConstraintName("FK__ClientEnt__inven__192A91EA");

                entity.HasOne(d => d.Terms)
                    .WithMany(p => p.ClientEntity)
                    .HasForeignKey(d => d.TermsId)
                    .HasConstraintName("FK_ClientEntity_Terms");
            });

            modelBuilder.Entity<ClientEntityContact>(entity =>
            {
                entity.Property(e => e.CliententitycontactId).HasColumnName("cliententitycontact_id");

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasColumnName("contact")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Cliententity)
                    .WithMany(p => p.ClientEntityContact)
                    .HasForeignKey(d => d.CliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientEntityContact_ClientEntity");
            });

            modelBuilder.Entity<ClientExport>(entity =>
            {
                entity.Property(e => e.ClientexportId).HasColumnName("clientexport_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ClientInvoice>(entity =>
            {
                entity.Property(e => e.ClientinvoiceId).HasColumnName("clientinvoice_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoiceFromDate)
                    .HasColumnName("invoice_from_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceToDate)
                    .HasColumnName("invoice_to_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentechProfileId)
                    .IsRequired()
                    .HasColumnName("paymentech_profile_id")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ClientInvoiceLine>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.ClientinvoiceId, e.Linenumber })
                    .HasName("ClientInvoiceLine_U")
                    .IsUnique();

                entity.Property(e => e.ClientinvoicelineId)
                    .HasColumnName("clientinvoiceline_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(19, 2)")
                    .HasComputedColumnSql("([quantity]*[price])");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientinvoiceId).HasColumnName("clientinvoice_id");

                entity.Property(e => e.Istaxable).HasColumnName("istaxable");

                entity.Property(e => e.Linenumber).HasColumnName("linenumber");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanoptionId).HasColumnName("planoption_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientInvoiceLine)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientInvoiceLine_Client");

                entity.HasOne(d => d.Clientinvoice)
                    .WithMany(p => p.ClientInvoiceLine)
                    .HasForeignKey(d => d.ClientinvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientInvoiceLine_Invoice");

                entity.HasOne(d => d.Clientinvoiceline)
                    .WithOne(p => p.InverseClientinvoiceline)
                    .HasForeignKey<ClientInvoiceLine>(d => d.ClientinvoicelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientInvoiceLine_InvoiceLine");

                entity.HasOne(d => d.Planoption)
                    .WithMany(p => p.ClientInvoiceLine)
                    .HasForeignKey(d => d.PlanoptionId)
                    .HasConstraintName("FK_ClientInvoiceLine_PlanOption");
            });

            modelBuilder.Entity<ClientUser>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.UserId })
                    .HasName("ClientUser_U")
                    .IsUnique();

                entity.Property(e => e.ClientuserId)
                    .HasColumnName("clientuser_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientUser)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientUser_Client");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClientUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientUser_User");
            });

            modelBuilder.Entity<ClientWarehouse>(entity =>
            {
                entity.HasIndex(e => new { e.WarehouseCode, e.ClientId })
                    .HasName("MWarehouse_U")
                    .IsUnique();

                entity.Property(e => e.ClientwarehouseId).HasColumnName("clientwarehouse_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.InventorystatusId).HasColumnName("inventorystatus_id");

                entity.Property(e => e.WarehouseCode)
                    .IsRequired()
                    .HasColumnName("warehouse_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e._3plInventorystatus)
                    .HasColumnName("3pl_inventorystatus")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e._3plWarehouseCode)
                    .HasColumnName("3pl_warehouse_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Directedi)
                    .WithMany(p => p.ClientWarehouse)
                    .HasForeignKey(d => d.DirectediId)
                    .HasConstraintName("FK__ClientWar__direc__0AA21B8E");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.ClientWarehouse)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__ClientWar__edido__7647A318");

                entity.HasOne(d => d.Inventorystatus)
                    .WithMany(p => p.ClientWarehouse)
                    .HasForeignKey(d => d.InventorystatusId)
                    .HasConstraintName("FK_ClientWarehouse_InventoryStatus");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.HasIndex(e => new { e.CollectionCode, e.ClientId })
                    .HasName("UQ__Collecti__1D07B0492A684B5D")
                    .IsUnique();

                entity.Property(e => e.CollectionId).HasColumnName("collection_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CollectionCode)
                    .HasColumnName("collection_code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.SeasonId).HasColumnName("season_id");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.ColorId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ColorId)
                    .HasName("Color_PK")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.ColorCode, e.ClientId })
                    .HasName("Color_U")
                    .IsUnique();

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ColorCode)
                    .IsRequired()
                    .HasColumnName("color_code")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.NrfCode)
                    .HasColumnName("nrf_code")
                    .HasMaxLength(3);

                entity.Property(e => e.QrsDesc)
                    .HasColumnName("qrs_desc")
                    .HasMaxLength(10);

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Commission>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId)
                    .HasName("NC_Commission_Invoice");

                entity.HasIndex(e => e.OrderId)
                    .HasName("NC_Commission_Order");

                entity.HasIndex(e => e.SalespersonId)
                    .HasName("NC_Commission_Salesperson");

                entity.HasIndex(e => new { e.InvoiceId, e.SalespersonId })
                    .HasName("Commission_Invoice_U")
                    .IsUnique()
                    .HasFilter("([invoice_id] IS NOT NULL AND [salesperson_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.OrderId, e.SalespersonId })
                    .HasName("Commission_Order_U")
                    .IsUnique()
                    .HasFilter("([order_id] IS NOT NULL AND [salesperson_id] IS NOT NULL)");

                entity.Property(e => e.CommissionId).HasColumnName("commission_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Commission)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commission_Client");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Commission)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Commission_Order");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.CommissionNavigation)
                    .HasForeignKey(d => d.SalespersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commission_Salesperson");
            });

            modelBuilder.Entity<CommissionRule>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("commission_rule_brand_IX");

                entity.HasIndex(e => e.CliententityId)
                    .HasName("IX_CommissionRule_ClientEntity");

                entity.HasIndex(e => e.SalespersonId)
                    .HasName("IX_CommissionRule_Salesperson");

                entity.HasIndex(e => new { e.CliententityId, e.SalespersonId })
                    .HasName("IX_CommissionRule_U");

                entity.HasIndex(e => new { e.DivisionId, e.BrandId })
                    .HasName("commission_rule_divisionbrand_IX");

                entity.Property(e => e.CommissionruleId).HasColumnName("commissionrule_id");

                entity.Property(e => e.ActiveDate)
                    .HasColumnName("active_date")
                    .HasColumnType("date");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(5, 3)");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Commissio__brand__57063EB1");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionRule_Client");

                entity.HasOne(d => d.Cliententity)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.CliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionRule_ClientEntity");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_CommissionRule_Department");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_CommissionRule_Division");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_CommissionRule_Region");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.CommissionRule)
                    .HasForeignKey(d => d.SalespersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionRule_Salesperson");
            });

            modelBuilder.Entity<Connection>(entity =>
            {
                entity.Property(e => e.ConnectionId)
                    .HasColumnName("connection_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConnectionType>(entity =>
            {
                entity.Property(e => e.ConnectiontypeId)
                    .HasColumnName("connectiontype_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.Property(e => e.ContainerId).HasColumnName("container_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContainerNo)
                    .IsRequired()
                    .HasColumnName("container_no")
                    .HasMaxLength(50);

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.SealNo)
                    .HasColumnName("seal_no")
                    .HasMaxLength(50);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("numeric(5, 0)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Container)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Container_Client");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Container)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Container_Route");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.A2)
                    .HasColumnName("a2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.A3)
                    .HasColumnName("a3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VatValidation)
                    .HasColumnName("vat_validation")
                    .HasMaxLength(255);

                entity.Property(e => e.VatValidationDescription)
                    .HasColumnName("vat_validation_description")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<CreditAllocation>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId)
                    .HasName("IX_CreditAllocation_Invoice");

                entity.HasIndex(e => new { e.CreditrequestId, e.InvoiceId })
                    .HasName("IX_CreditAllocation")
                    .IsUnique();

                entity.Property(e => e.CreditallocationId)
                    .HasColumnName("creditallocation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CreditrequestId).HasColumnName("creditrequest_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.Rownumber)
                    .IsRequired()
                    .HasColumnName("rownumber")
                    .IsRowVersion();

                entity.HasOne(d => d.Creditrequest)
                    .WithMany(p => p.CreditAllocation)
                    .HasForeignKey(d => d.CreditrequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditAllocation_CreditRequest");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CreditAllocation)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditAllocation_Invoice");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.Property(e => e.CreditcardId).HasColumnName("creditcard_id");

                entity.Property(e => e.Cardtype).HasColumnName("cardtype");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CliententityId).HasColumnName("cliententity_id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("expiry_date")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Last4)
                    .HasColumnName("last_4")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentProfileId).HasColumnName("payment_profile_id");

                entity.Property(e => e.PaymentechProfileId)
                    .IsRequired()
                    .HasColumnName("paymentech_profile_id")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SubscriptionDate)
                    .HasColumnName("subscription_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CreditLog>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("CreditLog_Order_IX");

                entity.Property(e => e.CreditlogId).HasColumnName("creditlog_id");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("action_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DecisionId).HasColumnName("decision_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CreditLog)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_CreditLog_Order");
            });

            modelBuilder.Entity<CreditRequest>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.Credittype })
                    .HasName("CreditRequest_Order")
                    .HasFilter("([order_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.PoId, e.Credittype })
                    .HasName("CreditRequest_PO")
                    .HasFilter("([po_id] IS NOT NULL)");

                entity.Property(e => e.CreditrequestId).HasColumnName("creditrequest_id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ApprovalCode)
                    .HasColumnName("approval_code")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("approval_date")
                    .HasColumnType("date");

                entity.Property(e => e.ApprovalUserId).HasColumnName("approval_user_id");

                entity.Property(e => e.ApprovalValue)
                    .HasColumnName("approval_value")
                    .HasMaxLength(30);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientenityId).HasColumnName("clientenity_id");

                entity.Property(e => e.CreditcardId).HasColumnName("creditcard_id");

                entity.Property(e => e.Credittype).HasColumnName("credittype");

                entity.Property(e => e.Decision)
                    .HasColumnName("decision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DecisionDate)
                    .HasColumnName("decision_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("date");

                entity.Property(e => e.FactorId).HasColumnName("factor_id");

                entity.Property(e => e.Open)
                    .HasColumnName("open")
                    .HasColumnType("numeric(11, 2)")
                    .HasComputedColumnSql("([amount]-isnull([used],(0)))");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PoId).HasColumnName("po_id");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceType)
                    .HasColumnName("reference_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceValue)
                    .HasColumnName("reference_value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.RequestAmount)
                    .HasColumnName("request_amount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("request_date")
                    .HasColumnType("date");

                entity.Property(e => e.SubmissionDate)
                    .HasColumnName("submission_date")
                    .HasColumnType("date");

                entity.Property(e => e.Used)
                    .HasColumnName("used")
                    .HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CreditRequest)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CreditReq__clien__51BE48B7");

                entity.HasOne(d => d.Clientenity)
                    .WithMany(p => p.CreditRequestClientenity)
                    .HasForeignKey(d => d.ClientenityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Approval_ClientEntity");

                entity.HasOne(d => d.Factor)
                    .WithMany(p => p.CreditRequest)
                    .HasForeignKey(d => d.FactorId)
                    .HasConstraintName("FK__CreditReq__facto__3FC227DC");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CreditRequest)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CreditReq__order__6CAA0658");

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.CreditRequest)
                    .HasForeignKey(d => d.PoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__CreditReq__po_id__6BB5E21F");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.CreditRequestRemittoCliententity)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Approval_ClientEntity1");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("Currency_U")
                    .IsUnique();

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CultureInfo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencyName)
                    .HasColumnName("currency_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasColumnType("numeric(12, 6)");

                entity.Property(e => e.ExchangeRateDate)
                    .HasColumnName("exchange_rate_date")
                    .HasColumnType("date");

                entity.Property(e => e.QbCurrencyId).HasColumnName("qb_currency_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Symbol)
                    .HasColumnName("symbol")
                    .HasMaxLength(2);

                entity.HasOne(d => d.QbCurrency)
                    .WithMany(p => p.Currency)
                    .HasForeignKey(d => d.QbCurrencyId)
                    .HasConstraintName("FK_Currency_qb_Currency");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.Property(e => e.CustomertypeId).HasColumnName("customertype_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.DepartmentCode })
                    .HasName("IX_Department_U")
                    .IsUnique();

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasColumnName("department_code")
                    .HasMaxLength(10);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.DetailId).HasColumnName("detail_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DetailDate)
                    .HasColumnName("detail_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("details")
                    .HasColumnType("xml");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.EmailDate)
                    .HasColumnName("email_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Detail__brand_id__33D87852");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detail__client_i__3007E76E");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK__Detail__division__34CC9C8B");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.SalespersonId)
                    .HasConstraintName("FK__Detail__salesper__30FC0BA7");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Detail)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK__Detail__season_i__32E45419");
            });

            modelBuilder.Entity<Dimension>(entity =>
            {
                entity.HasIndex(e => e.DimensionCode)
                    .HasName("dimension_u")
                    .IsUnique();

                entity.Property(e => e.DimensionId).HasColumnName("dimension_id");

                entity.Property(e => e.Conversion).HasColumnName("conversion");

                entity.Property(e => e.DefaultDimension).HasColumnName("default_dimension");

                entity.Property(e => e.DimensionCode)
                    .IsRequired()
                    .HasColumnName("dimension_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DimensiontypeId).HasColumnName("dimensiontype_id");

                entity.Property(e => e.Offset).HasColumnName("offset");

                entity.Property(e => e.Visible).HasColumnName("visible");

                entity.HasOne(d => d.Dimensiontype)
                    .WithMany(p => p.Dimension)
                    .HasForeignKey(d => d.DimensiontypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dimension_dimensiontype_fk");
            });

            modelBuilder.Entity<DimensionType>(entity =>
            {
                entity.HasIndex(e => e.Description)
                    .HasName("dimensiontype_u")
                    .IsUnique();

                entity.Property(e => e.DimensiontypeId).HasColumnName("dimensiontype_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DirectEdi>(entity =>
            {
                entity.ToTable("DirectEDI");

                entity.HasIndex(e => e.CreationDate)
                    .HasName("DirectEDI_creation_date_IX");

                entity.HasIndex(e => e.Creationdatetime)
                    .HasName("directedi_creation_IX");

                entity.HasIndex(e => e.Reference)
                    .HasName("IX_DirectEDI");

                entity.HasIndex(e => new { e.ClientId, e.BodName, e.Usageindicator })
                    .HasName("DirectEDI_UnProcessed_IX")
                    .HasFilter("([is_processed]=(0))");

                entity.HasIndex(e => new { e.EntityId, e.ClientId, e.Reference })
                    .HasName("DirectEDI_ClientEntity_IX");

                entity.HasIndex(e => new { e.ClientId, e.Usageindicator, e.SchemaType, e.Reference })
                    .HasName("DirectEDI_Search_IX")
                    .HasFilter("([is_processed]=(0))");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.Bod)
                    .HasColumnName("bod")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_BODID]([XML]))");

                entity.Property(e => e.BodName)
                    .HasColumnName("bod_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_BODName]([XML]))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Creationdatetime)
                    .HasColumnName("creationdatetime")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_CreationDateTime]([XML]))");

                entity.Property(e => e.Creatorworkflow)
                    .HasColumnName("creatorworkflow")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_CreatorWorkflowID]([XML]))");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.IsProcessed).HasColumnName("is_processed");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_ownerID]([XML]))");

                entity.Property(e => e.Poxml)
                    .HasColumnName("POXML")
                    .HasColumnType("xml");

                entity.Property(e => e.ProcessDate)
                    .HasColumnName("process_date")
                    .HasColumnType("date");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_ReferenceID]([XML]))");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceType).HasColumnName("reference_type");

                entity.Property(e => e.SchemaType)
                    .HasColumnName("schema_type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tradingpartner)
                    .HasColumnName("tradingpartner")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_TradingPartnerID]([XML]))");

                entity.Property(e => e.Usageindicator)
                    .HasColumnName("usageindicator")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[XML_UsageIndicator]([XML]))");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("XML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.DirectEdi)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK__DirectEDI__entit__285FCD32");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DirectEdi)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DirectEDI_Order");
            });

            modelBuilder.Entity<DirectEdiitem>(entity =>
            {
                entity.ToTable("DirectEDIItem");

                entity.HasIndex(e => e.Checksum)
                    .HasName("DirectEDIItem_checksum");

                entity.Property(e => e.DirectediitemId).HasColumnName("directediitem_id");

                entity.Property(e => e.Checksum)
                    .HasColumnName("checksum")
                    .HasComputedColumnSql("(checksum(CONVERT([varchar](max),[Item],0)))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(8000)
                    .HasComputedColumnSql("(hashbytes('SHA1',CONVERT([varchar](8000),[Item],0)))");

                entity.Property(e => e.Hashkey).HasColumnName("hashkey");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DirectEdiitem)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectEDIItem_Client");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DirectEdiitem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_DirectEDIItem_Product");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.DivisionCode })
                    .HasName("Division_U")
                    .IsUnique();

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasColumnName("division_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.QbClass)
                    .HasColumnName("qb_class")
                    .HasMaxLength(20);

                entity.Property(e => e.QbClassesId).HasColumnName("qb_classes_id");

                entity.Property(e => e.UpcblockId).HasColumnName("upcblock_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_division_Client");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_division_Entity");

                entity.HasOne(d => d.QbClasses)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.QbClassesId)
                    .HasConstraintName("FK_Division_qb_Classes");

                entity.HasOne(d => d.Upcblock)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.UpcblockId)
                    .HasConstraintName("FK199794CD4B01703C");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.AliasId).HasColumnName("alias_id");

                entity.Property(e => e.AliasType).HasColumnName("alias_type");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DataType)
                    .HasColumnName("data_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(2000);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<EdiactivityStatus>(entity =>
            {
                entity.HasKey(e => e.ActivityStatus);

                entity.ToTable("EDIActivityStatus");

                entity.Property(e => e.ActivityStatus).HasColumnName("activity_status");

                entity.Property(e => e.StatusName)
                    .HasColumnName("status_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EdiactivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityType);

                entity.ToTable("EDIActivityType");

                entity.Property(e => e.ActivityType).HasColumnName("activity_type");

                entity.Property(e => e.ActivityName)
                    .HasColumnName("activity_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Edidocument>(entity =>
            {
                entity.HasKey(e => e.EdidocumentId);

                entity.ToTable("EDIDocument");

                entity.HasIndex(e => e.AcknowledgementDocumentId)
                    .HasName("EDIDocument_Acknowledgement_IX")
                    .HasFilter("([acknowledgement_document_id] IS NOT NULL)");

                entity.HasIndex(e => e.ClientEditradingpartnerId)
                    .HasName("IX_ClientEDITradingPartner");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_Client_id");

                entity.HasIndex(e => e.EdidocumenttypeId)
                    .HasName("EDIDocument_Type_IX");

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__EDIDocum__3214EC26038B09AB")
                    .IsUnique();

                entity.HasIndex(e => e.LastActivityDate)
                    .HasName("EDIDocument_Activity_IX");

                entity.HasIndex(e => e.SourceDocumentId)
                    .HasName("EDIDocument_Source_IX")
                    .HasFilter("([source_document_id] IS NOT NULL)");

                entity.HasIndex(e => e.SourceEdidocumentlogId)
                    .HasName("IX_EDIDocument_LogID")
                    .HasFilter("([source_edidocumentlog_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClientId, e.CreationDate })
                    .HasName("EDIDocument_Client_IX");

                entity.HasIndex(e => new { e.EditradingpartnerId, e.ControlNumber })
                    .HasName("EDIDocument_ControlNumber_IX");

                entity.HasIndex(e => new { e.Reference, e.ClientId })
                    .HasName("EDIDocument_Reference_IX");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.AcknowledgementCode)
                    .HasColumnName("acknowledgement_code")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcknowledgementDocumentId).HasColumnName("acknowledgement_document_id");

                entity.Property(e => e.CCreationDate)
                    .HasColumnName("c_creation_date")
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[creation_date]))");

                entity.Property(e => e.CdnId).HasColumnName("cdn_id");

                entity.Property(e => e.ClientEditradingpartnerId).HasColumnName("client_editradingpartner_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ControlNumber).HasColumnName("control_number");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Document).HasColumnName("document");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasColumnName("document_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentState).HasColumnName("document_state");

                entity.Property(e => e.Documenttype)
                    .IsRequired()
                    .HasColumnName("documenttype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EdidocumenttypeId).HasColumnName("edidocumenttype_id");

                entity.Property(e => e.EdiproviderId).HasColumnName("ediprovider_id");

                entity.Property(e => e.EditradingpartnerId).HasColumnName("editradingpartner_id");

                entity.Property(e => e.FileExtension)
                    .HasColumnName("file_extension")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring([document_name],(len([document_name])-patindex('%.%',reverse([document_name])))+(1),(5)))");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsaControlNumber).HasColumnName("ISA_control_number");

                entity.Property(e => e.LastActivityDate)
                    .HasColumnName("last_activity_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Month)
                    .HasColumnName("month")
                    .HasComputedColumnSql("(datepart(month,[creation_date]))");

                entity.Property(e => e.Reference)
                    .HasColumnName("reference")
                    .HasMaxLength(40);

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.SourceDocumentId).HasColumnName("source_document_id");

                entity.Property(e => e.SourceEdidocumentlogId).HasColumnName("source_edidocumentlog_id");

                entity.Property(e => e.Usageindicator)
                    .HasColumnName("usageindicator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasColumnType("xml");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasComputedColumnSql("(datepart(year,[creation_date]))");

                entity.HasOne(d => d.AcknowledgementDocument)
                    .WithMany(p => p.InverseAcknowledgementDocument)
                    .HasForeignKey(d => d.AcknowledgementDocumentId)
                    .HasConstraintName("FK__EDIDocume__ackno__0943E301");

                entity.HasOne(d => d.Cdn)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.CdnId)
                    .HasConstraintName("FK__EDIDocume__cdn_i__4B3E14D9");

                entity.HasOne(d => d.ClientEditradingpartner)
                    .WithMany(p => p.EdidocumentClientEditradingpartner)
                    .HasForeignKey(d => d.ClientEditradingpartnerId)
                    .HasConstraintName("FK__EDIDocume__clien__7EE70ABA");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__clien__0573521D");

                entity.HasOne(d => d.DocumentStateNavigation)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.DocumentState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__docum__6224E5E4");

                entity.HasOne(d => d.Edidocumenttype)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.EdidocumenttypeId)
                    .HasConstraintName("FK__EDIDocume__edido__7D33CC72");

                entity.HasOne(d => d.Ediprovider)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.EdiproviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__edipr__075B9A8F");

                entity.HasOne(d => d.Editradingpartner)
                    .WithMany(p => p.EdidocumentEditradingpartner)
                    .HasForeignKey(d => d.EditradingpartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__editr__084FBEC8");

                entity.HasOne(d => d.SourceDocument)
                    .WithMany(p => p.InverseSourceDocument)
                    .HasForeignKey(d => d.SourceDocumentId)
                    .HasConstraintName("FK__EDIDocume__sourc__0A38073A");

                entity.HasOne(d => d.SourceEdidocumentlog)
                    .WithMany(p => p.Edidocument)
                    .HasForeignKey(d => d.SourceEdidocumentlogId)
                    .HasConstraintName("FK__EDIDocume__sourc__1845C37D");
            });

            modelBuilder.Entity<EdidocumentLog>(entity =>
            {
                entity.ToTable("EDIDocumentLog");

                entity.HasIndex(e => e.EdidocumentId)
                    .HasName("EDIDocumentLog_EDIDocument_IX");

                entity.HasIndex(e => e.OutputDocumentId)
                    .HasName("EDIDocumentLog_Output_IX")
                    .HasFilter("([output_document_id] IS NOT NULL)");

                entity.Property(e => e.EdidocumentlogId).HasColumnName("edidocumentlog_id");

                entity.Property(e => e.ActivityData)
                    .IsRequired()
                    .HasColumnName("activity_data")
                    .HasColumnType("xml");

                entity.Property(e => e.ActivityEnd)
                    .HasColumnName("activity_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActivityStart)
                    .HasColumnName("activity_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActivityStatus).HasColumnName("activity_status");

                entity.Property(e => e.ActivityType).HasColumnName("activity_type");

                entity.Property(e => e.DocumentQueue)
                    .HasColumnName("document_queue")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.OutputDocumentId).HasColumnName("output_document_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ActivityStatusNavigation)
                    .WithMany(p => p.EdidocumentLog)
                    .HasForeignKey(d => d.ActivityStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__activ__69C607AC");

                entity.HasOne(d => d.ActivityTypeNavigation)
                    .WithMany(p => p.EdidocumentLog)
                    .HasForeignKey(d => d.ActivityType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDIDocume__activ__6501528F");

                entity.HasOne(d => d.EdidocumentNavigation)
                    .WithMany(p => p.EdidocumentLogEdidocumentNavigation)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__EDIDocume__edido__0EFCBC57");

                entity.HasOne(d => d.OutputDocument)
                    .WithMany(p => p.EdidocumentLogOutputDocument)
                    .HasForeignKey(d => d.OutputDocumentId)
                    .HasConstraintName("FK__EDIDocume__outpu__0FF0E090");
            });

            modelBuilder.Entity<EdidocumentState>(entity =>
            {
                entity.HasKey(e => e.DocumentState);

                entity.ToTable("EDIDocumentState");

                entity.Property(e => e.DocumentState).HasColumnName("document_state");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EdidocumentType>(entity =>
            {
                entity.ToTable("EDIDocumentType");

                entity.HasIndex(e => e.EdidocumenttypeId)
                    .HasName("IX_EDIDocumentType");

                entity.Property(e => e.EdidocumenttypeId).HasColumnName("edidocumenttype_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EdidocumentType)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__EDIDocume__clien__02B79B9E");
            });

            modelBuilder.Entity<Ediprovider>(entity =>
            {
                entity.ToTable("EDIProvider");

                entity.HasIndex(e => e.EntityId)
                    .HasName("EDIProvider_Entity_IX");

                entity.HasIndex(e => e.Name)
                    .HasName("EDIProider_U")
                    .IsUnique();

                entity.Property(e => e.EdiproviderId).HasColumnName("ediprovider_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RequireReference).HasColumnName("require_reference");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Ediprovider)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK__EDIProvid__entit__790D7B38");
            });

            modelBuilder.Entity<EditradingPartner>(entity =>
            {
                entity.HasKey(e => e.EditradingpartnerId);

                entity.ToTable("EDITradingPartner");

                entity.HasIndex(e => new { e.Id, e.Qualifier })
                    .HasName("EDITradingPartner_IDQualifier");

                entity.HasIndex(e => new { e.EntityId, e.Id, e.Qualifier })
                    .HasName("EDITradingPartner_U")
                    .IsUnique();

                entity.Property(e => e.EditradingpartnerId).HasColumnName("editradingpartner_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qualifier)
                    .HasColumnName("qualifier")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EditradingPartner)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDITradin__entit__018AE8D8");
            });

            modelBuilder.Entity<EditradingPartnerAlias>(entity =>
            {
                entity.ToTable("EDITradingPartnerAlias");

                entity.HasIndex(e => new { e.EdiproviderId, e.EditradingpartnerId, e.ClientId, e.EntityId })
                    .HasName("EDITradingPrtnerAlias_U")
                    .IsUnique();

                entity.Property(e => e.EditradingpartneraliasId)
                    .HasColumnName("editradingpartneralias_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasColumnType("xml");

                entity.Property(e => e.Checksum)
                    .HasColumnName("checksum")
                    .HasComputedColumnSql("(checksum(CONVERT([varchar](max),[alias],(0))))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EdiproviderId).HasColumnName("ediprovider_id");

                entity.Property(e => e.EditradingpartnerId).HasColumnName("editradingpartner_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.HasOne(d => d.Ediprovider)
                    .WithMany(p => p.EditradingPartnerAlias)
                    .HasForeignKey(d => d.EdiproviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDITradin__edipr__72606CED");

                entity.HasOne(d => d.Editradingpartner)
                    .WithMany(p => p.EditradingPartnerAlias)
                    .HasForeignKey(d => d.EditradingpartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDITradin__editr__73549126");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EditradingPartnerAlias)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDITradin__entit__7448B55F");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasKey(e => e.EntityId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.BilltoEntityId)
                    .HasName("Entity_billto_entity_id");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Entity_country_id");

                entity.HasIndex(e => e.DcEntityId)
                    .HasName("Entity_dc_entity_id");

                entity.HasIndex(e => e.EntityCode)
                    .HasName("Entity_U")
                    .IsUnique();

                entity.HasIndex(e => e.EntityId)
                    .HasName("Entity_PK")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.IsBillto)
                    .HasName("Entity_is_billto");

                entity.HasIndex(e => e.IsDc)
                    .HasName("Entity_is_dc");

                entity.HasIndex(e => e.IsFactory)
                    .HasName("Entity_is_factory");

                entity.HasIndex(e => e.IsRemitto)
                    .HasName("Entity_is_remitto");

                entity.HasIndex(e => e.IsShipto)
                    .HasName("Entity_is_shipto");

                entity.HasIndex(e => e.IsVendor)
                    .HasName("Entity_is_vendor");

                entity.HasIndex(e => e.RegionId)
                    .HasName("Entity_region_id");

                entity.HasIndex(e => new { e.ParentEntityId, e.Store })
                    .HasName("Entity_parent_entity_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("address_line1")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("address_line2")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine3)
                    .HasColumnName("address_line3")
                    .HasMaxLength(50);

                entity.Property(e => e.Attention)
                    .HasColumnName("attention")
                    .HasMaxLength(50);

                entity.Property(e => e.BilltoEntityId).HasColumnName("billto_entity_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasColumnType("xml");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DcEntityId).HasColumnName("dc_entity_id");

                entity.Property(e => e.Duns4)
                    .HasColumnName("DUNS4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntityCode)
                    .IsRequired()
                    .HasColumnName("entity_code")
                    .HasMaxLength(12);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsAgent).HasColumnName("is_agent");

                entity.Property(e => e.IsBillto).HasColumnName("is_billto");

                entity.Property(e => e.IsConsolidator).HasColumnName("is_consolidator");

                entity.Property(e => e.IsDc).HasColumnName("is_dc");

                entity.Property(e => e.IsDropship).HasColumnName("is_dropship");

                entity.Property(e => e.IsFactory).HasColumnName("is_factory");

                entity.Property(e => e.IsRemitto).HasColumnName("is_remitto");

                entity.Property(e => e.IsShipto).HasColumnName("is_shipto");

                entity.Property(e => e.IsVendor).HasColumnName("is_vendor");

                entity.Property(e => e.IsWarehouse).HasColumnName("is_warehouse");

                entity.Property(e => e.MaxDiscount).HasColumnName("max_discount");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.ParentEntityId).HasColumnName("parent_entity_id");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(14);

                entity.Property(e => e.ReferenceCount).HasColumnName("reference_count");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.San)
                    .HasColumnName("SAN")
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2);

                entity.Property(e => e.StateprovenceId).HasColumnName("stateprovence_id");

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasMaxLength(10);

                entity.Property(e => e.Unloccode)
                    .HasColumnName("unloccode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(100);

                entity.HasOne(d => d.BilltoEntity)
                    .WithMany(p => p.InverseBilltoEntity)
                    .HasForeignKey(d => d.BilltoEntityId)
                    .HasConstraintName("FK_Entity_BillTo");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Entity_Country");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Entity_Currency");

                entity.HasOne(d => d.DcEntity)
                    .WithMany(p => p.InverseDcEntity)
                    .HasForeignKey(d => d.DcEntityId)
                    .HasConstraintName("FK_Entity_DC");

                entity.HasOne(d => d.ParentEntity)
                    .WithMany(p => p.InverseParentEntity)
                    .HasForeignKey(d => d.ParentEntityId)
                    .HasConstraintName("FK_Entity_Parent");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Entity_Region");

                entity.HasOne(d => d.Stateprovence)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.StateprovenceId)
                    .HasConstraintName("FK_Entity_StateProvence");
            });

            modelBuilder.Entity<EntityEdiprovider>(entity =>
            {
                entity.HasKey(e => new { e.EdiproviderId, e.EntityId });

                entity.ToTable("EntityEDIProvider");

                entity.Property(e => e.EdiproviderId).HasColumnName("ediprovider_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Ediprovider)
                    .WithMany(p => p.EntityEdiprovider)
                    .HasForeignKey(d => d.EdiproviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EntityEDI__edipr__72139B1E");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityEdiprovider)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EntityEDI__entit__711F76E5");
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.HasIndex(e => new { e.BaseCurrencyId, e.TargetCurrencyId, e.Date })
                    .HasName("ExchangeRate_IX2");

                entity.HasIndex(e => new { e.TargetCurrencyId, e.Date, e.BaseCurrencyId })
                    .HasName("ExchangeRate_IX1");

                entity.Property(e => e.ExchangerateId).HasColumnName("exchangerate_id");

                entity.Property(e => e.BaseCurrencyId).HasColumnName("base_currency_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(12, 6)");

                entity.Property(e => e.TargetCurrencyId).HasColumnName("target_currency_id");

                entity.HasOne(d => d.BaseCurrency)
                    .WithMany(p => p.ExchangeRateBaseCurrency)
                    .HasForeignKey(d => d.BaseCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExchangeR__base___60BF8B77");

                entity.HasOne(d => d.TargetCurrency)
                    .WithMany(p => p.ExchangeRateTargetCurrency)
                    .HasForeignKey(d => d.TargetCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExchangeR__targe__61B3AFB0");
            });

            modelBuilder.Entity<Factor>(entity =>
            {
                entity.ToTable("factor");

                entity.Property(e => e.FactorId).HasColumnName("factor_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Factor)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK__factor__entity_i__519E4D26");
            });

            modelBuilder.Entity<Feed>(entity =>
            {
                entity.ToTable("feed");

                entity.Property(e => e.FeedId).HasColumnName("feed_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Feeditem>(entity =>
            {
                entity.ToTable("feeditem");

                entity.Property(e => e.FeeditemId).HasColumnName("feeditem_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.FeedId).HasColumnName("feed_id");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Feeditem)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feeditem__client__023023B7");

                entity.HasOne(d => d.Feed)
                    .WithMany(p => p.Feeditem)
                    .HasForeignKey(d => d.FeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__feeditem__feed_i__032447F0");
            });

            modelBuilder.Entity<Grillbotline>(entity =>
            {
                entity.HasKey(e => new { e.OrderNo, e.ProductCode });

                entity.ToTable("grillbotline");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("Product_Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grillbotorder>(entity =>
            {
                entity.HasKey(e => e.OrderNo);

                entity.ToTable("grillbotorder");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("Order_No")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPaid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipToAddress1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToLastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPostalCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Interface>(entity =>
            {
                entity.Property(e => e.InterfaceId)
                    .HasColumnName("interface_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.LotId })
                    .HasName("IX_Inventory");

                entity.HasIndex(e => new { e.ClientId, e.ProductId, e.LotId })
                    .HasName("Inventory_OnHand")
                    .HasFilter("([quantity]>(0))");

                entity.HasIndex(e => new { e.ClientId, e.EntityId, e.ProductId, e.LotId, e.InventorystatusId, e.ShipmentId })
                    .HasName("Inventory_U")
                    .IsUnique();

                entity.HasIndex(e => new { e.InventoryId, e.ClientId, e.EntityId, e.ProductId, e.LotId, e.InventorystatusId, e.ShipmentId })
                    .HasName("Inventory_Shipment_IX");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.Allocated)
                    .HasColumnName("allocated")
                    .HasComputedColumnSql("([dbo].[inventory_Allocated]([inventory_id]))");

                entity.Property(e => e.Available)
                    .HasColumnName("available")
                    .HasComputedColumnSql("([dbo].[inventory_Available]([inventory_id]))");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Intransit)
                    .HasColumnName("intransit")
                    .HasComputedColumnSql("(case when [shipment_id] IS NULL then (0) else (1) end)");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.InventorystatusId).HasColumnName("inventorystatus_id");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("xml");

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Client");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Entity");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.InventoryregionId)
                    .HasConstraintName("FK__Inventory__inven__1A1EB623");

                entity.HasOne(d => d.Inventorystatus)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.InventorystatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_InventoryStatus");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Lot");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Product");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_Inventory_Shipment");

                entity.HasOne(d => d.Shipmentline)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.ShipmentlineId)
                    .HasConstraintName("FK__Inventory__shipm__7C621EE9");
            });

            modelBuilder.Entity<InventoryRegion>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("InventoryRegion_U")
                    .IsUnique();

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.FactoryDirect)
                    .HasColumnName("factory_direct")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InventoryRegion)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__clien__080005E8");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.InventoryRegion)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Inventory__count__634E6F7D");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.InventoryRegion)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__curre__08F42A21");
            });

            modelBuilder.Entity<InventoryStatus>(entity =>
            {
                entity.HasIndex(e => e.StatusCode)
                    .HasName("InventoryStatus_U")
                    .IsUnique();

                entity.Property(e => e.InventorystatusId).HasColumnName("inventorystatus_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasColumnName("status_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => e.CSeed)
                    .HasName("Invoice_Seed");

                entity.HasIndex(e => e.DivisionId)
                    .HasName("IX_Invoice_Division");

                entity.HasIndex(e => e.EdidocumentId)
                    .HasName("Invoice_EDIDocument_IX");

                entity.HasIndex(e => e.SalespersonId)
                    .HasName("Invoice_SalesPerson_IX");

                entity.HasIndex(e => e.ShipmentId)
                    .HasName("IX_Invoice_Shipment");

                entity.HasIndex(e => new { e.ClientId, e.CreationDate })
                    .HasName("Invoice_CreateDate_IX");

                entity.HasIndex(e => new { e.ClientId, e.InvoiceNo })
                    .HasName("Invoice_U")
                    .IsUnique();

                entity.HasIndex(e => new { e.InvoiceDate, e.ClientId })
                    .HasName("Invoice_InvoiceDate");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.BilltoCliententityId).HasColumnName("billto_cliententity_id");

                entity.Property(e => e.CSeed)
                    .HasColumnName("c_seed")
                    .HasColumnType("numeric(14, 0)")
                    .HasComputedColumnSql("(case when isnumeric(substring([invoice_no],patindex('%[0-9]%',[invoice_no]),(20)))=(1) AND patindex('%[a-Z]%',substring([invoice_no],patindex('%[0-9]%',[invoice_no]),(20)))=(0) then CONVERT([numeric](14),substring([invoice_no],patindex('%[0-9]%',[invoice_no]),(20)),0)  end)");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.DiscountFromWholesale)
                    .HasColumnName("discount_from_wholesale")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.FactorDate)
                    .HasColumnName("factor_date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("invoice_no")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoicetypeId)
                    .HasColumnName("invoicetype_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(100);

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("date");

                entity.Property(e => e.SendTransport).HasColumnName("send_transport");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.Property(e => e.Shipments)
                    .HasColumnName("shipments")
                    .HasColumnType("xml")
                    .HasComputedColumnSql("([dbo].[InvoiceShipments]([invoice_id]))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.HasOne(d => d.BilltoCliententity)
                    .WithMany(p => p.InvoiceBilltoCliententity)
                    .HasForeignKey(d => d.BilltoCliententityId)
                    .HasConstraintName("FK_Invoice_ClientEntity1");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Invoice_Currency");

                entity.HasOne(d => d.Directedi)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.DirectediId)
                    .HasConstraintName("FK_Invoice_DirectEDI");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("d");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__Invoice__edidocu__1B9FEE31");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.InvoiceRemittoCliententity)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .HasConstraintName("FK_Invoice_ClientEntity");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.SalespersonId)
                    .HasConstraintName("FK__Invoice__salespe__4E73CAD6");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_Invoice_Shipment");

                entity.HasOne(d => d.Terms)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.TermsId)
                    .HasConstraintName("FK_Invoice_Terms");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId)
                    .HasName("IX_InvoiceLine_Invoice");

                entity.HasIndex(e => e.OrderlineId)
                    .HasName("IX_InvoiceLine_OrderLine");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_InvoiceLine_Product");

                entity.HasIndex(e => e.ShipmentlineId)
                    .HasName("IX_InvoiceLine_ShipmentLine");

                entity.HasIndex(e => new { e.ClientId, e.InvoiceId, e.Linenumber })
                    .HasName("InvoiceLine_U")
                    .IsUnique();

                entity.Property(e => e.InvoicelineId)
                    .HasColumnName("invoiceline_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(21, 5)")
                    .HasComputedColumnSql("([quantity]*[price])");

                entity.Property(e => e.CMemo)
                    .HasColumnName("c_memo")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[calc_InvoiceLineMemo]([invoiceline_id]))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.InvoicelinetypeId)
                    .HasColumnName("invoicelinetype_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Istaxable).HasColumnName("istaxable");

                entity.Property(e => e.Linenumber).HasColumnName("linenumber");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.Other1)
                    .HasColumnName("other1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10, 3)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.RolalityPercentage)
                    .HasColumnName("rolality_percentage")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLine_Client");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLine_Invoice");

                entity.HasOne(d => d.Invoiceline)
                    .WithOne(p => p.InverseInvoiceline)
                    .HasForeignKey<InvoiceLine>(d => d.InvoicelineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLine_InvoiceLine");

                entity.HasOne(d => d.Orderline)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.OrderlineId)
                    .HasConstraintName("FK_InvoiceLine_OrderLine");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_InvoiceLine_Product");
            });

            modelBuilder.Entity<InvoiceLineType>(entity =>
            {
                entity.HasIndex(e => e.InvoicelinetypeCode)
                    .HasName("IX_invoicelinetype")
                    .IsUnique();

                entity.Property(e => e.InvoicelinetypeId).HasColumnName("invoicelinetype_id");

                entity.Property(e => e.InvoicelinetypeCode)
                    .IsRequired()
                    .HasColumnName("invoicelinetype_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccount)
                    .HasColumnName("qb_account")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccounttype)
                    .HasColumnName("qb_accounttype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("InvoicePayment_Client");

                entity.HasIndex(e => new { e.InvoiceId, e.ActivityDate })
                    .HasName("InvoicePayment_Invoice");

                entity.Property(e => e.InvoicepaymentId).HasColumnName("invoicepayment_id");

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("activity_date")
                    .HasColumnType("date");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(11, 2)");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.PaymentType).HasColumnName("payment_type");

                entity.Property(e => e.QbAccountListid)
                    .HasColumnName("qb_account_listid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNo)
                    .HasColumnName("reference_no")
                    .HasMaxLength(30);

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceSendHistory>(entity =>
            {
                entity.HasIndex(e => new { e.InvoiceId, e.SendDate })
                    .HasName("InvoiceSendHistory_U")
                    .IsUnique();

                entity.Property(e => e.InvoicesendhistoryId).HasColumnName("invoicesendhistory_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Transport).HasColumnName("transport");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceSendHistory)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceSendHistory_Invoice");
            });

            modelBuilder.Entity<IOsapp>(entity =>
            {
                entity.ToTable("iOSApp");

                entity.Property(e => e.IosappId).HasColumnName("iosapp_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ObjectType).HasColumnName("object_type");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SyncDate)
                    .HasColumnName("sync_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<LabelFormat>(entity =>
            {
                entity.HasIndex(e => e.LabelformatCode)
                    .HasName("labelformat_U")
                    .IsUnique();

                entity.Property(e => e.LabelformatId).HasColumnName("labelformat_id");

                entity.Property(e => e.LabelformatCode)
                    .IsRequired()
                    .HasColumnName("labelformat_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lfsobject>(entity =>
            {
                entity.ToTable("LFSObject");

                entity.Property(e => e.LfsobjectId).HasColumnName("lfsobject_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Dto)
                    .HasColumnName("DTO")
                    .HasColumnType("xml");

                entity.Property(e => e.ObjecttypeId).HasColumnName("objecttype_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Lfsobject)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_LFSObject_Client");

                entity.HasOne(d => d.Objecttype)
                    .WithMany(p => p.Lfsobject)
                    .HasForeignKey(d => d.ObjecttypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LFSObject_ObjectType");
            });

            modelBuilder.Entity<Licensor>(entity =>
            {
                entity.Property(e => e.LicensorId).HasColumnName("licensor_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Licensor)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Licensor_Client");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Licensor)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_Licensor_Entity");
            });

            modelBuilder.Entity<Linesheet>(entity =>
            {
                entity.Property(e => e.LinesheetId).HasColumnName("linesheet_id");

                entity.Property(e => e.AutoUpdate)
                    .IsRequired()
                    .HasColumnName("auto_update")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.Linesheet1)
                    .HasColumnName("linesheet")
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Uuid).HasColumnName("uuid");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Linesheet)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Linesheet__brand__544F506B");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Linesheet)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Linesheet__clien__554374A4");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Linesheet)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK__Linesheet__divis__563798DD");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Linesheet)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK__Linesheet__seaso__572BBD16");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("Location_Client_UX");

                entity.HasIndex(e => new { e.EntityId, e.ParentLocationId, e.LocationCode })
                    .HasName("location_U")
                    .IsUnique();

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(20);

                entity.Property(e => e.CDisplay)
                    .HasColumnName("c_display")
                    .HasMaxLength(30)
                    .HasComputedColumnSql("([dbo].[location_code]([location_id],NULL))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("location_code")
                    .HasMaxLength(10);

                entity.Property(e => e.LocationtypeId).HasColumnName("locationtype_id");

                entity.Property(e => e.ParentLocationId).HasColumnName("parent_location_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Location_Client_FK");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Location__entity__6C7E41BC");

                entity.HasOne(d => d.Locationtype)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.LocationtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Location__locati__6D7265F5");

                entity.HasOne(d => d.ParentLocation)
                    .WithMany(p => p.InverseParentLocation)
                    .HasForeignKey(d => d.ParentLocationId)
                    .HasConstraintName("FK__Location__parent__6E668A2E");
            });

            modelBuilder.Entity<LocationAdjustment>(entity =>
            {
                entity.Property(e => e.LocationadjustmentId).HasColumnName("locationadjustment_id");

                entity.Property(e => e.ActivityTime)
                    .HasColumnName("activity_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");
            });

            modelBuilder.Entity<LocationAllocation>(entity =>
            {
                entity.HasIndex(e => new { e.LocationinventoryId, e.ShipmentlineId })
                    .HasName("LocationAllocation_U")
                    .IsUnique();

                entity.Property(e => e.LocationallocationId).HasColumnName("locationallocation_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.LocationinventoryId).HasColumnName("locationinventory_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LocationAllocation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocationA__clien__0574D80F");

                entity.HasOne(d => d.Locationinventory)
                    .WithMany(p => p.LocationAllocation)
                    .HasForeignKey(d => d.LocationinventoryId)
                    .HasConstraintName("FK__LocationA__locat__0668FC48");

                entity.HasOne(d => d.Shipmentline)
                    .WithMany(p => p.LocationAllocation)
                    .HasForeignKey(d => d.ShipmentlineId)
                    .HasConstraintName("FK__LocationA__shipm__075D2081");
            });

            modelBuilder.Entity<LocationInventory>(entity =>
            {
                entity.Property(e => e.LocationinventoryId).HasColumnName("locationinventory_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LocationInventory)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocationI__clien__78E418A1");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.LocationInventory)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocationI__inven__79D83CDA");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationInventory)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LocationI__locat__7ACC6113");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.LocationtypeCode })
                    .HasName("locationtype_U")
                    .IsUnique();

                entity.Property(e => e.LocationtypeId).HasColumnName("locationtype_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.LocationtypeCode)
                    .IsRequired()
                    .HasColumnName("locationtype_code")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LocationType)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__LocationT__clien__64DD1FF4");
            });

            modelBuilder.Entity<LongRunQueries>(entity =>
            {
                entity.HasKey(e => e.RowNumber);

                entity.ToTable("LongRunQueries", "db_owner");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<LongRunQueries2>(entity =>
            {
                entity.HasKey(e => e.RowNumber);

                entity.ToTable("LongRunQueries2", "db_owner");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Lot>(entity =>
            {
                entity.HasIndex(e => new { e.LotCode, e.ClientId })
                    .HasName("Lot_U")
                    .IsUnique();

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.AvailableDate)
                    .HasColumnName("available_date")
                    .HasColumnType("date");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.LotCode)
                    .IsRequired()
                    .HasColumnName("lot_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SalesbranchId).HasColumnName("salesbranch_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Lot)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lot_Client");

                entity.HasOne(d => d.Salesbranch)
                    .WithMany(p => p.Lot)
                    .HasForeignKey(d => d.SalesbranchId)
                    .HasConstraintName("FK_Lot_SalesBranch");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasIndex(e => e.MajorId)
                    .HasName("IX_Major_Entiy_U")
                    .IsUnique();

                entity.Property(e => e.MajorId).HasColumnName("major_id");

                entity.Property(e => e.AsnByComponent)
                    .IsRequired()
                    .HasColumnName("asn_by_component")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AsnPerStore).HasColumnName("asn_per_store");

                entity.Property(e => e.DirectEdiId)
                    .HasColumnName("directEDI_id")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.HasDcs)
                    .IsRequired()
                    .HasColumnName("has_dcs")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HasDepartments)
                    .IsRequired()
                    .HasColumnName("has_departments")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HasRegions)
                    .IsRequired()
                    .HasColumnName("has_regions")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HasStores)
                    .IsRequired()
                    .HasColumnName("has_stores")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InvoiceByComponent).HasColumnName("invoice_by_component");

                entity.Property(e => e.InvoicePerStore)
                    .HasColumnName("invoice_per_store")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LabelformatId).HasColumnName("labelformat_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.OutboundEdiRequires850)
                    .HasColumnName("outboundEDI_requires_850")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rules)
                    .HasColumnName("rules")
                    .HasColumnType("xml");

                entity.Property(e => e.ValidateTrackingnumber)
                    .IsRequired()
                    .HasColumnName("validate_trackingnumber")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Major)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Major__entity_id__1971AF1B");

                entity.HasOne(d => d.Labelformat)
                    .WithMany(p => p.Major)
                    .HasForeignKey(d => d.LabelformatId)
                    .HasConstraintName("FK__Major__labelform__66E0B4D8");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.MaterialId)
                    .HasName("Material_PK")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("Material_U")
                    .IsUnique();

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DimensionId).HasColumnName("dimension_id");

                entity.Property(e => e.Multi).HasColumnName("multi");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.StylecostgroupId).HasColumnName("stylecostgroup_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK15ADC947660AAEFC");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK__Material__curren__3113DBAA");

                entity.HasOne(d => d.Dimension)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.DimensionId)
                    .HasConstraintName("FK__Material__dimens__3207FFE3");

                entity.HasOne(d => d.Stylecostgroup)
                    .WithMany(p => p.Material)
                    .HasForeignKey(d => d.StylecostgroupId)
                    .HasConstraintName("FK__Material__stylec__5A15F13D");
            });

            modelBuilder.Entity<MontisvirAts>(entity =>
            {
                entity.ToTable("MontisvirATS");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_MontisvirATS")
                    .IsUnique();

                entity.Property(e => e.MontisviratsId).HasColumnName("montisvirats_id");

                entity.Property(e => e.Alloc).HasColumnName("alloc");

                entity.Property(e => e.Ats).HasColumnName("ats");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Inprod).HasColumnName("inprod");

                entity.Property(e => e.Instk).HasColumnName("instk");

                entity.Property(e => e.Intrans).HasColumnName("intrans");

                entity.Property(e => e.Open).HasColumnName("open");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Xfact).HasColumnName("xfact");
            });

            modelBuilder.Entity<MontisvirBrand>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.DivisionCode, e.BrandId });

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("division_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("brand_id");
            });

            modelBuilder.Entity<MontisvirCancelCode>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.CancelCode });

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CancelCode)
                    .HasColumnName("cancel_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OrderreasonId).HasColumnName("orderreason_id");
            });

            modelBuilder.Entity<MontisvirDivision>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.DivisionCode, e.DivisionId });

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("division_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionId).HasColumnName("division_id");
            });

            modelBuilder.Entity<MontisvirEntity>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.MontisvirCode })
                    .HasName("MontisvirEntity_U")
                    .IsUnique();

                entity.Property(e => e.MontisvirentityId).HasColumnName("montisvirentity_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientXref)
                    .HasColumnName("client_xref")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.MontisvirCode)
                    .HasColumnName("montisvir_code")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.MontisvirSearchkey)
                    .HasColumnName("montisvir_searchkey")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.MontisvirEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MontisvirEntity_Entity");
            });

            modelBuilder.Entity<MontisvirLineStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MontisvirLocation>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.EntityId, e.LocationCode, e.ProductId, e.LotId, e.InventorystatusId })
                    .HasName("MontisvirLocation_U")
                    .IsUnique();

                entity.Property(e => e.MontisvirlocationId).HasColumnName("montisvirlocation_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.InventorystatusId).HasColumnName("inventorystatus_id");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("location_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MontisvirLocation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MontisvirLocation_Client");

                entity.HasOne(d => d.Inventorystatus)
                    .WithMany(p => p.MontisvirLocation)
                    .HasForeignKey(d => d.InventorystatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MontisvirLocation_Status");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.MontisvirLocation)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MontisvirLocation_Lot");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MontisvirLocation)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MontisvirLocation_Product");
            });

            modelBuilder.Entity<MontisvirOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.OrderNbr, e.LineNbr, e.SubLine, e.Element });

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.OrderNbr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubLine)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CancelCode)
                    .HasColumnName("cancel_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateChanged).HasColumnType("date");

                entity.Property(e => e.DateEntered).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.Price).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MontisvirOrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nmfc>(entity =>
            {
                entity.ToTable("nmfc");

                entity.Property(e => e.NmfcId).HasColumnName("nmfc_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(80);

                entity.Property(e => e.NmfcClass)
                    .HasColumnName("nmfc_class")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NmfcCode)
                    .HasColumnName("nmfc_code")
                    .HasMaxLength(6);

                entity.Property(e => e.NmfcSubclass)
                    .HasColumnName("nmfc_subclass")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.HasIndex(e => new { e.Id, e.Note1, e.Objecttype })
                    .HasName("Note_ObjectType_IX");

                entity.HasIndex(e => new { e.Objecttype, e.Note1, e.Id })
                    .HasName("Note_Object_IX");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.Attributes)
                    .HasColumnName("attributes")
                    .HasColumnType("xml");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note1)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Objecttype)
                    .IsRequired()
                    .HasColumnName("objecttype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Note)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Note__client_id__526E08CB");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.Property(e => e.NotificationtypeId).HasColumnName("notificationtype_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType1).HasColumnName("notification_type");
            });

            modelBuilder.Entity<Numbers>(entity =>
            {
                entity.HasKey(e => e.Number);

                entity.Property(e => e.Number).ValueGeneratedNever();
            });

            modelBuilder.Entity<ObjectType>(entity =>
            {
                entity.Property(e => e.ObjecttypeId).HasColumnName("objecttype_id");

                entity.Property(e => e.AttributeConfiguration)
                    .HasColumnName("attribute_configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.ObjecttypeName)
                    .IsRequired()
                    .HasColumnName("objecttype_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentObjecttypeId).HasColumnName("parent_objecttype_id");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentObjecttype)
                    .WithMany(p => p.InverseParentObjecttype)
                    .HasForeignKey(d => d.ParentObjecttypeId)
                    .HasConstraintName("FK_ObjectType_ObjectType");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OptionCode)
                    .IsRequired()
                    .HasColumnName("option_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("Order_Brand_IX");

                entity.HasIndex(e => e.CSeed)
                    .HasName("Order_Seed");

                entity.HasIndex(e => e.ConsumerDocumentReference)
                    .HasName("Order_DocumentReference_IX")
                    .HasFilter("([ConsumerDocumentReference] IS NOT NULL)");

                entity.HasIndex(e => e.DirectediId)
                    .HasName("IX_Order_DirectEDI");

                entity.HasIndex(e => e.EdidocumentId)
                    .HasName("Shipment_EDIDocument_IX");

                entity.HasIndex(e => e.PoId)
                    .HasName("IX_Order_PO")
                    .HasFilter("([po_id] IS NOT NULL)");

                entity.HasIndex(e => e.PurchaseorderId)
                    .HasName("IX_PurchaseOrder_ID");

                entity.HasIndex(e => e.SeasonId)
                    .HasName("Order_Season_IX");

                entity.HasIndex(e => new { e.ClientId, e.EndDate })
                    .HasName("Order_EndDate");

                entity.HasIndex(e => new { e.ClientId, e.StartDate })
                    .HasName("Order_StartDate");

                entity.HasIndex(e => new { e.OrderNo, e.ClientId })
                    .HasName("Order_U")
                    .IsUnique();

                entity.HasIndex(e => new { e.PoNumber, e.ClientId, e.BilltoCliententityId })
                    .HasName("IX_PONumber");

                entity.HasIndex(e => new { e.OrderId, e.OrdertypeId, e.OrderstatusId, e.PoId })
                    .HasName("Order_PO_IX");

                entity.HasIndex(e => new { e.OrderId, e.OrdertypeId, e.BilltoCliententityId, e.TermsId, e.SeasonId, e.DivisionId, e.OrderstatusId })
                    .HasName("Order_OrderStatus_IX");

                entity.HasIndex(e => new { e.OrderId, e.StartDate, e.EndDate, e.LotId, e.ClientId, e.OrdertypeId, e.OrderstatusId })
                    .HasName("Order_ClientTypeStatus");

                entity.HasIndex(e => new { e.OrderId, e.BilltoCliententityId, e.DivisionId, e.DropShip, e.FcCommission, e.FactoryOrderId, e.IsFirstcost, e.ClientId, e.OrdertypeId, e.StartDate, e.EndDate })
                    .HasName("Order_GM_IX");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AcknowledgedDate)
                    .HasColumnName("acknowledged_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Backup)
                    .HasColumnName("backup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BilltoCliententityId).HasColumnName("billto_cliententity_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.Bulk)
                    .HasColumnName("bulk")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CBrandId)
                    .HasColumnName("c_brand_id")
                    .HasComputedColumnSql("([dbo].[order_GetBrand]([order_id]))");

                entity.Property(e => e.CEndDate)
                    .HasColumnName("c_end_date")
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[end_date],0))");

                entity.Property(e => e.CSeasonId)
                    .HasColumnName("c_season_id")
                    .HasComputedColumnSql("([dbo].[order_GetSeason]([order_id]))");

                entity.Property(e => e.CSeed)
                    .HasColumnName("c_seed")
                    .HasColumnType("numeric(14, 0)")
                    .HasComputedColumnSql("(case when isnumeric(substring([order_no],patindex('%[0-9]%',[order_no]),(20)))=(1) AND patindex('%[a-Z]%',substring([order_no],patindex('%[0-9]%',[order_no]),(20)))=(0) then CONVERT([numeric](14),substring([order_no],patindex('%[0-9]%',[order_no]),(20)),0)  end)");

                entity.Property(e => e.CStartDate)
                    .HasColumnName("c_start_date")
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[start_date],0))");

                entity.Property(e => e.CarrierserviceId).HasColumnName("carrierservice_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Consignment).HasColumnName("consignment");

                entity.Property(e => e.ConsolidatorCliententityId).HasColumnName("consolidator_cliententity_id");

                entity.Property(e => e.ConsumerDocumentReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DcCliententityId).HasColumnName("dc_cliententity_id");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(10);

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.DropShip)
                    .HasColumnName("drop_ship")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EdiDepartment)
                    .HasColumnName("edi_department")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[EDI_Department]([directedi_id]))");

                entity.Property(e => e.EdiEndDateType)
                    .HasColumnName("edi_end_date_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdiStartDateType)
                    .HasColumnName("edi_start_date_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdiVendor)
                    .HasColumnName("edi_vendor")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[EDI_Vendor]([directedi_id],[edidocument_id]))");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtensionDate)
                    .HasColumnName("extension_date")
                    .HasColumnType("date");

                entity.Property(e => e.FactoryDirect)
                    .HasColumnName("factory_direct")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FactoryOrderId).HasColumnName("factory_order_id");

                entity.Property(e => e.FcCommission)
                    .HasColumnName("FC_commission")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.FcTermsId).HasColumnName("FC_terms_id");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.InventorystatusId).HasColumnName("inventorystatus_id");

                entity.Property(e => e.IsFirstcost).HasColumnName("is_firstcost");

                entity.Property(e => e.IsReplenishment).HasColumnName("is_replenishment");

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("order_no")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderstatusId).HasColumnName("orderstatus_id");

                entity.Property(e => e.OrdertypeId).HasColumnName("ordertype_id");

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentOrderId).HasColumnName("parent_order_id");

                entity.Property(e => e.PoId).HasColumnName("po_id");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(30);

                entity.Property(e => e.PurchaseorderId)
                    .HasColumnName("purchaseorder_id")
                    .HasComputedColumnSql("(checksum([client_id],[billto_cliententity_id],[directedi_id],[orderstatus_id],[start_date],[end_date],[po_number]))");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo1)
                    .HasColumnName("reference_no1")
                    .HasMaxLength(30);

                entity.Property(e => e.ReferenceNo2)
                    .HasColumnName("reference_no2")
                    .HasMaxLength(30);

                entity.Property(e => e.ReferenceNo3)
                    .HasColumnName("reference_no3")
                    .HasMaxLength(50);

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SalespersonId)
                    .HasColumnName("salesperson_id")
                    .HasComputedColumnSql("([dbo].[order_Salesperson]([order_id]))");

                entity.Property(e => e.Sample)
                    .HasColumnName("sample")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipfromCliententityId).HasColumnName("shipfrom_cliententity_id");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("shipping_charge")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ShiptoCliententityId).HasColumnName("shipto_cliententity_id");

                entity.Property(e => e.ShipviaId).HasColumnName("shipvia_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.Property(e => e.Uuid).HasColumnName("uuid");

                entity.HasOne(d => d.BilltoCliententity)
                    .WithMany(p => p.OrderBilltoCliententity)
                    .HasForeignKey(d => d.BilltoCliententityId)
                    .HasConstraintName("FK__Order__billto_cl__6ABCBFB4");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Order__brand_id__1DE39B45");

                entity.HasOne(d => d.Carrierservice)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CarrierserviceId)
                    .HasConstraintName("FK_order_carrierservicelevel");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Client");

                entity.HasOne(d => d.ConsolidatorCliententity)
                    .WithMany(p => p.OrderConsolidatorCliententity)
                    .HasForeignKey(d => d.ConsolidatorCliententityId)
                    .HasConstraintName("FK__Order__consolida__3934EBB6");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_order_Currency");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__Order__edidocume__499BC30B");

                entity.HasOne(d => d.FactoryOrder)
                    .WithMany(p => p.InverseFactoryOrder)
                    .HasForeignKey(d => d.FactoryOrderId)
                    .HasConstraintName("FK_Order_Order1");

                entity.HasOne(d => d.FcTerms)
                    .WithMany(p => p.OrderFcTerms)
                    .HasForeignKey(d => d.FcTermsId)
                    .HasConstraintName("FK__Order__FC_terms___0FAC2564");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.InventoryregionId)
                    .HasConstraintName("FK__Order__inventory__1B12DA5C");

                entity.HasOne(d => d.Inventorystatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.InventorystatusId)
                    .HasConstraintName("FK__Order__inventory__79DC1CDD");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.LotId)
                    .HasConstraintName("FK__Order__lot_id__2E996452");

                entity.HasOne(d => d.Orderstatus)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrderstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderStatus");

                entity.HasOne(d => d.Ordertype)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.OrdertypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_OrderType");

                entity.HasOne(d => d.ParentOrder)
                    .WithMany(p => p.InverseParentOrder)
                    .HasForeignKey(d => d.ParentOrderId)
                    .HasConstraintName("FK_Order_Order");

                entity.HasOne(d => d.Po)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.PoId)
                    .HasConstraintName("FK__Order__po_id__2B344CA6");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.OrderRemittoCliententity)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .HasConstraintName("FK_Order_ClientEntity_Remit");

                entity.HasOne(d => d.Terms)
                    .WithMany(p => p.OrderTerms)
                    .HasForeignKey(d => d.TermsId)
                    .HasConstraintName("FK_Order_Terms");
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.HasIndex(e => e.ConsumerDocumentReference)
                    .HasName("OrderLine_DocumentReference_IX")
                    .HasFilter("([ConsumerDocumentReference] IS NOT NULL)");

                entity.HasIndex(e => e.FactoryOrderlineId)
                    .HasName("OrderLine_Orderline2_IX")
                    .HasFilter("([factory_orderline_id] IS NOT NULL)");

                entity.HasIndex(e => e.ParentOrderlineId)
                    .HasName("Orderline_Parent_IX");

                entity.HasIndex(e => new { e.ProductId, e.InventorystatusId, e.LotId })
                    .HasName("IX_OrderLine");

                entity.HasIndex(e => new { e.OrderId, e.ProductId, e.InventorystatusId, e.LotId })
                    .HasName("orderline_product_U")
                    .IsUnique()
                    .HasFilter("([order_id]>(169673))");

                entity.HasIndex(e => new { e.OrderId, e.ProductId, e.LineNumber, e.QuantityOrdered })
                    .HasName("OrderLine_LineNumber");

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ConsumerDocumentReference)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Destination).HasColumnName("destination");

                entity.Property(e => e.Edixml)
                    .HasColumnName("EDIXML")
                    .HasColumnType("xml");

                entity.Property(e => e.ExtendedPrice)
                    .HasColumnName("extended_price")
                    .HasColumnType("numeric(18, 2)")
                    .HasComputedColumnSql("([quantity_ordered]*[price])");

                entity.Property(e => e.FactoryOrderlineId).HasColumnName("factory_orderline_id");

                entity.Property(e => e.FactoryPrice)
                    .HasColumnName("factory_price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.InventorystatusId)
                    .HasColumnName("inventorystatus_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LineNumber)
                    .HasColumnName("line_number")
                    .HasMaxLength(5);

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PackQuantity).HasColumnName("pack_quantity");

                entity.Property(e => e.ParentOrderlineId).HasColumnName("parent_orderline_id");

                entity.Property(e => e.PerSizePricing).HasColumnName("per_size_pricing");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(7, 2)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductaliasId).HasColumnName("productalias_id");

                entity.Property(e => e.QuantityAllocated).HasColumnName("quantity_allocated");

                entity.Property(e => e.QuantityCanceled)
                    .HasColumnName("quantity_canceled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityIntransit).HasColumnName("quantity_intransit");

                entity.Property(e => e.QuantityMto)
                    .HasColumnName("quantity_MTO")
                    .HasComputedColumnSql("([dbo].[calc_QuantityMTO]([orderline_id]))");

                entity.Property(e => e.QuantityOpen)
                    .HasColumnName("quantity_open")
                    .HasComputedColumnSql("([dbo].[calc_QuantityOpen]([orderline_id]))");

                entity.Property(e => e.QuantityOrdered).HasColumnName("quantity_ordered");

                entity.Property(e => e.QuantityReceived).HasColumnName("quantity_received");

                entity.Property(e => e.QuantityShipped).HasColumnName("quantity_shipped");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("retail_price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(30);

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.Tax1)
                    .HasColumnName("tax1")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tax2)
                    .HasColumnName("tax2")
                    .HasColumnType("numeric(10, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLine_Client");

                entity.HasOne(d => d.FactoryOrderline)
                    .WithMany(p => p.InverseFactoryOrderline)
                    .HasForeignKey(d => d.FactoryOrderlineId)
                    .HasConstraintName("FK__OrderLine__facto__1EBB4C7F");

                entity.HasOne(d => d.Inventorystatus)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.InventorystatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLine_InventoryStatus");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLine_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLine_Product");

                entity.HasOne(d => d.Productalias)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ProductaliasId)
                    .HasConstraintName("FK__OrderLine__produ__547456BB");
            });

            modelBuilder.Entity<OrderLineHistory>(entity =>
            {
                entity.HasKey(e => e.OrderlinerhistoryId);

                entity.HasIndex(e => e.OrderlineId)
                    .HasName("IX_OrderLineHistory_OrderLine");

                entity.HasIndex(e => new { e.DateOnly, e.ClientId })
                    .HasName("IX_OrderLineHistory_date");

                entity.HasIndex(e => new { e.ReferenceId, e.ReferenceType })
                    .HasName("IXorderlinehistory_reference");

                entity.Property(e => e.OrderlinerhistoryId).HasColumnName("orderlinerhistory_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOnly)
                    .HasColumnName("date_only")
                    .HasColumnType("date")
                    .HasComputedColumnSql("(CONVERT([date],[date],0))");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.OrderreasonId).HasColumnName("orderreason_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceType).HasColumnName("reference_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderLineHistory)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLineReason_Client");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.OrderLineHistory)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__OrderLine__edido__1600E77E");

                entity.HasOne(d => d.Orderline)
                    .WithMany(p => p.OrderLineHistory)
                    .HasForeignKey(d => d.OrderlineId)
                    .HasConstraintName("FK_OrderLineReason_OrderLine");

                entity.HasOne(d => d.Orderreason)
                    .WithMany(p => p.OrderLineHistory)
                    .HasForeignKey(d => d.OrderreasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLineReason_OrderReason");
            });

            modelBuilder.Entity<OrderReason>(entity =>
            {
                entity.Property(e => e.OrderreasonId).HasColumnName("orderreason_id");

                entity.Property(e => e.Decrease).HasColumnName("decrease");

                entity.Property(e => e.Increase).HasColumnName("increase");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.System).HasColumnName("system");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.OrderstatusId).HasColumnName("orderstatus_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasColumnName("status_code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.HasIndex(e => e.OrdertypeCode)
                    .HasName("OrderType_U")
                    .IsUnique();

                entity.Property(e => e.OrdertypeId).HasColumnName("ordertype_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Group).HasColumnName("group");

                entity.Property(e => e.OrderPrefix)
                    .HasColumnName("order_prefix")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrdertypeCode)
                    .IsRequired()
                    .HasColumnName("ordertype_code")
                    .HasMaxLength(12);

                entity.Property(e => e.PriyaCode)
                    .HasColumnName("priya_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcProducts>(entity =>
            {
                entity.HasKey(e => e.PcProductId);

                entity.ToTable("pc_products");

                entity.HasIndex(e => e.ProductId)
                    .HasName("pc_products_u")
                    .IsUnique();

                entity.Property(e => e.PcProductId).HasColumnName("pc_product_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("last_updated_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcItemId).HasColumnName("pc_item_id");

                entity.Property(e => e.PcStyleId).HasColumnName("pc_style_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");
            });

            modelBuilder.Entity<PcStylecolors>(entity =>
            {
                entity.ToTable("pc_stylecolors");

                entity.Property(e => e.PcStylecolorsId).HasColumnName("pc_stylecolors_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.PcOptionId).HasColumnName("pc_option_id");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");
            });

            modelBuilder.Entity<PcStyles>(entity =>
            {
                entity.HasKey(e => e.PcStyleId);

                entity.ToTable("pc_styles");

                entity.Property(e => e.PcStyleId).HasColumnName("pc_style_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.PcItemId).HasColumnName("pc_item_id");

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StyleId).HasColumnName("style_id");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permissio__actio__64A5B3C5");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlanCode)
                    .IsRequired()
                    .HasColumnName("plan_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrialPeriod).HasColumnName("trial_period");
            });

            modelBuilder.Entity<PlanOption>(entity =>
            {
                entity.Property(e => e.PlanoptionId).HasColumnName("planoption_id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Price2)
                    .HasColumnName("price2")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.QuantityType)
                    .HasColumnName("quantity_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Setup)
                    .HasColumnName("setup")
                    .HasColumnType("numeric(6, 2)");

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.PlanOption)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanOption_Option");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanOption)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanOption_plan");
            });

            modelBuilder.Entity<PlanPricing>(entity =>
            {
                entity.Property(e => e.PlanpricingId).HasColumnName("planpricing_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.PlanoptionId).HasColumnName("planoption_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PlanPricing)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_PlanPricing_Client");

                entity.HasOne(d => d.Planoption)
                    .WithMany(p => p.PlanPricing)
                    .HasForeignKey(d => d.PlanoptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanPricing_PlanOption");
            });

            modelBuilder.Entity<Po>(entity =>
            {
                entity.ToTable("po");

                entity.Property(e => e.PoId).HasColumnName("po_id");

                entity.Property(e => e.BilltoCliententityId).HasColumnName("billto_cliententity_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ConsolidatorCliententityId).HasColumnName("consolidator_cliententity_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.OrderstatusId).HasColumnName("orderstatus_id");

                entity.Property(e => e.OrdertypeId).HasColumnName("ordertype_id");

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(30);

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.ShipviaId).HasColumnName("shipvia_id");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.HasOne(d => d.BilltoCliententity)
                    .WithMany(p => p.PoBilltoCliententity)
                    .HasForeignKey(d => d.BilltoCliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__po__billto_clien__294C0434");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_po_Brand");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__po__client_id__2857DFFB");

                entity.HasOne(d => d.ConsolidatorCliententity)
                    .WithMany(p => p.PoConsolidatorCliententity)
                    .HasForeignKey(d => d.ConsolidatorCliententityId)
                    .HasConstraintName("FK__po__consolidator__1C0E9D23");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_po_Currency");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_po_Department");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_po_Division");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.LotId)
                    .HasConstraintName("FK_po_Lot");

                entity.HasOne(d => d.Orderstatus)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.OrderstatusId)
                    .HasConstraintName("FK_PO_OrderStatus");

                entity.HasOne(d => d.Ordertype)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.OrdertypeId)
                    .HasConstraintName("FK__po__ordertype_id__6D9E2A91");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.PoRemittoCliententity)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__po__remitto_clie__2A40286D");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.SalespersonId)
                    .HasConstraintName("FK_po_Salesperson");

                entity.HasOne(d => d.Shipvia)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.ShipviaId)
                    .HasConstraintName("FK_po_ShipVia");

                entity.HasOne(d => d.Terms)
                    .WithMany(p => p.Po)
                    .HasForeignKey(d => d.TermsId)
                    .HasConstraintName("FK_po_Terms");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.PriceId).HasColumnName("price_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Price)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Price_Currency");
            });

            modelBuilder.Entity<Priya>(entity =>
            {
                entity.Property(e => e.PriyaId).HasColumnName("priya_id");

                entity.Property(e => e.Database)
                    .HasColumnName("database")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Endversion)
                    .HasColumnName("endversion")
                    .HasMaxLength(8);

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.ExportType)
                    .HasColumnName("export_type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .HasColumnName("server")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Startversion)
                    .HasColumnName("startversion")
                    .HasMaxLength(8);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Gtin)
                    .HasName("Product_GTIN");

                entity.HasIndex(e => e.Rowversion)
                    .HasName("Product_V");

                entity.HasIndex(e => e.SizeId)
                    .HasName("IX_Product_Size");

                entity.HasIndex(e => e.Sku)
                    .HasName("Product_SKU_IX")
                    .HasFilter("([sku] IS NOT NULL)");

                entity.HasIndex(e => e.Upc)
                    .HasName("Product_upc");

                entity.HasIndex(e => new { e.StylecolorId, e.SizeId })
                    .HasName("IX_Product_StyleColor");

                entity.HasIndex(e => new { e.UpcblockId, e.ItemReference })
                    .HasName("Product_UPCSequence");

                entity.HasIndex(e => new { e.Gtin, e.ClientId, e.InactiveDate })
                    .HasName("Product_U2")
                    .IsUnique()
                    .HasFilter("([company_prefix] IS NOT NULL AND [item_reference] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClientId, e.StylecolorId, e.SizeId, e.PackageLevel })
                    .HasName("Product_U")
                    .IsUnique();

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasComputedColumnSql("(case when [inactive_date] IS NULL then (1) else (0) end)");

                entity.Property(e => e.AvgWeeklySales).HasColumnName("avg_weekly_sales");

                entity.Property(e => e.CDescription)
                    .HasColumnName("c_description")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[calc_ProductDescription]([stylecolor_id],[size_id],[package_level]))");

                entity.Property(e => e.CPack)
                    .HasColumnName("c_pack")
                    .HasComputedColumnSql("([dbo].[calc_Pack]([product_id]))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CompanyPrefix)
                    .HasColumnName("company_prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Ean13)
                    .HasColumnName("ean13")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[calc_GTIN13]([company_prefix],[item_reference]))");

                entity.Property(e => e.Gtin)
                    .HasColumnName("gtin")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[calc_GTIN14]([company_prefix],[item_reference],[package_level]))");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsAssortment)
                    .HasColumnName("is_assortment")
                    .HasComputedColumnSql("([dbo].[product_IsAssortment]([product_id]))");

                entity.Property(e => e.IsCasepack)
                    .HasColumnName("is_casepack")
                    .HasComputedColumnSql("([dbo].[size_IsCasePack]([size_id]))");

                entity.Property(e => e.IsSolidpack)
                    .HasColumnName("is_solidpack")
                    .HasComputedColumnSql("(case when [package_level]>(0) then (1) else (0) end)");

                entity.Property(e => e.ItemReference).HasColumnName("item_reference");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.MaxReplenishmentLevel).HasColumnName("max_replenishment_level");

                entity.Property(e => e.MinReplenishmentLevel).HasColumnName("min_replenishment_level");

                entity.Property(e => e.Pack)
                    .HasColumnName("pack")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackageLevel).HasColumnName("package_level");

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(30);

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.Upc)
                    .HasColumnName("upc")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[calc_UPC]([company_prefix],[item_reference]))");

                entity.Property(e => e.UpcblockId).HasColumnName("upcblock_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Product_Client");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Size");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.StylecolorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_StyleColor");

                entity.HasOne(d => d.Upcblock)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.UpcblockId)
                    .HasConstraintName("FK_Product_UPCBlock");
            });

            modelBuilder.Entity<ProductAlias>(entity =>
            {
                entity.HasIndex(e => e.Checksum)
                    .HasName("productalias_checksum_IX");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IXproductalias_client");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IXproductalias_product");

                entity.HasIndex(e => new { e.ProductaliasType, e.EntityId, e.ProductId })
                    .HasName("productalias_U")
                    .IsUnique();

                entity.Property(e => e.ProductaliasId).HasColumnName("productalias_id");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasColumnType("xml");

                entity.Property(e => e.Checksum)
                    .HasColumnName("checksum")
                    .HasComputedColumnSql("(checksum(CONVERT([varchar](max),[alias],0)))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnName("expected_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpectedQuantity).HasColumnName("expected_quantity");

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.InventoryDate)
                    .HasColumnName("inventory_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InventoryLevel).HasColumnName("inventory_level");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Productalias1)
                    .IsRequired()
                    .HasColumnName("productalias")
                    .HasMaxLength(8000);

                entity.Property(e => e.ProductaliasType).HasColumnName("productalias_type");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ProductAlias)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK__ProductAl__curre__7C0A1D9C");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ProductAlias)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK__ProductAl__entit__57F46FF5");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAlias)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductAl__produ__4B41EC7E");
            });

            modelBuilder.Entity<ProductCart>(entity =>
            {
                entity.Property(e => e.ProductcartId).HasColumnName("productcart_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Endpoint)
                    .HasColumnName("ENDPOINT")
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId)
                    .HasColumnName("PartnerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCatalogue>(entity =>
            {
                entity.Property(e => e.ProductcatalogueId).HasColumnName("productcatalogue_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CatalogueId).HasColumnName("catalogue_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Catalogue)
                    .WithMany(p => p.ProductCatalogue)
                    .HasForeignKey(d => d.CatalogueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCatalogue_Catalogue");
            });

            modelBuilder.Entity<Producttype>(entity =>
            {
                entity.ToTable("producttype");

                entity.Property(e => e.ProducttypeId).HasColumnName("producttype_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ParentProducttypeId).HasColumnName("parent_producttype_id");

                entity.Property(e => e.PricePoints)
                    .HasColumnName("price_points")
                    .HasColumnType("numeric(5, 3)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Producttype)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__productty__clien__5148C68E");

                entity.HasOne(d => d.ParentProducttype)
                    .WithMany(p => p.InverseParentProducttype)
                    .HasForeignKey(d => d.ParentProducttypeId)
                    .HasConstraintName("FK__productty__paren__5EBA324A");
            });

            modelBuilder.Entity<Qbaccount>(entity =>
            {
                entity.ToTable("QBAccount");

                entity.HasIndex(e => new { e.ClientId, e.InvoicelinetypeId })
                    .HasName("IX_QBAccount")
                    .IsUnique();

                entity.Property(e => e.QbaccountId).HasColumnName("qbaccount_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoicelinetypeId).HasColumnName("invoicelinetype_id");

                entity.Property(e => e.QbAccount1)
                    .IsRequired()
                    .HasColumnName("qb_account")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QbAccounttype)
                    .IsRequired()
                    .HasColumnName("qb_accounttype")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbAccounts>(entity =>
            {
                entity.ToTable("qb_accounts");

                entity.Property(e => e.QbAccountsId).HasColumnName("qb_accounts_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CurrencyListid)
                    .HasColumnName("currency_listid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyName)
                    .HasColumnName("currency_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<Qbc>(entity =>
            {
                entity.ToTable("QBC");

                entity.Property(e => e.QbcId).HasColumnName("QBC_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.QbVersionId).HasColumnName("qb_version_id");

                entity.Property(e => e.SubscriptionDate)
                    .HasColumnName("subscription date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseInventoryItems).HasColumnName("use_inventory_items");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<QbClasses>(entity =>
            {
                entity.ToTable("qb_Classes");

                entity.Property(e => e.QbClassesId).HasColumnName("qb_Classes_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Item).HasColumnType("xml");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbCredits>(entity =>
            {
                entity.ToTable("qb_Credits");

                entity.Property(e => e.QbCreditsId).HasColumnName("qb_credits_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreditRemaining).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Item).HasColumnType("xml");

                entity.Property(e => e.RefNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbCurrency>(entity =>
            {
                entity.ToTable("qb_Currency");

                entity.Property(e => e.QbCurrencyId).HasColumnName("qb_currency_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.QbCurrency)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_qb_Currency_Client");

                entity.HasOne(d => d.Qbc)
                    .WithMany(p => p.QbCurrency)
                    .HasForeignKey(d => d.QbcId)
                    .HasConstraintName("FK_qb_Currency_QBC");
            });

            modelBuilder.Entity<QbCustomers>(entity =>
            {
                entity.HasKey(e => e.QbCustomerId);

                entity.ToTable("qb_customers");

                entity.Property(e => e.QbCustomerId).HasColumnName("qb_customer_id");

                entity.Property(e => e.AliasId).HasColumnName("alias_id");

                entity.Property(e => e.AliasType).HasColumnName("alias_type");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbRequestId).HasColumnName("qb_request_id");

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.QbwcId).HasColumnName("qbwc_id");
            });

            modelBuilder.Entity<QbDiscountItems>(entity =>
            {
                entity.ToTable("qb_DiscountItems");

                entity.Property(e => e.QbDiscountItemsId).HasColumnName("qb_DiscountItems_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QbInvoices>(entity =>
            {
                entity.ToTable("qb_invoices");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("qb_invoices_invoice_IX");

                entity.Property(e => e.QbInvoicesId).HasColumnName("qb_invoices_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.LatestQbwcId).HasColumnName("latest_qbwc_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.QbRequestId).HasColumnName("qb_request_id");

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.QbwcId).HasColumnName("qbwc_id");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TxnId)
                    .HasColumnName("TxnID")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbItem>(entity =>
            {
                entity.ToTable("qb_Item");

                entity.Property(e => e.QbItemId)
                    .HasColumnName("qb_item_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvoicelinetypeId).HasColumnName("invoicelinetype_id");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasColumnName("item")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.QbItemNavigation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_qb_Item_Client");

                entity.HasOne(d => d.QbItemNavigation)
                    .WithOne(p => p.QbItem)
                    .HasForeignKey<QbItem>(d => d.QbItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_qb_Item_invoicelinetype");
            });

            modelBuilder.Entity<QbItems>(entity =>
            {
                entity.ToTable("qb_items");

                entity.HasIndex(e => new { e.AliasId, e.QbItemsTypeId })
                    .HasName("qb_items_U")
                    .IsUnique();

                entity.Property(e => e.QbItemsId).HasColumnName("qb_items_id");

                entity.Property(e => e.AliasId).HasColumnName("alias_id");

                entity.Property(e => e.AliasType).HasColumnName("alias_type");

                entity.Property(e => e.LatestQbwcId).HasColumnName("latest_qbwc_id");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbItemsTypeId)
                    .HasColumnName("qb_ItemsType_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QbRequestId).HasColumnName("qb_request_id");

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.QbwcId).HasColumnName("qbwc_id");

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<QbItemsType>(entity =>
            {
                entity.ToTable("qb_ItemsType");

                entity.Property(e => e.QbItemsTypeId).HasColumnName("qb_ItemsType_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbNonInventoryItems>(entity =>
            {
                entity.ToTable("qb_NonInventoryItems");

                entity.Property(e => e.QbNonInventoryItemsId).HasColumnName("qb_NonInventoryItems_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Item).HasColumnType("xml");

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbOtherChargeItems>(entity =>
            {
                entity.ToTable("qb_OtherChargeItems");

                entity.Property(e => e.QbOtherChargeItemsId).HasColumnName("qb_OtherChargeItems_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("list_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QbRequest>(entity =>
            {
                entity.HasKey(e => e.QbRequestLineId);

                entity.ToTable("qb_request");

                entity.Property(e => e.QbRequestLineId).HasColumnName("qb_request_line_id");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.QbListId)
                    .HasColumnName("qb_list_id")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.QbSequenceId)
                    .HasColumnName("qb_sequence_id")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QbwcId).HasColumnName("qbwc_id");

                entity.Property(e => e.Request)
                    .HasColumnName("request")
                    .HasColumnType("xml");

                entity.Property(e => e.Response)
                    .HasColumnName("response")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<QbRequestType>(entity =>
            {
                entity.ToTable("qb_RequestType");

                entity.Property(e => e.QbRequestTypeId).HasColumnName("qb_RequestType_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QbSalesrep>(entity =>
            {
                entity.ToTable("qb_salesrep");

                entity.Property(e => e.QbSalesrepId).HasColumnName("qb_salesrep_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Initial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListId)
                    .HasColumnName("ListID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.SalesRepEntityRef).HasColumnType("xml");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<QbTerms>(entity =>
            {
                entity.ToTable("qb_terms");

                entity.Property(e => e.QbTermsId).HasColumnName("qb_terms_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DiscountPct).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ListId)
                    .HasColumnName("ListID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbcId).HasColumnName("qbc_id");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<QbVersion>(entity =>
            {
                entity.ToTable("qb_version");

                entity.Property(e => e.QbVersionId).HasColumnName("qb_version_id");

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qbwc>(entity =>
            {
                entity.ToTable("QBWC");

                entity.Property(e => e.QbwcId).HasColumnName("QBWC_id");

                entity.Property(e => e.Acknowledged).HasColumnName("acknowledged");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.AliasId).HasColumnName("alias_id");

                entity.Property(e => e.AliasType).HasColumnName("alias_type");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.IsNew).HasColumnName("is_new");

                entity.Property(e => e.QbRequestTypeId)
                    .HasColumnName("qb_RequestType_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QbaliasId)
                    .HasColumnName("QBalias_Id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Request)
                    .HasColumnName("request")
                    .HasColumnType("xml");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("request_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .HasColumnName("response")
                    .HasColumnType("xml");

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("response_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Ticket)
                    .HasColumnName("ticket")
                    .IsUnicode(false);

                entity.Property(e => e.TrandingpartnerId).HasColumnName("trandingpartner_id");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.Qbwc)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__QBWC__edidocumen__224620E7");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.RegionCode })
                    .HasName("IX_Region_U")
                    .IsUnique();

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Group)
                    .HasColumnName("group")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasColumnName("region_code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleName)
                    .HasName("role_U")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(30);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Role__client_id__78ACAC72");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.Property(e => e.RolepermissionId).HasColumnName("rolepermission_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolePermi__permi__3A256A14");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolePermi__role___3B198E4D");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.RoutetypeId).HasColumnName("routetype_id");

                entity.Property(e => e.TruckNumber)
                    .HasColumnName("truck_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VesselNumber)
                    .HasColumnName("vessel_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Route)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Route_Client");
            });

            modelBuilder.Entity<SalesBranch>(entity =>
            {
                entity.Property(e => e.SalesbranchId).HasColumnName("salesbranch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.NotificationEmail)
                    .HasColumnName("notification_email")
                    .HasColumnType("xml");

                entity.Property(e => e.SalesbranchCode)
                    .IsRequired()
                    .HasColumnName("salesbranch_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SalesbranchName)
                    .HasColumnName("salesbranch_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.HasOne(d => d.Salesperson)
                    .WithMany(p => p.SalesBranch)
                    .HasForeignKey(d => d.SalespersonId)
                    .HasConstraintName("FK_SalesBranch_Salesperson");
            });

            modelBuilder.Entity<Salesperson>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.SalespersonCode })
                    .HasName("Salesperson_U")
                    .IsUnique();

                entity.Property(e => e.SalespersonId).HasColumnName("salesperson_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("xml");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.ListId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationEmail)
                    .HasColumnName("notification_email")
                    .HasColumnType("xml");

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SalesbranchId).HasColumnName("salesbranch_id");

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("salesperson_code")
                    .HasMaxLength(12);

                entity.Property(e => e.Viewgroupsales)
                    .HasColumnName("viewgroupsales")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Salesperson)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Salesperson_Client");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.Salesperson)
                    .HasForeignKey(d => d.InventoryregionId)
                    .HasConstraintName("FK__Salespers__inven__7E419184");

                entity.HasOne(d => d.Salesbranch)
                    .WithMany(p => p.SalespersonNavigation)
                    .HasForeignKey(d => d.SalesbranchId)
                    .HasConstraintName("FK_Salesperson_SalesBranch");
            });

            modelBuilder.Entity<Scac>(entity =>
            {
                entity.ToTable("SCAC");

                entity.HasIndex(e => e.Scac1)
                    .HasName("IX_SCAC")
                    .IsUnique();

                entity.Property(e => e.ScacId).HasColumnName("scac_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(29);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentMarkType)
                    .HasColumnName("equipment_mark_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mcn)
                    .HasColumnName("MCN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(99);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scac1)
                    .IsRequired()
                    .HasColumnName("SCAC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SymM)
                    .HasColumnName("sym-m")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SymN)
                    .HasColumnName("sym-n")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SymS)
                    .HasColumnName("sym-s")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SymX)
                    .HasColumnName("sym_x")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.USDot)
                    .HasColumnName("u.s. dot")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.SeasonCode })
                    .HasName("Season_U")
                    .IsUnique();

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Deliveries)
                    .HasColumnName("deliveries")
                    .HasColumnType("xml");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inovis)
                    .HasColumnName("inovis")
                    .HasColumnType("xml");

                entity.Property(e => e.OrderEnd)
                    .HasColumnName("order_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStart)
                    .HasColumnName("order_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Season1)
                    .HasColumnName("season")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SeasonCode)
                    .IsRequired()
                    .HasColumnName("season_code")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ShipEnd)
                    .HasColumnName("ship_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipStart)
                    .HasColumnName("ship_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Season)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK935F5703660AAEFC");
            });

            modelBuilder.Entity<Sequence>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.SequenceCode })
                    .HasName("IX_Sequence");

                entity.Property(e => e.SequenceId).HasColumnName("sequence_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(4);

                entity.Property(e => e.Rollover).HasColumnName("rollover");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Sequence1).HasColumnName("sequence");

                entity.Property(e => e.SequenceCode)
                    .IsRequired()
                    .HasColumnName("sequence_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Start).HasColumnName("start");

                entity.Property(e => e.ZeroPadding).HasColumnName("zero_padding");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("session");

                entity.HasIndex(e => e.SessionKey)
                    .HasName("UQ__session__B3BA0F1E7498F070")
                    .IsUnique();

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasComputedColumnSql("(case when [logout_date] IS NULL then (1) else (0) end)");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.LoginDate)
                    .HasColumnName("login_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoutDate)
                    .HasColumnName("logout_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessionKey)
                    .HasColumnName("session_key")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__session__locatio__4BA75DD6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Session)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__session__user_id__477F6532");
            });

            modelBuilder.Entity<ShipAdvise>(entity =>
            {
                entity.Property(e => e.ShipadviseId).HasColumnName("shipadvise_id");

                entity.Property(e => e.AckTime)
                    .HasColumnName("ack_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.RowversionId)
                    .IsRequired()
                    .HasColumnName("rowversion_id")
                    .IsRowVersion();

                entity.Property(e => e.SendTime)
                    .HasColumnName("send_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasIndex(e => e.CSeed)
                    .HasName("Shipment_Seed");

                entity.HasIndex(e => e.CommissionInvoiceId)
                    .HasName("ShipmentInvoice2_IX");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("Shipment_Invoice_IX");

                entity.HasIndex(e => e.OrderId)
                    .HasName("Shipment_Order_IX");

                entity.HasIndex(e => new { e.ClientId, e.Status })
                    .HasName("Shipment_Status_NC");

                entity.HasIndex(e => new { e.ShipmentNo, e.ClientId })
                    .HasName("Shipment_U")
                    .IsUnique();

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.Property(e => e.AuthorizationEmailDate)
                    .HasColumnName("authorization_email_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillofladingId).HasColumnName("billoflading_id");

                entity.Property(e => e.BolNumber)
                    .HasColumnName("bol_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSeed)
                    .HasColumnName("c_seed")
                    .HasColumnType("numeric(14, 0)")
                    .HasComputedColumnSql("(case when isnumeric(substring([shipment_no],patindex('%[0-9]%',[shipment_no]),(20)))=(1) AND patindex('%[a-Z]%',substring([shipment_no],patindex('%[0-9]%',[shipment_no]),(20)))=(0) then CONVERT([numeric](14),substring([shipment_no],patindex('%[0-9]%',[shipment_no]),(20)),0)  end)");

                entity.Property(e => e.CancelDate)
                    .HasColumnName("cancel_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.CarrierserviceId).HasColumnName("carrierservice_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CommissionInvoiceId).HasColumnName("commission_invoice_id");

                entity.Property(e => e.ConsolidationCliententityId).HasColumnName("consolidation_cliententity_id");

                entity.Property(e => e.ContainerId).HasColumnName("container_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectediId).HasColumnName("directedi_id");

                entity.Property(e => e.EdidocumentId).HasColumnName("edidocument_id");

                entity.Property(e => e.EstimatedReceiveDate)
                    .HasColumnName("estimated_receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromCliententityId).HasColumnName("from_cliententity_id");

                entity.Property(e => e.HandlingCharge)
                    .HasColumnName("handling_charge")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.MarkforCliententityId).HasColumnName("markfor_cliententity_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrdertypeId)
                    .HasColumnName("ordertype_id")
                    .HasComputedColumnSql("([dbo].[shipment_ordertype_id]([shipment_id]))");

                entity.Property(e => e.PackAsSpecified).HasColumnName("pack_as_specified");

                entity.Property(e => e.PrintDate)
                    .HasColumnName("print_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReferenceNo1)
                    .HasColumnName("reference_no1")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceNo2)
                    .HasColumnName("reference_no2")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("date");

                entity.Property(e => e.RequestedReceiveDate)
                    .HasColumnName("requested_receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedShipDate)
                    .HasColumnName("requested_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ScheduledShipDate)
                    .HasColumnName("scheduled_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasColumnName("shipment_no")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentType)
                    .HasColumnName("shipment_type")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ShipmentmopId).HasColumnName("shipmentmop_id");

                entity.Property(e => e.ShippingCharge)
                    .HasColumnName("shipping_charge")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ShipviaId).HasColumnName("shipvia_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [cancel_date] IS NOT NULL then 'Cancelled' when [invoice_id] IS NOT NULL AND [shipment_type]=(2) AND [ship_date] IS NOT NULL then 'Invoiced' when [receive_date] IS NOT NULL then 'Received' when [ship_date] IS NOT NULL then 'Shipped' when [release_date] IS NOT NULL then 'Released' when [print_date] IS NOT NULL then 'Printed' else 'Open' end)");

                entity.Property(e => e.ToCliententityId).HasColumnName("to_cliententity_id");

                entity.HasOne(d => d.Billoflading)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.BillofladingId)
                    .HasConstraintName("FK_Shipment_BillOfLading");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_Shipment_Carrier");

                entity.HasOne(d => d.Carrierservice)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.CarrierserviceId)
                    .HasConstraintName("FK_shipment_carrierservicelevel");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Client");

                entity.HasOne(d => d.CommissionInvoice)
                    .WithMany(p => p.ShipmentCommissionInvoice)
                    .HasForeignKey(d => d.CommissionInvoiceId)
                    .HasConstraintName("FK__Shipment__commis__60E746A4");

                entity.HasOne(d => d.ConsolidationCliententity)
                    .WithMany(p => p.ShipmentConsolidationCliententity)
                    .HasForeignKey(d => d.ConsolidationCliententityId)
                    .HasConstraintName("FK__Shipment__consol__1B204273");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("FK_Shipment_Container");

                entity.HasOne(d => d.Directedi)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.DirectediId)
                    .HasConstraintName("FK_Shipment_DirectEDI");

                entity.HasOne(d => d.Edidocument)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.EdidocumentId)
                    .HasConstraintName("FK__Shipment__edidoc__1C94126A");

                entity.HasOne(d => d.FromCliententity)
                    .WithMany(p => p.ShipmentFromCliententity)
                    .HasForeignKey(d => d.FromCliententityId)
                    .HasConstraintName("FK_Shipment_ClientEntity1");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.InventoryregionId)
                    .HasConstraintName("FK__Shipment__invent__1CFB22CE");

                entity.HasOne(d => d.InvoiceNavigation)
                    .WithMany(p => p.ShipmentInvoiceNavigation)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Shipment_Invoice");

                entity.HasOne(d => d.MarkforCliententity)
                    .WithMany(p => p.ShipmentMarkforCliententity)
                    .HasForeignKey(d => d.MarkforCliententityId)
                    .HasConstraintName("FK_Shipment_ClientEntity3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Shipment_Order");

                entity.HasOne(d => d.Shipvia)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.ShipviaId)
                    .HasConstraintName("FK_Shipment_ShipVia");

                entity.HasOne(d => d.ToCliententity)
                    .WithMany(p => p.ShipmentToCliententity)
                    .HasForeignKey(d => d.ToCliententityId)
                    .HasConstraintName("FK_Shipment_ClientEntity2");
            });

            modelBuilder.Entity<ShipmentLine>(entity =>
            {
                entity.HasIndex(e => e.InventoryId)
                    .HasName("IX_ShipmentLine_Inventory");

                entity.HasIndex(e => e.LotId)
                    .HasName("IX_ShipmentLine_1");

                entity.HasIndex(e => e.OrderlineId)
                    .HasName("IX_ShipmentLine");

                entity.HasIndex(e => e.ShipmentId)
                    .HasName("IX_ShipmentLine_Shipment");

                entity.Property(e => e.ShipmentlineId).HasColumnName("shipmentline_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

                entity.Property(e => e.LotId).HasColumnName("lot_id");

                entity.Property(e => e.OrderlineId).HasColumnName("orderline_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.QuantityIntransit)
                    .HasColumnName("quantity_intransit")
                    .HasComputedColumnSql("(case when [quantity_shipped] IS NOT NULL AND [quantity_received] IS NULL then [quantity_shipped] else (0) end)");

                entity.Property(e => e.QuantityReceived).HasColumnName("quantity_received");

                entity.Property(e => e.QuantityShipped).HasColumnName("quantity_shipped");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ShipmentLine)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentLine_Client");

                entity.HasOne(d => d.InventoryNavigation)
                    .WithMany(p => p.ShipmentLine)
                    .HasForeignKey(d => d.InventoryId)
                    .HasConstraintName("FK__ShipmentL__inven__7629574F");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.ShipmentLine)
                    .HasForeignKey(d => d.LotId)
                    .HasConstraintName("FK_ShipmentLine_Lot");

                entity.HasOne(d => d.Orderline)
                    .WithMany(p => p.ShipmentLine)
                    .HasForeignKey(d => d.OrderlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentLine_OrderLine");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentLine)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentLine_Shipment");
            });

            modelBuilder.Entity<ShipmentMop>(entity =>
            {
                entity.ToTable("ShipmentMOP");

                entity.HasIndex(e => e.PaymentCode)
                    .HasName("IX_ShipmentMOP")
                    .IsUnique();

                entity.Property(e => e.ShipmentmopId).HasColumnName("shipmentmop_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentCode)
                    .HasColumnName("payment_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipOrder>(entity =>
            {
                entity.Property(e => e.ShiporderId).HasColumnName("shiporder_id");

                entity.Property(e => e.Ack940Time)
                    .HasColumnName("ack940_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationTime)
                    .HasColumnName("creation_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Send940Time)
                    .HasColumnName("send940_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentId).HasColumnName("shipment_id");
            });

            modelBuilder.Entity<ShipVia>(entity =>
            {
                entity.HasIndex(e => new { e.ShipviaCode, e.ClientId })
                    .HasName("IX_ShipVia")
                    .IsUnique();

                entity.Property(e => e.ShipviaId).HasColumnName("shipvia_id");

                entity.Property(e => e.CarrierId).HasColumnName("carrier_id");

                entity.Property(e => e.CarrierserviceId).HasColumnName("carrierservice_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceLevel)
                    .HasColumnName("service_level")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShipviaCode)
                    .HasColumnName("shipvia_code")
                    .HasMaxLength(20);

                entity.Property(e => e.TransitTime).HasColumnName("transit_time");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.ShipVia)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_ShipVia_Carrier");

                entity.HasOne(d => d.Carrierservice)
                    .WithMany(p => p.ShipVia)
                    .HasForeignKey(d => d.CarrierserviceId)
                    .HasConstraintName("FK__ShipVia__carrier__384C1C38");
            });

            modelBuilder.Entity<Shopify>(entity =>
            {
                entity.ToTable("shopify");

                entity.Property(e => e.ShopifyId).HasColumnName("shopify_id");

                entity.Property(e => e.ApiKey)
                    .IsRequired()
                    .HasColumnName("api_key")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Show>(entity =>
            {
                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.ShowName)
                    .HasColumnName("show_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Show)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Show__client_id__0284DAC9");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Show)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Show__country_id__0378FF02");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasIndex(e => e.SizeId)
                    .HasName("IX_Size")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClientId, e.SizeCode })
                    .HasName("Size_U")
                    .IsUnique();

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplaySizeCode)
                    .HasColumnName("display_size_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DynamicProducts)
                    .IsRequired()
                    .HasColumnName("dynamic_products")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NrfCode)
                    .HasColumnName("nrf_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pack)
                    .HasColumnName("pack")
                    .HasComputedColumnSql("([dbo].[calc_ProductPack]([size_id]))");

                entity.Property(e => e.QrsSize)
                    .HasColumnName("qrs_size")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SizeCode)
                    .IsRequired()
                    .HasColumnName("size_code")
                    .HasMaxLength(12);

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.Size)
                    .HasForeignKey(d => d.BaseId)
                    .HasConstraintName("FK__Size__base_id__52DAB51D");
            });

            modelBuilder.Entity<SizeMatrix>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("SizeMatrix_U")
                    .IsUnique();

                entity.Property(e => e.SizematrixId).HasColumnName("sizematrix_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(40);

                entity.Property(e => e.X1Headings)
                    .HasColumnName("x1_headings")
                    .HasColumnType("xml");

                entity.Property(e => e.X1Positions).HasColumnName("x1_positions");

                entity.Property(e => e.X2Headings)
                    .HasColumnName("x2_headings")
                    .HasColumnType("xml");

                entity.Property(e => e.X2Positions).HasColumnName("x2_positions");

                entity.Property(e => e.Y1Headings)
                    .HasColumnName("y1_headings")
                    .HasColumnType("xml");

                entity.Property(e => e.Y1Positions).HasColumnName("y1_positions");

                entity.Property(e => e.Y2Headings)
                    .HasColumnName("y2_headings")
                    .HasColumnType("xml");

                entity.Property(e => e.Y2Positions).HasColumnName("y2_positions");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SizeMatrix)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SizeMatri__clien__55DAE871");
            });

            modelBuilder.Entity<SizeMatrixSize>(entity =>
            {
                entity.HasKey(e => new { e.SizematrixId, e.SizeId });

                entity.HasIndex(e => new { e.SizematrixId, e.X1, e.Y1, e.X2, e.Y2 })
                    .HasName("sizematrixsize_u")
                    .IsUnique();

                entity.Property(e => e.SizematrixId).HasColumnName("sizematrix_id");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.X1).HasColumnName("x1");

                entity.Property(e => e.X2).HasColumnName("x2");

                entity.Property(e => e.Y1).HasColumnName("y1");

                entity.Property(e => e.Y2).HasColumnName("y2");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SizeMatrixSize)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SizeMatri__clien__5D7C0A39");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.SizeMatrixSize)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SizeMatri__size___5E702E72");

                entity.HasOne(d => d.Sizematrix)
                    .WithMany(p => p.SizeMatrixSize)
                    .HasForeignKey(d => d.SizematrixId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SizeMatri__sizem__5C87E600");
            });

            modelBuilder.Entity<SizePrice>(entity =>
            {
                entity.Property(e => e.SizepriceId).HasColumnName("sizeprice_id");

                entity.Property(e => e.CPromoRetail)
                    .HasColumnName("c_promo_retail")
                    .HasColumnType("numeric(8, 2)")
                    .HasComputedColumnSql("(CONVERT([numeric](8,2),round([promo_price]*([retail_price]/nullif([wholesale_price],(0))),(0)),(0)))");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.PromoPrice)
                    .HasColumnName("promo_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("retail_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.SizeId).HasColumnName("size_id");

                entity.Property(e => e.SizepricegroupId).HasColumnName("sizepricegroup_id");

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SizePrice)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_SizePrice_Currency");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.SizePrice)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SizePrice_Size");

                entity.HasOne(d => d.Sizepricegroup)
                    .WithMany(p => p.SizePrice)
                    .HasForeignKey(d => d.SizepricegroupId)
                    .HasConstraintName("FK_SizePrice_SizePriceGroup");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.SizePrice)
                    .HasForeignKey(d => d.StyleId)
                    .HasConstraintName("FK_SizePrice_Style");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.SizePrice)
                    .HasForeignKey(d => d.StylecolorId)
                    .HasConstraintName("FK_SizePrice_StyleColor");
            });

            modelBuilder.Entity<SizePriceGroup>(entity =>
            {
                entity.HasIndex(e => new { e.SizematrixId, e.Name })
                    .HasName("sizepricegroup_u")
                    .IsUnique();

                entity.Property(e => e.SizepricegroupId).HasColumnName("sizepricegroup_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.SizematrixId).HasColumnName("sizematrix_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SizePriceGroup)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__SizePrice__clien__465E6EEA");

                entity.HasOne(d => d.Sizematrix)
                    .WithMany(p => p.SizePriceGroup)
                    .HasForeignKey(d => d.SizematrixId)
                    .HasConstraintName("FK__SizePrice__sizem__47529323");
            });

            modelBuilder.Entity<SolidPack>(entity =>
            {
                entity.HasIndex(e => new { e.BaseId, e.PackageLevel })
                    .HasName("IX_SolidPack")
                    .IsUnique();

                entity.Property(e => e.SolidpackId).HasColumnName("solidpack_id");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Pack).HasColumnName("pack");

                entity.Property(e => e.PackageLevel).HasColumnName("package_level");

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.SolidPack)
                    .HasForeignKey(d => d.BaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolidPack_Base");
            });

            modelBuilder.Entity<StateProvence>(entity =>
            {
                entity.Property(e => e.StateprovenceId).HasColumnName("stateprovence_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvence)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StateProvence_Country");
            });

            modelBuilder.Entity<Style>(entity =>
            {
                entity.HasIndex(e => e.ProducttypeId)
                    .HasName("IX_Style_1");

                entity.HasIndex(e => e.SeasonId)
                    .HasName("Style_Season_NC");

                entity.HasIndex(e => new { e.ClientId, e.StyleCode })
                    .HasName("IX_Style")
                    .IsUnique();

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasComputedColumnSql("(case when [inactive_date] IS NULL then (1) else (0) end)");

                entity.Property(e => e.BaseId).HasColumnName("base_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.BrokerageFee)
                    .HasColumnName("brokerage_fee")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CLandedCost)
                    .HasColumnName("c_landed_cost")
                    .HasColumnType("numeric(11, 2)")
                    .HasComputedColumnSql("(((isnull([factory_cost],(0))+isnull([freight_cost],(0)))+isnull([duty_cost],(0)))+isnull([brokerage_fee],(0)))");

                entity.Property(e => e.CStandardgm)
                    .HasColumnName("c_standardgm")
                    .HasColumnType("numeric(34, 15)")
                    .HasComputedColumnSql("(((((([wholesale_cost]-isnull([factory_cost],(0)))+isnull([freight_cost],(0)))+isnull([duty_cost],(0)))+isnull([brokerage_fee],(0)))/([wholesale_cost]+(0.00001)))*(100))");

                entity.Property(e => e.CStmi)
                    .HasColumnName("c_stmi")
                    .HasColumnType("numeric(31, 15)")
                    .HasComputedColumnSql("((([retail_cost]-[wholesale_cost])/([retail_cost]+(0.00001)))*(100))");

                entity.Property(e => e.CdnConfiguration)
                    .HasColumnName("cdn_configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Closeout)
                    .HasColumnName("closeout")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectionId).HasColumnName("collection_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.Construction)
                    .HasColumnName("construction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Delivery).HasColumnName("delivery");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("xml");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.DropShip)
                    .HasColumnName("drop_ship")
                    .HasColumnType("xml");

                entity.Property(e => e.DutyCost)
                    .HasColumnName("duty_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.DynamicProducts)
                    .HasColumnName("dynamic_products")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FactoryCliententityId).HasColumnName("factory_cliententity_id");

                entity.Property(e => e.FactoryCost)
                    .HasColumnName("factory_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.FreightCost)
                    .HasColumnName("freight_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Hts)
                    .HasColumnName("HTS")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HtsCode)
                    .HasColumnName("HTS_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Joor)
                    .HasColumnName("joor")
                    .HasColumnType("xml");

                entity.Property(e => e.LandedCost)
                    .HasColumnName("landed_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.NmfcId).HasColumnName("nmfc_id");

                entity.Property(e => e.OrderEnd)
                    .HasColumnName("order_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStart)
                    .HasColumnName("order_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProducttypeId).HasColumnName("producttype_id");

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.QrsDesc)
                    .HasColumnName("qrs_desc")
                    .HasMaxLength(20);

                entity.Property(e => e.RetailCost)
                    .HasColumnName("retail_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.RoyalityPercentage)
                    .HasColumnName("royality_percentage")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.ShipEnd)
                    .HasColumnName("ship_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipStart)
                    .HasColumnName("ship_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Silhouette)
                    .HasColumnName("silhouette")
                    .HasMaxLength(100);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(50);

                entity.Property(e => e.StyleCode)
                    .IsRequired()
                    .HasColumnName("style_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .HasColumnName("style_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("xml");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.WholesaleCost)
                    .HasColumnName("wholesale_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.BaseId)
                    .HasConstraintName("FK_Style_Base");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Style_Brand");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Style_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Style_Country");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Style_Currency");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Style_Division");

                entity.HasOne(d => d.FactoryCliententity)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.FactoryCliententityId)
                    .HasConstraintName("FK__Style__factory_c__10A7D76F");

                entity.HasOne(d => d.Nmfc)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.NmfcId)
                    .HasConstraintName("FK_Style_nmfc");

                entity.HasOne(d => d.Producttype)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.ProducttypeId)
                    .HasConstraintName("FK__Style__productty__1AB7ABB3");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Style_Season");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.Style)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("FK__Style__uom_id__39D2C65E");
            });

            modelBuilder.Entity<StyleColor>(entity =>
            {
                entity.HasIndex(e => e.MaterialId)
                    .HasName("IX_StyleColor_Material");

                entity.HasIndex(e => e.StyleId)
                    .HasName("StyleColor_Style_IX");

                entity.HasIndex(e => new { e.NrfColor, e.StyleId })
                    .HasName("StyleColor_nrf")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClientId, e.StyleId, e.ColorId })
                    .HasName("IX_StyleColor");

                entity.HasIndex(e => new { e.ClientId, e.StyleId, e.SeasonId })
                    .HasName("StyleColor_NC1");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasComputedColumnSql("(case when [inactive_date] IS NULL then (1) else (0) end)");

                entity.Property(e => e.BrokerageFee)
                    .HasColumnName("brokerage_fee")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CColor)
                    .HasColumnName("c_color")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[calc_ColorDescription]([stylecolor_id]))");

                entity.Property(e => e.CColormaterial)
                    .HasColumnName("c_colormaterial")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[calc_ColorMaterialDescription]([stylecolor_id]))");

                entity.Property(e => e.CLandedCost)
                    .HasColumnName("c_landed_cost")
                    .HasColumnType("numeric(11, 2)")
                    .HasComputedColumnSql("(((isnull([factory_cost],(0))+isnull([freight_cost],(0)))+isnull([duty_cost],(0)))+isnull([brokerage_fee],(0)))");

                entity.Property(e => e.CMaterial)
                    .HasColumnName("c_material")
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([dbo].[calc_MaterialDescription]([stylecolor_id]))");

                entity.Property(e => e.CStandardgm)
                    .HasColumnName("c_standardgm")
                    .HasColumnType("numeric(34, 15)")
                    .HasComputedColumnSql("(((((([wholesale_cost]-isnull([factory_cost],(0)))+isnull([freight_cost],(0)))+isnull([duty_cost],(0)))+isnull([brokerage_fee],(0)))/([wholesale_cost]+(0.00001)))*(100))");

                entity.Property(e => e.CStmi)
                    .HasColumnName("c_stmi")
                    .HasColumnType("numeric(31, 15)")
                    .HasComputedColumnSql("((([retail_cost]-[wholesale_cost])/([retail_cost]+(0.00001)))*(100))");

                entity.Property(e => e.CdnConfiguration)
                    .HasColumnName("cdn_configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discount_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.DropShip)
                    .HasColumnName("drop_ship")
                    .HasColumnType("xml");

                entity.Property(e => e.DutyCost)
                    .HasColumnName("duty_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.EarliestShipDate)
                    .HasColumnName("earliest_ship_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactoryCost)
                    .HasColumnName("factory_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.FreightCost)
                    .HasColumnName("freight_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.HtsCode)
                    .HasColumnName("hts_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InactiveDate)
                    .HasColumnName("inactive_date")
                    .HasColumnType("date");

                entity.Property(e => e.LandedCost)
                    .HasColumnName("landed_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.Multi).HasColumnType("xml");

                entity.Property(e => e.NrfColor)
                    .IsRequired()
                    .HasColumnName("nrf_color")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderEnd)
                    .HasColumnName("order_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStart)
                    .HasColumnName("order_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.QboId).HasColumnName("qbo_id");

                entity.Property(e => e.QrsDesc)
                    .HasColumnName("qrs_desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RetailCost)
                    .HasColumnName("retail_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.RgbColor)
                    .HasColumnName("rgb_color")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.ShipEnd)
                    .HasColumnName("ship_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipStart)
                    .HasColumnName("ship_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(100);

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.WholesaleCost)
                    .HasColumnName("wholesale_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.StyleColor)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_StyleColor_Material");
            });

            modelBuilder.Entity<StyleColorCost>(entity =>
            {
                entity.HasIndex(e => new { e.StylecolorId, e.StylecostId })
                    .HasName("stylecolorcost_U")
                    .IsUnique();

                entity.Property(e => e.StylecolorcostId).HasColumnName("stylecolorcost_id");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(100);

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.StylecostId).HasColumnName("stylecost_id");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.StyleColorCost)
                    .HasForeignKey(d => d.StylecolorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecolo__style__19FB6C28");

                entity.HasOne(d => d.Stylecost)
                    .WithMany(p => p.StyleColorCost)
                    .HasForeignKey(d => d.StylecostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecolo__style__1AEF9061");
            });

            modelBuilder.Entity<StyleColorInventoryRegion>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.InventoryregionId })
                    .HasName("StyleColorInventoryRegion_IX");

                entity.HasIndex(e => new { e.StylecolorId, e.InventoryregionId })
                    .HasName("StyleColorInventoryRegion_U")
                    .IsUnique();

                entity.Property(e => e.StylecolorinventoryregionId).HasColumnName("stylecolorinventoryregion_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FactorCostCurrencyId).HasColumnName("factor_cost_currency_id");

                entity.Property(e => e.FactoryCost)
                    .HasColumnName("factory_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.LandedCost)
                    .HasColumnName("landed_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.LandedCostCurrencyId).HasColumnName("landed_cost_currency_id");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.StyleColorInventoryRegion)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleColo__clien__1465DCCD");

                entity.HasOne(d => d.FactorCostCurrency)
                    .WithMany(p => p.StyleColorInventoryRegionFactorCostCurrency)
                    .HasForeignKey(d => d.FactorCostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleColo__facto__18366DB1");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.StyleColorInventoryRegion)
                    .HasForeignKey(d => d.InventoryregionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleColo__inven__164E253F");

                entity.HasOne(d => d.LandedCostCurrency)
                    .WithMany(p => p.StyleColorInventoryRegionLandedCostCurrency)
                    .HasForeignKey(d => d.LandedCostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleColo__lande__17424978");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.StyleColorInventoryRegion)
                    .HasForeignKey(d => d.StylecolorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleColo__style__155A0106");
            });

            modelBuilder.Entity<StyleColorPrice>(entity =>
            {
                entity.HasIndex(e => new { e.StylecolorId, e.SizepricegroupId, e.CurrencyId })
                    .HasName("StyleColorPrice_U")
                    .IsUnique();

                entity.Property(e => e.StylecolorpriceId).HasColumnName("stylecolorprice_id");

                entity.Property(e => e.CPromoRetail)
                    .HasColumnName("c_promo_retail")
                    .HasColumnType("numeric(8, 2)")
                    .HasComputedColumnSql("(CONVERT([numeric](8,2),round([promo_price]*([retail_price]/nullif([wholesale_price],(0))),(0)),0))");

                entity.Property(e => e.CloseoutPrice)
                    .HasColumnName("closeout_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CloseoutRetailPrice)
                    .HasColumnName("closeout_retail_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.PromoPrice)
                    .HasColumnName("promo_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("retail_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.SizepricegroupId).HasColumnName("sizepricegroup_id");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.StyleColorPrice)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_StyleColorPrice_Currency");

                entity.HasOne(d => d.Sizepricegroup)
                    .WithMany(p => p.StyleColorPrice)
                    .HasForeignKey(d => d.SizepricegroupId)
                    .HasConstraintName("FK__StyleColo__sizep__601E40ED");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.StyleColorPrice)
                    .HasForeignKey(d => d.StylecolorId)
                    .HasConstraintName("FK_StyleColorPrice_StyleColor");
            });

            modelBuilder.Entity<StyleColorSeason>(entity =>
            {
                entity.HasIndex(e => new { e.SeasonId, e.StylecolorId })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.StylecolorId, e.SeasonId })
                    .HasName("StyleColorSeason_Season_IX");

                entity.HasIndex(e => new { e.ClientId, e.SeasonId, e.StylecolorId })
                    .HasName("StyleColorSeason_U")
                    .IsUnique();

                entity.Property(e => e.StylecolorseasonId).HasColumnName("stylecolorseason_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Delivery).HasColumnName("delivery");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SeasonId).HasColumnName("season_id");

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.StyleColorSeason)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stylecolorseason_Season");

                entity.HasOne(d => d.Stylecolor)
                    .WithMany(p => p.StyleColorSeason)
                    .HasForeignKey(d => d.StylecolorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stylecolorseason_StyleColor");
            });

            modelBuilder.Entity<StyleCost>(entity =>
            {
                entity.HasIndex(e => e.MaterialId)
                    .HasName("StyleCost_Material_IX");

                entity.HasIndex(e => e.StyleId)
                    .HasName("StyleCost_Style_IX");

                entity.Property(e => e.StylecostId).HasColumnName("stylecost_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.DimensionId).HasColumnName("dimension_id");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.StylecostgroupId).HasColumnName("stylecostgroup_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecost__clien__0F7DDDB5");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecost__curre__134E6E99");

                entity.HasOne(d => d.Dimension)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.DimensionId)
                    .HasConstraintName("FK__stylecost__dimen__144292D2");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK__stylecost__mater__125A4A60");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecost__style__107201EE");

                entity.HasOne(d => d.Stylecostgroup)
                    .WithMany(p => p.StyleCost)
                    .HasForeignKey(d => d.StylecostgroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecost__style__11662627");
            });

            modelBuilder.Entity<StyleCostGroup>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.Description })
                    .HasName("stylecostgroup_U")
                    .IsUnique();

                entity.Property(e => e.StylecostgroupId).HasColumnName("stylecostgroup_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionId).HasColumnName("dimension_id");

                entity.Property(e => e.RequireMaterial).HasColumnName("require_material");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.StyleCostGroup)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__stylecost__clien__47031CC9");

                entity.HasOne(d => d.Dimension)
                    .WithMany(p => p.StyleCostGroup)
                    .HasForeignKey(d => d.DimensionId)
                    .HasConstraintName("FK__stylecost__dimen__57617189");
            });

            modelBuilder.Entity<StyleDimension>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_styledimension_client");

                entity.HasIndex(e => new { e.StyleId, e.Pack, e.Dimension })
                    .HasName("StyleDimension_U")
                    .IsUnique();

                entity.Property(e => e.StyledimensionId)
                    .HasColumnName("styledimension_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Dimension).HasColumnName("dimension");

                entity.Property(e => e.Pack).HasColumnName("pack");

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("numeric(10, 4)");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.StyleDimension)
                    .HasForeignKey(d => d.StyleId)
                    .HasConstraintName("FK_StyleDimension_Style");
            });

            modelBuilder.Entity<StyleImage>(entity =>
            {
                entity.HasKey(e => e.StyleimageId);

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__StyleIma__3214EC267C9431B0")
                    .IsUnique();

                entity.HasIndex(e => e.StyleId)
                    .HasName("StyleImage_Style_IX");

                entity.HasIndex(e => new { e.Aliastype, e.StyleId })
                    .HasName("IX_StyleImage_Object");

                entity.Property(e => e.StyleimageId).HasColumnName("styleimage_id");

                entity.Property(e => e.Aliastype).HasColumnName("aliastype");

                entity.Property(e => e.CdnId).HasColumnName("cdn_id");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.HasOne(d => d.Cdn)
                    .WithMany(p => p.StyleImage)
                    .HasForeignKey(d => d.CdnId)
                    .HasConstraintName("FK__StyleImag__cdn_i__3C651A46");
            });

            modelBuilder.Entity<StyleImageType>(entity =>
            {
                entity.HasKey(e => new { e.StyleimageId, e.ImageType });

                entity.Property(e => e.StyleimageId).HasColumnName("styleimage_id");
            });

            modelBuilder.Entity<StyleInventoryRegion>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.InventoryregionId })
                    .HasName("StyleInventoryRegion_IX");

                entity.HasIndex(e => new { e.StyleId, e.InventoryregionId })
                    .HasName("StyleInventoryRegion_U")
                    .IsUnique();

                entity.Property(e => e.StyleinventoryregionId).HasColumnName("styleinventoryregion_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.FactorCostCurrencyId).HasColumnName("factor_cost_currency_id");

                entity.Property(e => e.FactoryCost)
                    .HasColumnName("factory_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.InventoryregionId).HasColumnName("inventoryregion_id");

                entity.Property(e => e.LandedCost)
                    .HasColumnName("landed_cost")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.LandedCostCurrencyId).HasColumnName("landed_cost_currency_id");

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.StyleInventoryRegion)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleInve__clien__0CC4BB05");

                entity.HasOne(d => d.FactorCostCurrency)
                    .WithMany(p => p.StyleInventoryRegionFactorCostCurrency)
                    .HasForeignKey(d => d.FactorCostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleInve__facto__10954BE9");

                entity.HasOne(d => d.Inventoryregion)
                    .WithMany(p => p.StyleInventoryRegion)
                    .HasForeignKey(d => d.InventoryregionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleInve__inven__0EAD0377");

                entity.HasOne(d => d.LandedCostCurrency)
                    .WithMany(p => p.StyleInventoryRegionLandedCostCurrency)
                    .HasForeignKey(d => d.LandedCostCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleInve__lande__0FA127B0");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.StyleInventoryRegion)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StyleInve__style__0DB8DF3E");
            });

            modelBuilder.Entity<StylePrice>(entity =>
            {
                entity.HasIndex(e => new { e.StyleId, e.SizepricegroupId, e.CurrencyId })
                    .HasName("StylePrice_U")
                    .IsUnique();

                entity.Property(e => e.StylepriceId).HasColumnName("styleprice_id");

                entity.Property(e => e.CPromoRetail)
                    .HasColumnName("c_promo_retail")
                    .HasColumnType("numeric(8, 2)")
                    .HasComputedColumnSql("(CONVERT([numeric](8,2),round([promo_price]*([retail_price]/nullif([wholesale_price],(0))),(0)),0))");

                entity.Property(e => e.CloseoutPrice)
                    .HasColumnName("closeout_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CloseoutRetailPrice)
                    .HasColumnName("closeout_retail_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.PromoPrice)
                    .HasColumnName("promo_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.RetailPrice)
                    .HasColumnName("retail_price")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.SizepricegroupId).HasColumnName("sizepricegroup_id");

                entity.Property(e => e.StyleId).HasColumnName("style_id");

                entity.Property(e => e.WholesalePrice)
                    .HasColumnName("wholesale_price")
                    .HasColumnType("numeric(8, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.StylePrice)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_StylePrice_Currency");

                entity.HasOne(d => d.Sizepricegroup)
                    .WithMany(p => p.StylePrice)
                    .HasForeignKey(d => d.SizepricegroupId)
                    .HasConstraintName("FK__StylePric__sizep__5F2A1CB4");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.StylePrice)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StylePrice_Style");
            });

            modelBuilder.Entity<TagCom>(entity =>
            {
                entity.HasKey(e => new { e.Brand, e.OrderNo });

                entity.ToTable("TAG_COM");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustId)
                    .HasColumnName("cust_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PoNumber)
                    .HasColumnName("po_number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShpPeriod)
                    .HasColumnName("shp_period")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TermsDesc)
                    .HasColumnName("terms_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TagLines>(entity =>
            {
                entity.HasKey(e => new { e.Brand, e.OrderNo, e.Sequence });

                entity.ToTable("TAG_lines");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("order_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("invoice_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LineStatus)
                    .HasColumnName("line_status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RunCode)
                    .HasColumnName("run_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("style_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");
            });

            modelBuilder.Entity<TagLineSheet>(entity =>
            {
                entity.HasKey(e => new { e.Brand, e.StyleCode, e.ColorCode });

                entity.ToTable("TAG_LineSheet");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StyleCode)
                    .HasColumnName("style_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCode)
                    .HasColumnName("color_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasColumnName("material_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NrfColor)
                    .HasColumnName("nrf_color")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Retail)
                    .HasColumnName("retail")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Season)
                    .HasColumnName("season")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StylecolorId).HasColumnName("stylecolor_id");

                entity.Property(e => e.Wholesale)
                    .HasColumnName("wholesale")
                    .HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.HasIndex(e => e.TemplateName)
                    .HasName("UQ__Template__BB707B4EA4FBAE1C")
                    .IsUnique();

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Template1)
                    .IsRequired()
                    .HasColumnName("template")
                    .HasColumnType("xml");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasColumnName("template_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatetypeId).HasColumnName("templatetype_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Template)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Template__client__42760176");

                entity.HasOne(d => d.Templatetype)
                    .WithMany(p => p.Template)
                    .HasForeignKey(d => d.TemplatetypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Template__templa__55D3BA04");
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.Property(e => e.TemplatetypeId).HasColumnName("templatetype_id");

                entity.Property(e => e.Templatetype1)
                    .IsRequired()
                    .HasColumnName("templatetype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Terms>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.TermsCode })
                    .HasName("Terms_U")
                    .IsUnique();

                entity.Property(e => e.TermsId).HasColumnName("terms_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountDays).HasColumnName("discount_days");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.HandlingPercentage).HasColumnName("handling_percentage");

                entity.Property(e => e.ListId)
                    .HasColumnName("ListID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentBasis)
                    .HasColumnName("payment_basis")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Prepay).HasColumnName("prepay");

                entity.Property(e => e.QbTermsId).HasColumnName("qb_terms_id");

                entity.Property(e => e.RemittoCliententityId).HasColumnName("remitto_cliententity_id");

                entity.Property(e => e.TermsCode)
                    .IsRequired()
                    .HasColumnName("terms_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Termtype)
                    .HasColumnName("termtype")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.QbTerms)
                    .WithMany(p => p.Terms)
                    .HasForeignKey(d => d.QbTermsId)
                    .HasConstraintName("FK_Terms_QB_Terms");

                entity.HasOne(d => d.RemittoCliententity)
                    .WithMany(p => p.TermsNavigation)
                    .HasForeignKey(d => d.RemittoCliententityId)
                    .HasConstraintName("FK_Terms_ClientEntity");
            });

            modelBuilder.Entity<TradingPartner>(entity =>
            {
                entity.HasIndex(e => e.EntityId)
                    .HasName("IX_directeditradingpartner_entity");

                entity.HasIndex(e => new { e.TradingPartnerId1, e.ClientId, e.EntityId })
                    .HasName("IX_directeditradingpartner_U")
                    .IsUnique();

                entity.Property(e => e.TradingpartnerId).HasColumnName("tradingpartner_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Connectiontype).HasColumnName("connectiontype");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.RequiresAsn)
                    .HasColumnName("requires_asn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TradingPartnerId1)
                    .IsRequired()
                    .HasColumnName("TradingPartnerID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TradingPartnerAlias>(entity =>
            {
                entity.HasKey(e => e.DirectediitemId);

                entity.Property(e => e.DirectediitemId).HasColumnName("directediitem_id");

                entity.Property(e => e.AliasId).HasColumnName("alias_id");

                entity.Property(e => e.Aliastype).HasColumnName("aliastype");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.TradingpartnerId).HasColumnName("tradingpartner_id");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("XML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Tradingpartner)
                    .WithMany(p => p.TradingPartnerAlias)
                    .HasForeignKey(d => d.TradingpartnerId)
                    .HasConstraintName("FK_TradingPartnerAlias_TradingPartner_id");
            });

            modelBuilder.Entity<TransportationMethod>(entity =>
            {
                entity.HasKey(e => e.TransportationId);

                entity.Property(e => e.TransportationId)
                    .HasColumnName("transportation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransportationCode)
                    .HasColumnName("transportation_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TUser");

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__TUser__475C8B58")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__TUser__4668671F")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uom>(entity =>
            {
                entity.ToTable("UOM");

                entity.HasIndex(e => e.UomId)
                    .HasName("IX_UOM")
                    .IsUnique();

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Upcblock>(entity =>
            {
                entity.ToTable("UPCBlock");

                entity.HasIndex(e => new { e.ClientId, e.CompanyPrefix })
                    .HasName("IX_UPCBlock")
                    .IsUnique();

                entity.Property(e => e.UpcblockId).HasColumnName("upcblock_id");

                entity.Property(e => e.CertificateImage).HasColumnName("certificate_image");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CompanyPrefix)
                    .IsRequired()
                    .HasColumnName("company_prefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Internal).HasColumnName("internal");

                entity.Property(e => e.OriginalBlockId).HasColumnName("original_block_id");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasComputedColumnSql("(power((10),(12)-len([company_prefix])))");
            });

            modelBuilder.Entity<Upcreuse>(entity =>
            {
                entity.ToTable("UPCReuse");

                entity.HasIndex(e => new { e.UpcblockId, e.Sequence })
                    .HasName("IX_UPCReuse")
                    .IsUnique();

                entity.Property(e => e.UpcreuseId).HasColumnName("upcreuse_id");

                entity.Property(e => e.ReuseDate)
                    .HasColumnName("reuse_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Rowversion)
                    .HasColumnName("rowversion")
                    .IsRowVersion();

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.UpcblockId).HasColumnName("upcblock_id");

                entity.HasOne(d => d.Upcblock)
                    .WithMany(p => p.Upcreuse)
                    .HasForeignKey(d => d.UpcblockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UPCReuse_UPCBlock");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("User_U")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.AspuserId).HasColumnName("ASPuser_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(40);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(40);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.UserroleId).HasColumnName("userrole_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__UserRole__client__01E110F1");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRole__role_i__02D5352A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRole__user_i__03C95963");
            });

            modelBuilder.Entity<Van>(entity =>
            {
                entity.ToTable("VAN");

                entity.HasIndex(e => e.Name)
                    .HasName("VAN_u")
                    .IsUnique();

                entity.Property(e => e.VanId).HasColumnName("van_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Van)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK__VAN__entity_id__4EEA5214");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.Configuration)
                    .HasColumnName("configuration")
                    .HasColumnType("xml");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.HostWarehouseCode)
                    .HasColumnName("host_warehouse_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .IsRequired()
                    .HasColumnName("warehouse_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebApplication>(entity =>
            {
                entity.Property(e => e.WebapplicationId).HasColumnName("webapplication_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
