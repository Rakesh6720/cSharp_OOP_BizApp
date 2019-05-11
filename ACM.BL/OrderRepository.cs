using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if(orderId == 1)
            {
                order.OrderDate = DateTime.Today;
            }

            return order;
        }
    }
}
