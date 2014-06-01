// BA commented out class?

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using InventoryManagement;
//using Mindscape.LightSpeed;
//using Mindscape.LightSpeed.Linq;

//namespace InventoryTest
//{
//    class TestItemOrders
//    {
//        ItemOrderDb itemOrderDB = new ItemOrderDb();
//        Repository<ItemOrder> repo = new Repository<ItemOrder>();

//        [Test]
//        public void test_that_ADDORDER_adds_to_list()
//        {
//            int length = repo.GetAll().Count();
//            var input = new ItemOrder { CustId = 2, OrderDate = DateTime.Now };
//            itemOrderDB.AddOrder(input);
//            int newLength = repo.GetAll().Count();
//            Assert.Greater(newLength, length);
//        }

//        [Test]
//        public void test_that_GETCUSTOMER_method_returns_customer()
//        {
//            var stockTest = itemOrderDB.GetOrder(3);
//            Assert.That(stockTest.Id == 3);
//        }

//        [Test]
//        public void test_that_REMOVEITEM_deletes_from_list()
//        {
//            // Arrange
//            int length = repo.GetAll().Count();
//            var stockTest = itemOrderDB.GetOrder(2);

//            // Act
//            itemOrderDB.RemoveOrder(stockTest);

//            // Assert
//            int newLength = repo.GetAll().Count();
//            Assert.Greater(length, newLength);
//        }

//        [Test]
//        public void test_that_LISTITEMS_lists_items_for_list_id()   //this gets all of the items, not just the items for a single list.
//        {
//            var list = itemOrderDB.ListOrders();

//            Assert.That(list.Count(), Is.EqualTo(repo.GetAll().Count()));
//        }
//    }
//}
