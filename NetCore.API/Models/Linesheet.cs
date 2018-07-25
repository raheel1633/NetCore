using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Linesheet
    {
        public int LinesheetId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Linesheet1 { get; set; }
        public bool? AutoUpdate { get; set; }
        public int? DivisionId { get; set; }
        public int? BrandId { get; set; }
        public int? SeasonId { get; set; }
        public int? UserId { get; set; }
        public Guid? Uuid { get; set; }

        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public Division Division { get; set; }
        public Season Season { get; set; }
    }
}
