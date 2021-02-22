using InterfaceAndAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalId { get; set; }
    }
}
