using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Plan
    {
        public Plan()
        {
            PlanOption = new HashSet<PlanOption>();
        }

        public int PlanId { get; set; }
        public string PlanCode { get; set; }
        public string Description { get; set; }
        public short? TrialPeriod { get; set; }

        public ICollection<PlanOption> PlanOption { get; set; }
    }
}
