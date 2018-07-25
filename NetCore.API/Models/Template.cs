using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Template
    {
        public int TemplateId { get; set; }
        public int ClientId { get; set; }
        public string TemplateName { get; set; }
        public string Template1 { get; set; }
        public int TemplatetypeId { get; set; }

        public Client Client { get; set; }
        public TemplateType Templatetype { get; set; }
    }
}
