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
                product.CurrentPrice = (decimal)9.99;
                product.ProductName = "Garden Hose";
                product.ProductDescription = "A plastic hose perfect for the outdoor patio or lawn.";
            }

            return product;
        }
    }
}
