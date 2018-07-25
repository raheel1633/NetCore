using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Cdn
    {
        public Cdn()
        {
            Brand = new HashSet<Brand>();
            Cdnobject = new HashSet<Cdnobject>();
            Edidocument = new HashSet<Edidocument>();
            StyleImage = new HashSet<StyleImage>();
        }

        public int CdnId { get; set; }
        public int? ClientId { get; set; }
        public string PublicUrl { get; set; }
        public DateTime? CreationTime { get; set; }
        public string ContentType { get; set; }
        public string Etag { get; set; }

        public Client Client { get; set; }
        public ICollection<Brand> Brand { get; set; }
        public ICollection<Cdnobject> Cdnobject { get; set; }
        public ICollection<Edidocument> Edidocument { get; set; }
        public ICollection<StyleImage> StyleImage { get; set; }
    }
}
