using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Feeditem
    {
        public int FeeditemId { get; set; }
        public Guid Guid { get; set; }
        public int ClientId { get; set; }
        public int FeedId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime? Updated { get; set; }

        public Client Client { get; set; }
        public Feed Feed { get; set; }
    }
}
