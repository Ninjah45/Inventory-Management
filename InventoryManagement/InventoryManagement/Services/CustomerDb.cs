using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class CustomerDb
    {
        public Repository<Customers> repo = new Repository<Customers>();

        public CustomerDb()
        {

        }

        public void AddCustomer(Customers customer)
        {
            repo.Add(customer);
            repo.SaveChanges();
        }

        public void RemoveCustomer(Customers customer)
        {
            repo.Delete(customer);
            repo.SaveChanges();
        }

        public void GetCustomer(int id)
        {
            repo.FindById(id);
        }

        public void ListCustomers()
        {
            repo.GetAll();
        }
    }
}
