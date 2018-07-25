using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CommissionRule
    {
        public int CliententityId { get; set; }
        public int SalespersonId { get; set; }
        public decimal? Rate { get; set; }
        public DateTime ActiveDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public byte[] Rowversion { get; set; }
        public int? RegionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int CommissionruleId { get; set; }
        public int ClientId { get; set; }
        public int? BrandId { get; set; }

        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public ClientEntity Cliententity { get; set; }
        public Department Department { get; set; }
        public Division Division { get; set; }
        public Region Region { get; set; }
        public Salesperson Salesperson { get; set; }
    }
}
