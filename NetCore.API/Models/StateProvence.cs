using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class StateProvence
    {
        public StateProvence()
        {
            Entity = new HashSet<Entity>();
        }

        public int StateprovenceId { get; set; }
        public int CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Configuration { get; set; }

        public Country Country { get; set; }
        public ICollection<Entity> Entity { get; set; }
    }
}
