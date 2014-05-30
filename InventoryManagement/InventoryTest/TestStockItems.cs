using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InventoryManagement;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;


namespace InventoryTest
{
    class TestStockItems
    {
        
        Repository<StockItem> repo = new Repository<StockItem>();

        [Test]
        public void test_that_ADDITEM_adds_to_list()
        {
            int length = repo.GetAll().Count();
            var input = new StockItem { Name = "Stock???", Price = 50 , Quantity = 50};
            StockItemsDb.AddItem(input);
            int newLength = repo.GetAll().Count();
            Assert.Greater(newLength, length);
        }

        [Test]
        public void test_that_GETCUSTOMER_method_returns_customer()
        {
            var stockTest = StockItemsDb.GetItem(3);
            Assert.That(stockTest.Id == 3);
        }

        [Test]
        public void test_that_REMOVEITEM_deletes_from_list()
        {
            // Arrange
            int length = repo.GetAll().Count();
            var stockTest = StockItemsDb.GetItem(1);

            // Act
            StockItemsDb.RemoveItem(stockTest);

            // Assert
            int newLength = repo.GetAll().Count();
            Assert.Greater(length, newLength);
        }

        [Test]
        public void test_that_LISTITEMS_lists_items_for_list_id()   //this gets all of the items, not just the items for a single list.
        {
            var customers = StockItemsDb.ListItems();

            Assert.That(customers.Count(), Is.EqualTo(repo.GetAll().Count()));
        }
    }
}
