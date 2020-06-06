using System;
using AcaniCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcaniCustomerManagement.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            ICustomerRepository customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "mahmoud@gmail.com",
                FirstName = "Mahmoud",
                LastName = "Youssef"
            };
            //-- Act
            var actual = customerRepository.Retrieve(1);
            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
