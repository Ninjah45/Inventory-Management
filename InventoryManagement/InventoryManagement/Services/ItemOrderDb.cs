using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class ItemOrderDb
    {
        public Repository<ItemOrder> repo = new Repository<ItemOrder>();

        public ItemOrderDb()
        {
               
        }

        
    }
}
