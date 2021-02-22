using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        // If nero would request a database and validation functionality too 
        // it would be as easy as copying the code over starbucks and renaming
        // a single method
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfValidPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
