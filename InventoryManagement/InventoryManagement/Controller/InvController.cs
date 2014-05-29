using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class InvController
    {
        public void SwitchMenu(string input, string parameter)
        {
            switch (input.ToUpper())  //MENU SWITCH
            {
                case "ADD":

                break;

                case "ORDER":

                break;

                case "STOCK":

                break;

                default:

                    Console.WriteLine("Invalid command");

                break;
            }
        }
    }
}
