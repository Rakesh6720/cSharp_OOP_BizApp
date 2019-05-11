using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public int OrderId {get; private set;}
        public DateTime OrderDate { get; set; }

        public bool Validate()
        {
            var isValid = true;
            
            return isValid;
        }

        public Order Retrieve(int orderId)
        {

            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
