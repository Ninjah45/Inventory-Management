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

        public void GetItem(int id)
        {
            repo.FindById(id);
        }

        public void ListItems()
        {
            repo.GetAll();
        }

    }
}
