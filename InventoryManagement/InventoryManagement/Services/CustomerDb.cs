using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class CustomerDb
    {
        public Repository<Customer> repo = new Repository<Customer>();

        public CustomerDb()
        {

        }

        public void AddCustomer(Customer customer)
        {
            repo.Add(customer);
            repo.SaveChanges();
        }

        public void RemoveCustomer(Customer customer)
        {
            repo.Delete(customer);
            repo.SaveChanges();
        }

        public Customer GetCustomer(int id)
        {
            return repo.FindById(id);
        }

        public List<Customer> ListCustomers()
        {
            return repo.GetAll().ToList();
        }
    }
}
