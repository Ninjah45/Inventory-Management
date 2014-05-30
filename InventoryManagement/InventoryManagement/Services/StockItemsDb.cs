using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class StockItemsDb
    {
        public static Repository<StockItem> repo = new Repository<StockItem>();

        public StockItemsDb()
        {
        }

        public static void AddItem(StockItem item)
        {
            repo.Add(item);
            repo.SaveChanges();
        }

        public static void RemoveItem(StockItem item)
        {
            repo.Delete(item);
            repo.SaveChanges();
        }

        public static StockItem GetItem(int id)
        {
            return repo.FindById(id);
        }

        public static List<StockItem> ListItems()
        {
            return repo.GetAll().ToList();
        }

        public static int GetQuantity(int id)
        {
            return repo.FindById(id).Quantity;
        }

        public static void UpdateStock(int id, int adjust)
        {
            var update = repo.FindById(id);
            update.Quantity += adjust;
            repo.SaveChanges();
        }

    }
}
