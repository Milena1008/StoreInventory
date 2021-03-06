using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreInventoryBussinessLayer.DSStoreInventoryTableAdapters;
using StoreInventoryBussinessLayer;

namespace StoreInventory.Bussiness
{
   public class StoreInventory
        
    {
        public StoreInventory()
        {
            items = new List<StoreInventory>();
        }
        public static List<StoreInventory> GetAllProducts()
        {
            StoreInventoryTableAdapter taStoreInventory = new StoreInventoryTableAdapter();
           ItemDisplayTableAdapter taItemDisplay = new ItemDisplayTableAdapter();
        
            var dtStoreInventory = taStoreInventory.GetData();
            List<StoreInventory> allStoreInventory = new List<StoreInventory>();
            foreach (StoreInventoryBussinessLayer.DSStoreInventory.StoreInventoryRow StoreInventoryRow in dtStoreInventory.Rows)
            {
                StoreInventory currentStoreInventory = new StoreInventory();
                currentStoreInventory.Amount = StoreInventoryRow.Amount;
                allStoreInventory.Add(currentStoreInventory);

               
            }
            return AllProducts();
        }


        public void AddStoreInventory(string Product, double Amount)
        {
            StoreInventory item =  new StoreInventory();
            item.Product = Product;
            item.Amount = Amount; 

        }
       

        public string Product;
        public double Amount;
        public List<StoreInventory> items;
        
    }
}
