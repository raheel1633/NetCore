using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class CreditRequest
    {
        public CreditRequest()
        {
            CreditAllocation = new HashSet<CreditAllocation>();
        }

        public int CreditrequestId { get; set; }
        public int ClientenityId { get; set; }
        public int RemittoCliententityId { get; set; }
        public string ApprovalCode { get; set; }
        public decimal Amount { get; set; }
        public decimal? Used { get; set; }
        public decimal? Open { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public short? Credittype { get; set; }
        public DateTime RequestDate { get; set; }
        public string ReferenceValue { get; set; }
        public string ReferenceType { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? RequestAmount { get; set; }
        public Guid? ApprovalUserId { get; set; }
        public int? CreditcardId { get; set; }
        public int ClientId { get; set; }
        public int? OrderId { get; set; }
        public string Decision { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int? FactorId { get; set; }
        public string ApprovalValue { get; set; }
        public int? PoId { get; set; }
        public string Reason { get; set; }
        public DateTime? DecisionDate { get; set; }

        public Client Client { get; set; }
        public ClientEntity Clientenity { get; set; }
        public Factor Factor { get; set; }
        public Order Order { get; set; }
        public Po Po { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public ICollection<CreditAllocation> CreditAllocation { get; set; }
    }
}
