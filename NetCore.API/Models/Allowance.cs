using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Allowance
    {
        public int AllowanceId { get; set; }
        public int? ClientId { get; set; }
        public int? OrderId { get; set; }
        public decimal? Amount { get; set; }
        public string EdiType { get; set; }
        public int? PercentBasisCode { get; set; }
        public decimal? Percentage { get; set; }
    }
}
