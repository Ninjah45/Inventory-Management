using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class CustomerOrdersDb
    {
        public Repository<CustOrders> repo = new Repository<CustOrders>();

        public CustomerOrdersDb()
        {

        }

        public void AddOrder(CustOrders order)
        {
            repo.Add(order);
            repo.SaveChanges();
        }

        public void RemoveOrder(CustOrders order)
        {
            repo.Delete(order);
            repo.SaveChanges();
        }

        public void GetOrder(int id)
        {
            repo.FindById(id);
        }


    }
}
