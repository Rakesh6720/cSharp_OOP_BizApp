using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (double.IsNaN(CurrentPrice)) isValid = false;

            return isValid;
        }

        public Product Retrieve(int productId)
        {

            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

    }
}
