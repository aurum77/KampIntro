using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfValidPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration());
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(customer.NationalId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.BirthDate.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
