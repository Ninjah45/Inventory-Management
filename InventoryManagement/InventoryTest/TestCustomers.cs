﻿using System;
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
    public class TestCustomers
    {
        CustomerDb custDB = new CustomerDb();
        Repository<Customer> repo = new Repository<Customer>();

        //[Test]
        //public void MyTestMethod()  //This parses user input. I think we might need this eventually...maybe.
        //{
        //    var result = new WordofCommand();
        //    var input = new string[] { "Add", "Something", "To", "Add" };
        //    Assert.That(result.ArgumentParserCommand(input), Is.EqualTo(ctrl.ListofCommands[0]));
        //    Assert.That(result.ArgumentParserParameter(input), Is.EqualTo("Something To Add"));
        //}

        [Test]
        public void test_that_ADD_adds_to_list() // BA No need to prefix test names with the word test. I know it's a test. It's
                                                 // got a [Test] attribute. Try to write your test name like this.

        // Given_the_specified_inputs_TheMethodUnderTest_will_have_this_result - or to put it another way
        // With_this_arrangement______TheMethodUnderTest_will_have_this_result - or...
        // With_this_arrangement______this_action________will_have_this_result - or
        // Arrange____________________Act________________Assert_______________

        // So this test would be called
        // Given_a_customer_object_AddCustomer_will_persist_it_to_the_database
        {
            // BA Arrange - And use comments to structure your tests
            int length = repo.GetAll().Count();
            var input = new Customer { Name = "Hey, just testing Customer", Address = "Test customer lives here"};

            // BA Act
            custDB.AddCustomer(input);
            int newLength = repo.GetAll().Count();

            // BA Assert
            Assert.Greater(newLength, length);
        }

        [Test]
        public void test_that_GETCUSTOMER_method_returns_customer()
        {
            var customerTest = custDB.GetCustomer(1);
            Assert.That(customerTest.Id == 1);
        }

        [Test]
        public void test_that_DELETE_deletes_from_list()
        {
            // Arrange
            int length = repo.GetAll().Count();
            var customerTest = custDB.GetCustomer(4);

            // Act
            custDB.RemoveCustomer(customerTest);

            // Assert
            int newLength = repo.GetAll().Count();
            Assert.Greater(length, newLength);
        }

        [Test]
        public void test_that_LISTCUSTOMERS_lists_orders_for_list_id()   //this gets all of the items, not just the items for a single list.
        {
            var customers = custDB.ListCustomers();

            Assert.That(customers.Count(), Is.EqualTo(repo.GetAll().Count()));
        }
    }
}
