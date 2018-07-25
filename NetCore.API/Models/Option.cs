using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Option
    {
        public Option()
        {
            PlanOption = new HashSet<PlanOption>();
        }

        public int OptionId { get; set; }
        public string OptionCode { get; set; }
        public string Description { get; set; }

        public ICollection<PlanOption> PlanOption { get; set; }
    }
}
