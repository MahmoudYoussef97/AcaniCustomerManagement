using System;
using System.Collections.Generic;
using Acani.Common;
using AcaniCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acani.CommonTests
{
    [TestClass]
    public class LoggingServiceTests
    {
        [TestMethod]
        public void WriteToFileTest()
        {   
            //-- Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "mahmoud@gmail.com",
                FirstName = "mahmoud",
                LastName = "youssef",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden cake with steel head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //-- Act
            LogginService.WriteToFile(changedItems);

            //-- Assert
            //-- Nothing here to Assert 
        }
    }
}
