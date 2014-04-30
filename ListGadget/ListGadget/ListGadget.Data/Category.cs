using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGadget.Data
{
    public class Category
    {
        public string Title { get; set; }
        public int DisplayOrder { get; set; }

        //TODO: Still deciding on whether or not to include CategoryGroup.  I'll come back to this
        //public CategoryGroup Group { get; set; }

    }
}
