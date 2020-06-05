using System;

namespace AcaniCustomerManagement.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName 
        { 
            get 
            {
                return FirstName + " " + LastName;            
            } 
        }
        public static int InstanceCount { get; set; }
    }
}
