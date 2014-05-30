using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class CustomerOrdersDb
    {
        public Repository<CustOrder> repo = new Repository<CustOrder>();

        public CustomerOrdersDb()
        {

        }

        public void AddOrder(CustOrder order)
        {
            repo.Add(order);
            repo.SaveChanges();
        }

        public void RemoveOrder(CustOrder order)
        {
            repo.Delete(order);
            repo.SaveChanges();
        }

        public CustOrder GetOrder(int id)
        {
            return repo.FindById(id);
        }

        public List<CustOrder> ListOrders()
        {
            return repo.GetAll().ToList();
        }


    }
}
