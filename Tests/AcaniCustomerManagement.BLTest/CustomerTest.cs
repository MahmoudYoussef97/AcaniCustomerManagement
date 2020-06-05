using System;
using AcaniCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcaniCustomerManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arange
            Customer customer = new Customer
            {
                FirstName = "Mahmoud",
                LastName = "Youssef"
            };
            string expected = "Mahmoud Youssef";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {   
            // -- Arange
            Customer customer = new Customer
            {
                LastName = "youssef"
            };
            string expected = "youssef";

            // -- Act
            string actual = customer.LastName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Roise";
            Customer.InstanceCount += 1;

            int expected = 3;
            //-- Act
            int actual = Customer.InstanceCount;

            //-- Assert\
            Assert.AreEqual(expected, actual);
        }
    }
}
