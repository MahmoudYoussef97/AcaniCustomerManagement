using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public interface ICustomerRepository
    {
        Customer Retrieve(int customerId);
        bool Save(Customer customer);
    }
}
