using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class ItemOrderDb
    {
        public Repository<ItemOrders> repo = new Repository<ItemOrders>();

        public ItemOrderDb()
        {
               
        }

        
    }
}
