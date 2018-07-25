using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Terms
    {
        public Terms()
        {
            ClientEntity = new HashSet<ClientEntity>();
            Invoice = new HashSet<Invoice>();
            OrderFcTerms = new HashSet<Order>();
            OrderTerms = new HashSet<Order>();
            Po = new HashSet<Po>();
        }

        public int TermsId { get; set; }
        public string TermsCode { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public int? PaymentBasis { get; set; }
        public int ClientId { get; set; }
        public bool? Prepay { get; set; }
        public bool CreditCard { get; set; }
        public short? HandlingPercentage { get; set; }
        public short? DiscountPercent { get; set; }
        public short? DiscountDays { get; set; }
        public int? RemittoCliententityId { get; set; }
        public int? QbTermsId { get; set; }
        public string ListId { get; set; }
        public string Termtype { get; set; }

        public QbTerms QbTerms { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public ICollection<ClientEntity> ClientEntity { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Order> OrderFcTerms { get; set; }
        public ICollection<Order> OrderTerms { get; set; }
        public ICollection<Po> Po { get; set; }
    }
}
