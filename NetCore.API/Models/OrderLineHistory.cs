using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class OrderLineHistory
    {
        public int OrderlinerhistoryId { get; set; }
        public int ClientId { get; set; }
        public int OrderlineId { get; set; }
        public int OrderreasonId { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public Guid UserId { get; set; }
        public int? ReferenceId { get; set; }
        public int? ReferenceType { get; set; }
        public DateTime? DateOnly { get; set; }
        public int? EdidocumentId { get; set; }

        public Client Client { get; set; }
        public Edidocument Edidocument { get; set; }
        public OrderLine Orderline { get; set; }
        public OrderReason Orderreason { get; set; }
    }
}
