using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGadget.Data
{
    public class List
    {
        public string Title { get; set; }
        public ObservableCollection<Item> Items { get; set; }

    }
}
