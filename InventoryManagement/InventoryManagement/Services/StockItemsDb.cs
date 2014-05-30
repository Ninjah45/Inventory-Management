using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockItemsDb
    {
        public Repository<StockItem> repo = new Repository<StockItem>();

        public StockItemsDb()
        {

        }

        public void AddItem(StockItem item)
        {
            repo.Add(item);
            repo.SaveChanges();
        }

        public void RemoveItem(StockItem item)
        {
            repo.Delete(item);
            repo.SaveChanges();
        }

        public StockItem GetItem(int id)
        {
            return repo.FindById(id);
        }

        public List<StockItem> ListItems()
        {
            return repo.GetAll().ToList();
        }

        public int GetQuantity(int id)
        {
            return repo.FindById(id).Quantity;
        }

    }
}
