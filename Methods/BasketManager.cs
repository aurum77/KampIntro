using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
        
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Congrats, added item " + product.Name + " to the cart");
        }
    }
}
