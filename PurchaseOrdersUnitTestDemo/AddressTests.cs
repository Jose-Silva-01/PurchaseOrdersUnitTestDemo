using Microsoft.VisualStudio.TestTools.UnitTesting;
using PurchaseOrders;
using System;

namespace PurchaseOrdersUnitTestDemo
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void TestDefaultAddressIsNotValid()
        {
            Address address = new Address();

            Assert.IsFalse(address.IsValid());
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidEmptyStreet()
        {
            Address address = new Address();

            address.Street = "";
        }
    }
}
