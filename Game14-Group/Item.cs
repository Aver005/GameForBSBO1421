using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game14_Group
{
    internal class Item : Entity
    {
        public string name { get; set; }
        public Item(string namy) 
        {
            symbol = "i"; 
            name = namy;
        }
    }
}
