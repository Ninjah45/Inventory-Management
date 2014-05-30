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

        public void AddItemOrder(ItemOrder order)
        {
            repo.Add(order);
            repo.SaveChanges();
        }

        public void RemoveItemOrder(ItemOrder order)
        {
            repo.Delete(order);
            repo.SaveChanges();
        }

        public ItemOrder GetItemOrder(int id)
        {
            return repo.FindById(id);
        }

        public List<ItemOrder> ListItemOrders()
        {
            return repo.GetAll().ToList();
        }
        
    }
}
