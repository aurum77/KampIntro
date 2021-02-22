using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfValidPerson(Customer customer)
        {
            return true;
        }
    }
}
