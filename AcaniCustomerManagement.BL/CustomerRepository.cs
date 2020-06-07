using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private IAddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "mahmoud@gmail.com";
                customer.FirstName = "Mahmoud";
                customer.LastName = "Youssef";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList(); 
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
