using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtlantaRentals.Models
{
    public class Branch
    {
        public int BranchNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string  Phone3 { get; set; }
        public string ManagerId { get; set; }

    }
}
