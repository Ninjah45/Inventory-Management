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
            Console.WriteLine("Add stock [ADD]");
            Console.WriteLine("Enter new customer order [ORDER]");
            Console.WriteLine("Show current stock [STOCK]");
            Console.WriteLine("");
        }

        public void NewCustomerOrder()
        {
            Console.WriteLine();
        }
    }


}
