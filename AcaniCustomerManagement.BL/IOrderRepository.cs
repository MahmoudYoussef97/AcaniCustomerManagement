using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public interface IOrderRepository
    {
         Order Retrieve(int orderId);
         bool Save(Order order);
    }
}
