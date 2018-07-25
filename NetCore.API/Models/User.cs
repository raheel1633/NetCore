using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class User
    {
        public User()
        {
            Cdnobject = new HashSet<Cdnobject>();
            ClientUser = new HashSet<ClientUser>();
            Session = new HashSet<Session>();
            UserRole = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public Guid? AspuserId { get; set; }

        public ICollection<Cdnobject> Cdnobject { get; set; }
        public ICollection<ClientUser> ClientUser { get; set; }
        public ICollection<Session> Session { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
