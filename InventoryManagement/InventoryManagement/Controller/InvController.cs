using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class InvController
    {
        Stock stock = new Stock();
        ConsoleView view = new ConsoleView();

        public void SwitchMenu(string input, string parameter)
        {
            switch (input.ToUpper())  //MENU SWITCH
            {
                case "ADJUST":
                    int stockid;                    
                    int.TryParse(input, out stockid);
                    int quantity = view.ConfirmQuantity(stockid);
                    view.ConfirmAdjustment(stockid, quantity);
                    stock.Adjust(stockid, quantity);
                break;

                case "ORDER":
                    OrderMenu();
                break;

                case "STOCK":

                break;

                default:

                    Console.WriteLine("Invalid command");

                break;
            }
        }

        public void OrderMenu()
        {
 
        }
    }
}
