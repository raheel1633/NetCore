using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Document
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public Guid UserId { get; set; }
        public DateTime Datetime { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public int AliasId { get; set; }
        public int AliasType { get; set; }
        public string DataType { get; set; }
        public int DocumentId { get; set; }
    }
}
