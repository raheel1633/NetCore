using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class TemplateType
    {
        public TemplateType()
        {
            Template = new HashSet<Template>();
        }

        public int TemplatetypeId { get; set; }
        public string Templatetype1 { get; set; }

        public ICollection<Template> Template { get; set; }
    }
}
