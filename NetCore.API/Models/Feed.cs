using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Feed
    {
        public Feed()
        {
            Feeditem = new HashSet<Feeditem>();
        }

        public int FeedId { get; set; }
        public Guid? Guid { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

        public ICollection<Feeditem> Feeditem { get; set; }
    }
}
