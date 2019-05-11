using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(productId == 1)
            {
                product.CurrentPrice = 15.99M;
                product.ProductName = "Garden Hose";
                product.ProductDescription = "A plastic hose perfect for the outdoor patio or lawn.";
            }

            return product;
        }

        public bool Save(Product product)
        {
            // Code that saves the passed in product

            return true;
        }
    }
}
