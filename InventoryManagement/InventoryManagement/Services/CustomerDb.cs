using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    // BA Nothing in this class is used anywhere but in test code...
    public class CustomerDb
    {
        // BA this can be private, nothing outside of this class uses it
        public Repository<Customer> repo = new Repository<Customer>();

        public CustomerDb()
        {

        }

        // BA this is only used from test code, why is it here?
        public void AddCustomer(Customer customer)
        {
            repo.Add(customer);
            repo.SaveChanges();
        }


        // BA this is only used from test code
        public void RemoveCustomer(Customer customer)
        {
            repo.Delete(customer);
            repo.SaveChanges();
        }

        // BA only used from test code
        public Customer GetCustomer(int id)
        {
            return repo.FindById(id);
        }

        // BA only used from test code
        public List<Customer> ListCustomers()
        {
            return repo.GetAll().ToList();
        }
    }
}
