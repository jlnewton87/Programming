using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGadget.Data
{
    public class Item
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ItemStatus Status { get; set; }
        public Category Category { get; set; }

    }
}
