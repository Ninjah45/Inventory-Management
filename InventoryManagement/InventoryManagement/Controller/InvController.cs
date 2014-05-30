using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class InvController
    {
        
        ConsoleView view = new ConsoleView();

        public void Start()
        {
            view.Header();
            view.DisplayMenu();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                        Console.ReadLine();
                        break;
                    }
                case "ADD":
                    {
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
                        var item = StockItemsDb.GetItem(Convert.ToInt32(parameter[1]));
                        StockItemsDb.RemoveItem(item);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid command");
                        break;
                    }                    
               }
            Console.Clear();
            Start();
        }
    }
}
