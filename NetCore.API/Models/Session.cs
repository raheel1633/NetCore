using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Session
    {
        public int SessionId { get; set; }
        public Guid SessionKey { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime? LogoutDate { get; set; }
        public int? UserId { get; set; }
        public int Active { get; set; }
        public int? LocationId { get; set; }

        public Location Location { get; set; }
        public User User { get; set; }
    }
}
