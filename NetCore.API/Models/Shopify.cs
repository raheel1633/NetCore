using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Shopify
    {
        public int ShopifyId { get; set; }
        public string ApiKey { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public int ClientId { get; set; }
    }
}
