using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class ConsoleView
    {
        public void Header()
        {
            Console.WriteLine("INVENTORY STOCK APPLICATION"); 
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Adjust stock [ADJUST]");
            Console.WriteLine("List Stock items [LIST]");
            Console.WriteLine("Add new Stock item [ADD]");
            Console.WriteLine("");
        }

        public void NewCustomerOrder()
        {
            Console.WriteLine();
        }

        public void ChangeQuantity(int id)
        {
            Console.WriteLine("What's the new quantity for" + StockItemsDb.GetItem(id).Name + "?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            StockItemsDb.UpdateStock(id, quantity);
        }

        public void ListStock()
        {
            var stockList = StockItemsDb.ListItems();
            foreach(StockItem item in stockList)
            {
                Console.WriteLine("{0}. {1} is ${2}. You have {3} available", item.Id , item.Name, item.Price, item.Quantity);
            }
        }

        //public void ConfirmAdjustment(int stockid, int quantity)
        //{
        //    if (quantity > stockid.quantity)
        //    {
        //        Console.WriteLine("You've added" + STOCKNAME + ". New total is " + quantity + ".");
        //    }
        //    if (quantity < stockid.quantity)
        //    {
        //        Console.WriteLine("You've removed" + STOCKNAME + ". New total is " + quantity + ".");
        //    }
        //}
    }
}
