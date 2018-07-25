using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StyleImage
    {
        public int StyleimageId { get; set; }
        public int StyleId { get; set; }
        public string Filename { get; set; }
        public string ContentType { get; set; }
        public int? Aliastype { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid Id { get; set; }
        public byte[] ImageContent { get; set; }
        public byte[] FileContent { get; set; }
        public int? CdnId { get; set; }

        public Cdn Cdn { get; set; }
    }
}
