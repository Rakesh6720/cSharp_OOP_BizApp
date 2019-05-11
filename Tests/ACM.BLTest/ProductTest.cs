using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;


namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for ProductTest
    /// </summary>
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateEmptyParameterTest()
        {
            //-- Arrange
            Product product = new Product();
            var expected = false;
            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateOnlyIdTest()
        {
            //-- Arrange
            Product product = new Product(1);
            var expected = false;

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
