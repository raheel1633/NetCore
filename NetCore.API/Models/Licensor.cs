using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Licensor
    {
        public Licensor()
        {
            Brand = new HashSet<Brand>();
        }

        public int LicensorId { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public int? EntityId { get; set; }

        public Client Client { get; set; }
        public Entity Entity { get; set; }
        public ICollection<Brand> Brand { get; set; }
    }
}
