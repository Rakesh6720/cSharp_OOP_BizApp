﻿using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = DateTime.Today
            };

            //-- Act
            var actual = orderRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
