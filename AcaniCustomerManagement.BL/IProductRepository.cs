using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public interface IProductRepository
    {
        Product Retrieve(int productId);
        bool Save(Product product);
    }
}
