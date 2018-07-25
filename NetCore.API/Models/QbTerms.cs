using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbTerms
    {
        public QbTerms()
        {
            Terms = new HashSet<Terms>();
        }

        public int QbTermsId { get; set; }
        public int? QbcId { get; set; }
        public int? ClientId { get; set; }
        public string ListId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? StdDueDays { get; set; }
        public int? StdDiscountDays { get; set; }
        public decimal? DiscountPct { get; set; }

        public ICollection<Terms> Terms { get; set; }
    }
}
