using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory
{
   public class StoreInventory
        
    {
        public StoreInventory()
        {
            items = new List<ItemDisplay>();
        }

        public string Product;
        public double Amount;
        public List<ItemDisplay> items;
    }
}
