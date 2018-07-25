using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Tuser
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
    }
}
