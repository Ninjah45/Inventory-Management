using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    // BA this class is unused. Why is it here?
    public class CustomerOrdersDb
    {
        // bA can be private
        public Repository<CustOrder> repo = new Repository<CustOrder>();

        // BA empty, parameterless constructor - no need for it. The compiler creates one by default
        public CustomerOrdersDb()
        {

        }

        // BA never used
        public void AddOrder(CustOrder order)
        {
            repo.Add(order);
            repo.SaveChanges();
        }

        // BA never used
        public void RemoveOrder(CustOrder order)
        {
            repo.Delete(order);
            repo.SaveChanges();
        }

        // BA never used
        public CustOrder GetOrder(int id)
        {
            return repo.FindById(id);
        }

        // BA never used
        public List<CustOrder> ListOrders()
        {
            return repo.GetAll().ToList();
        }


    }
}
