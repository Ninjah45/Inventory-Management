using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InvController
    {
       
        ConsoleView view = new ConsoleView(); // BA private ConsoleView view - make the accessibility explicit

        public void Start()
        {
            view.Header();
            view.DisplayMenu();
            Console.ForegroundColor = ConsoleColor.DarkGreen; // BA why are you talking to the console in the controller? This should be work that the view does for you
            var input = Console.ReadLine();
            var inputArray = input.Split(' ');
            SwitchMenu(inputArray);
        }


        public void SwitchMenu(string[] parameter)
        {
            switch (parameter[0].ToUpper())  //MENU SWITCH
            {
                case "ADJUST":
                    {
                        view.ChangeQuantity(Convert.ToInt32(parameter[1]));
                        break;
                    }
                case "LIST":
                    {
                        view.ListStock();
                        Console.ReadLine(); // BA this is a view concern
                        break;
                    }
                case "ADD":
                    {
                        // BA if you're going to have wrapper classes over the repository, this is the sort of work that they should be doing.
                        // Rather than creating a stockitem here, add a method to the StockItemsDb class which takes a string, a decimal, and an int,
                        // and create your new StockItem in that method before giving it to the repo.
                        StockItem item = new StockItem()    
                        { 
                            Name = parameter[1],
                            Price = Convert.ToDecimal(parameter[2]),
                            Quantity = Convert.ToInt32(parameter[3])
                        };                        
                        StockItemsDb.AddItem(item);
                        break;
                    }
                case "DELETE":
                    {
                        var item = StockItemsDb.GetItem(Convert.ToInt32(parameter[1])); // BA, again, delegate this work to the StockItemsDb class, since you have it
                        StockItemsDb.RemoveItem(item);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid command"); // BA this is a view concern
                        break;
                    }                    
               }
            Console.Clear(); // BA this is a view concern
            Start();
        }
    }
}
