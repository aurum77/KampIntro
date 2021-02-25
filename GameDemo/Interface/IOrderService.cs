using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interface
{
    interface IOrderService
    {
        void Create(Gamer gamer, Order order);
        void Update(Gamer gamer, Order order);
        void Delete(Gamer gamer, Order order);
        void AddDiscount(Gamer gamer, Order order, Discount discount);
    }
}
