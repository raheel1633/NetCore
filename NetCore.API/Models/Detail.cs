using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Detail
    {
        public int DetailId { get; set; }
        public int ClientId { get; set; }
        public Guid? UserId { get; set; }
        public int? SalespersonId { get; set; }
        public string Details { get; set; }
        public DateTime? DetailDate { get; set; }
        public DateTime? EmailDate { get; set; }
        public int? SeasonId { get; set; }
        public int? BrandId { get; set; }
        public int? DivisionId { get; set; }

        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public Division Division { get; set; }
        public Salesperson Salesperson { get; set; }
        public Season Season { get; set; }
    }
}
