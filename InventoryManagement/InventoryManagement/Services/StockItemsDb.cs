using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockItemsDb
    {
        public Repository<StockItems> repo = new Repository<StockItems>();

        public StockItemsDb()
        {

        }

        public void AddItem(StockItems item)
        {
            repo.Add(item);
            repo.SaveChanges();
        }

        public void RemoveItem(StockItems item)
        {
            repo.Delete(item);
            repo.SaveChanges();
        }

        public StockItem GetItem(int id)
        {
            return repo.FindById(id);
        }

        public List<StockItems> ListItems()
        {
            return repo.GetAll();
        }

        public int GetQuantity(int id)
        {
            return repo.FindById(id).Quantity;
        }

    }
}
