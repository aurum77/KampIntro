using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
