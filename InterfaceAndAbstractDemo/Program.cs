using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { BirthDate = new DateTime(1985, 1, 6),
                                                FirstName = "Engin",
                                                LastName = "Demiroğ",
                                                NationalId = "28861499108"
            });

            /*
            customerManager.Save(new Customer { BirthDate = new DateTime(1337, 7, 7),
                                                FirstName = "demoman",
                                                LastName = "team fortress",
                                                NationalId = "1338"
            });
            */
        }
    }
}
