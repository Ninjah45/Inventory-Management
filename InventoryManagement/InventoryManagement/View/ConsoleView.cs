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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("<<<<<<<<<<<<<<<<");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("INVENTORY STOCK APPLICATION");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(">>>>>>>>>>>>>>>>");
            Console.WriteLine();
        }

        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Adjust Stock quantity:        [ADJUST, ID]");
            Console.WriteLine("List Stock items:             [LIST]");
            Console.WriteLine("Add new Stock item:           [ADD, NAME, PRICE, QUANTITY]");
            Console.WriteLine("Delete Stock item:            [DELETE, ID]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write(">> ");
        }

        public void ChangeQuantity(int id)
        {
            // BA you should not be talking to model classes here; the controller should provide a StockItem, not an Id
            Console.WriteLine("By how much do you want to change the quantity {0}?", StockItemsDb.GetItem(id).Name);
            int quantity = Convert.ToInt32(Console.ReadLine());
            StockItemsDb.UpdateStock(id, quantity);
        }

        public void ListStock()
        {
            var stockList = StockItemsDb.ListItems(); // BA the controller should pass the list of StockItems to the view, the
            // view should not query the model itself.
            foreach(StockItem item in stockList)
            {
                Console.WriteLine("{0}. {1} is ${2}. You have {3} available", item.Id , item.Name, item.Price, item.Quantity);
            }
        }

    }
}
