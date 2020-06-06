using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "mahmoud@gmail.com";
                customer.FirstName = "Mahmoud";
                customer.LastName = "Youssef";
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
