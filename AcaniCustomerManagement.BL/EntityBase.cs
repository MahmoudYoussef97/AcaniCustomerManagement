using System;
using System.Collections.Generic;
using System.Text;

namespace AcaniCustomerManagement.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanged { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();
        protected abstract bool Validate();
    }
}
