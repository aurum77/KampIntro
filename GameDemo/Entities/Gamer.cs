using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public long IdentityNumber { get; set; }
        public List<Order> OrdersList { get; set; }
    }
}
