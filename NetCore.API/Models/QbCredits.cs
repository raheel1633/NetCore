using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class QbCredits
    {
        public int QbCreditsId { get; set; }
        public int? ClientId { get; set; }
        public string RefNumber { get; set; }
        public string TxnId { get; set; }
        public decimal? CreditRemaining { get; set; }
        public string Item { get; set; }
    }
}
