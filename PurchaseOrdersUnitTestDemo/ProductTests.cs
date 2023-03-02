using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PurchaseOrders;

namespace PurchaseOrdersUnitTestDemo
{
    [TestClass]
    public class ProductTests
    {
        private Product product;

        [TestInitialize]
        public void Initialize()
        {
            product = new Product();
        }

        [TestMethod]
        public void TestDefaultProductIsNotValid()
        {
            Initialize();

            Assert.IsFalse(product.IsValid());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidEmptyName()
        {
            Initialize();

            product.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidNullName()
        {
            Initialize();

            product.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidBlankName()
        {
            Initialize();

            product.Name = " ";
        }

        [TestMethod]
        public void TestValidName()
        {
            Initialize();
            string testName = "TestValue";
            product.Name = testName;
            Assert.AreEqual(product.Name, testName); // this make sure that the get works
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNegativePrice()
        {
            Initialize();
            product.Price = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNullPrice()
        {
            Initialize();
            product.Price = 0;
        }

        [TestMethod]
        public void TestValidPrice()
        {
            Initialize();
            decimal validPrice = 0.5m;
            product.Price = validPrice;
            Assert.AreEqual(product.Price, validPrice);
        }

        [TestMethod]
        public void TestValidProduct()
        {
            Initialize();
            product.Name = "SomeValue";
            product.Price = 1;
            Assert.IsTrue(product.IsValid());
        }
    }
}
