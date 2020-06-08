using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public class ProductRepository : IProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Flowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanged)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        // Insert
                    }
                    else
                    {
                        // Update
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
