using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            AssignmentInvoice = new HashSet<AssignmentInvoice>();
        }

        public int AssignmentId { get; set; }
        public int ClientId { get; set; }
        public int FactorId { get; set; }
        public string AccountNo { get; set; }
        public int RemittoCliententityId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public int? EdidocumentId { get; set; }

        public Client Client { get; set; }
        public Edidocument Edidocument { get; set; }
        public Factor Factor { get; set; }
        public ClientEntity RemittoCliententity { get; set; }
        public ICollection<AssignmentInvoice> AssignmentInvoice { get; set; }
    }
}
