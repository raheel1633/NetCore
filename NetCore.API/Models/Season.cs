using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Season
    {
        public Season()
        {
            Detail = new HashSet<Detail>();
            Linesheet = new HashSet<Linesheet>();
            Style = new HashSet<Style>();
            StyleColorSeason = new HashSet<StyleColorSeason>();
        }

        public int SeasonId { get; set; }
        public int ClientId { get; set; }
        public string SeasonCode { get; set; }
        public string Description { get; set; }
        public decimal? Year { get; set; }
        public string Season1 { get; set; }
        public DateTime? OrderStart { get; set; }
        public DateTime? OrderEnd { get; set; }
        public DateTime? ShipStart { get; set; }
        public DateTime? ShipEnd { get; set; }
        public byte[] Rowversion { get; set; }
        public string Inovis { get; set; }
        public string Deliveries { get; set; }
        public string Configuration { get; set; }

        public Client Client { get; set; }
        public ICollection<Detail> Detail { get; set; }
        public ICollection<Linesheet> Linesheet { get; set; }
        public ICollection<Style> Style { get; set; }
        public ICollection<StyleColorSeason> StyleColorSeason { get; set; }
    }
}
