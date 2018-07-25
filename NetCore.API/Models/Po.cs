using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Po
    {
        public Po()
        {
            CreditRequest = new HashSet<CreditRequest>();
            Order = new HashSet<Order>();
        }

        public int PoId { get; set; }
        public int ClientId { get; set; }
        public string PoNumber { get; set; }
        public int BilltoCliententityId { get; set; }
        public int RemittoCliententityId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? ConsolidatorCliententityId { get; set; }
        public int? ShipviaId { get; set; }
        public int? TermsId { get; set; }
        public int? SeasonId { get; set; }
        public int? DivisionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SalespersonId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BrandId { get; set; }
        public int? LotId { get; set; }
        public int? OrderstatusId { get; set; }
        public int? OrdertypeId { get; set; }

        public ClientEntity BilltoCliententity { get; set; }
        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public ClientEntity ConsolidatorCliententity { get; set; }
        public Currency Currency { get; set; }
        public Department Department { get; set; }
        public Division Division { get; set; }
        public Lot Lot { get; set; }
        public OrderStatus Orderstatus { get; set; }
        public OrderType Ordertype { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public Salesperson Salesperson { get; set; }
        public ShipVia Shipvia { get; set; }
        public Terms Terms { get; set; }
        public ICollection<CreditRequest> CreditRequest { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
