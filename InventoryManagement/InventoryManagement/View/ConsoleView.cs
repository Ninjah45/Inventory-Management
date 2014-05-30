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
            Console.Write(">>");
        }

        public void ChangeQuantity(int id)
        {
            Console.WriteLine("What's the new quantity for {0}?", StockItemsDb.GetItem(id).Name);
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

    }
}
