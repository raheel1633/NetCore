using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CreditCard
    {
        public int CreditcardId { get; set; }
        public int ClientId { get; set; }
        public string PaymentechProfileId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public byte[] Rowversion { get; set; }
        public int CliententityId { get; set; }
        public string Last4 { get; set; }
        public short? Cardtype { get; set; }
        public string ExpiryDate { get; set; }
        public int? PaymentProfileId { get; set; }
    }
}
