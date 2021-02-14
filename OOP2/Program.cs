using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Individual Customer, Corporate Customer
            // This adheres to the L in the SOLID principles
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNum = "12345";
            customer1.Name = "Bora";
            customer1.Surname = "Baykar";
            customer1.TurkishIdNum = "1338";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNum = "123";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxId = "123123";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
