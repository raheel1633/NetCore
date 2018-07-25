using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Note
    {
        public string Objecttype { get; set; }
        public int Id { get; set; }
        public string Note1 { get; set; }
        public int NoteId { get; set; }
        public string Attributes { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? UserId { get; set; }
        public int? ClientId { get; set; }

        public Client Client { get; set; }
    }
}
