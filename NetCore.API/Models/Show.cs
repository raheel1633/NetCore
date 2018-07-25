using System;
using System.Collections.Generic;

namespace LFSCore.Models
{
    public partial class Show
    {
        public int ShowId { get; set; }
        public int ClientId { get; set; }
        public string ShowName { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }

        public Client Client { get; set; }
        public Country Country { get; set; }
    }
}
