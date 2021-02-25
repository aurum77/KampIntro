using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Order : IEntity
    {
        public long Price { get; set; }
        public int Discount { get; set; }
    }
}
