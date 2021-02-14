using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer
    {
        // Base class
        // If properties in a class don't fit the object,
        // then we should split up the object
        public int Id { get; set; }
        public string TurkishIdNum { get; set; }
        public string CustomerNum { get; set; }
    }
}
