using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            return isValid;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
