using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Buyer
    {
        public string BuyerCode { get; set; }
        public int? EntityId { get; set; }
        public int? UserId { get; set; }
        public int CliententityId { get; set; }
        public int ClientId { get; set; }
        public int BuyerId { get; set; }
        public int? DivisionId { get; set; }
        public int? BrandId { get; set; }

        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public ClientEntity Cliententity { get; set; }
        public Division Division { get; set; }
    }
}
