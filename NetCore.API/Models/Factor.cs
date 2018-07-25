using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Factor
    {
        public Factor()
        {
            Assignment = new HashSet<Assignment>();
            CreditRequest = new HashSet<CreditRequest>();
        }

        public int FactorId { get; set; }
        public int? EntityId { get; set; }
        public string Name { get; set; }
        public string Configuration { get; set; }

        public Entity Entity { get; set; }
        public ICollection<Assignment> Assignment { get; set; }
        public ICollection<CreditRequest> CreditRequest { get; set; }
    }
}
