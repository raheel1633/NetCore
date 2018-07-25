using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class ObjectType
    {
        public ObjectType()
        {
            InverseParentObjecttype = new HashSet<ObjectType>();
            Lfsobject = new HashSet<Lfsobject>();
        }

        public int ObjecttypeId { get; set; }
        public string ObjecttypeName { get; set; }
        public string Configuration { get; set; }
        public string Permission { get; set; }
        public string AttributeConfiguration { get; set; }
        public int? ParentObjecttypeId { get; set; }

        public ObjectType ParentObjecttype { get; set; }
        public ICollection<ObjectType> InverseParentObjecttype { get; set; }
        public ICollection<Lfsobject> Lfsobject { get; set; }
    }
}
