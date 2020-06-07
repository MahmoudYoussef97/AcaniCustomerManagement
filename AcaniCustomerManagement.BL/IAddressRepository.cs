using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public interface IAddressRepository
    {
        Address Retrieve(int addressId);
        IEnumerable<Address> RetrieveByCustomerId(int customerId);
        bool Save(Address address);
    }
}
