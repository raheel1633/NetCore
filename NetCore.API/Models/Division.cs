using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Division
    {
        public Division()
        {
            Buyer = new HashSet<Buyer>();
            CommissionRule = new HashSet<CommissionRule>();
            Detail = new HashSet<Detail>();
            Invoice = new HashSet<Invoice>();
            Linesheet = new HashSet<Linesheet>();
            Po = new HashSet<Po>();
            Style = new HashSet<Style>();
        }

        public int DivisionId { get; set; }
        public int ClientId { get; set; }
        public string DivisionCode { get; set; }
        public int? EntityId { get; set; }
        public int? UpcblockId { get; set; }
        public string QbClass { get; set; }
        public int? QbClassesId { get; set; }
        public string Name { get; set; }

        public Client Client { get; set; }
        public Entity Entity { get; set; }
        public QbClasses QbClasses { get; set; }
        public Upcblock Upcblock { get; set; }
        public ICollection<Buyer> Buyer { get; set; }
        public ICollection<CommissionRule> CommissionRule { get; set; }
        public ICollection<Detail> Detail { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Linesheet> Linesheet { get; set; }
        public ICollection<Po> Po { get; set; }
        public ICollection<Style> Style { get; set; }
    }
}
