using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Qbc
    {
        public Qbc()
        {
            QbCurrency = new HashSet<QbCurrency>();
        }

        public int QbcId { get; set; }
        public string OwnerId { get; set; }
        public int ClientId { get; set; }
        public string FileId { get; set; }
        public DateTime? SubscriptionDate { get; set; }
        public bool? Active { get; set; }
        public Guid? Userid { get; set; }
        public int? QbVersionId { get; set; }
        public int Level { get; set; }
        public bool? UseInventoryItems { get; set; }

        public ICollection<QbCurrency> QbCurrency { get; set; }
    }
}
