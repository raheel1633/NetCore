using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Buyer = new HashSet<Buyer>();
            CommissionRule = new HashSet<CommissionRule>();
            Detail = new HashSet<Detail>();
            Linesheet = new HashSet<Linesheet>();
            Order = new HashSet<Order>();
            Po = new HashSet<Po>();
            Style = new HashSet<Style>();
        }

        public int BrandId { get; set; }
        public int ClientId { get; set; }
        public string BrandName { get; set; }
        public Guid Id { get; set; }
        public string LogoContentType { get; set; }
        public string LogoFileName { get; set; }
        public byte[] LogoFileContent { get; set; }
        public byte[] BrandImage { get; set; }
        public int? LicensorId { get; set; }
        public int? QbClassesId { get; set; }
        public decimal? RoyaltyPercentage { get; set; }
        public decimal? FcRoyaltyPercentage { get; set; }
        public int? CdnId { get; set; }
        public bool? Active { get; set; }
        public string Configuration { get; set; }

        public Cdn Cdn { get; set; }
        public Client Client { get; set; }
        public Licensor Licensor { get; set; }
        public QbClasses QbClasses { get; set; }
        public ICollection<Buyer> Buyer { get; set; }
        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Detail> Detail { get; set; }
        public ICollection<Linesheet> Linesheet { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<Style> Style { get; set; }
    }
}
