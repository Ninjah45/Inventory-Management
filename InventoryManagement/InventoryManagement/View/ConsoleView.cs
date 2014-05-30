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
            Console.WriteLine("Enter new customer order [ORDER] customername");
            Console.WriteLine("Show current stock [STOCK]");
            Console.WriteLine("");
        }

        public void NewCustomerOrder()
        {
            Console.WriteLine();
        }

        //public int ConfirmQuantity(int id)
        //{
        //    Console.WriteLine("What's the new quantity for" + STOCKNAME + "?");
        //    string quantity = Console.ReadLine();
        //    int quantityInt;
        //    int.TryParse(quantity, out quantityInt);
        //    return quantityInt;
        //}

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
