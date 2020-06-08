using System;
using Acani.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acani.CommonTests
{
    [TestClass]
    public class StringHandlerTests
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = source.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = source.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
