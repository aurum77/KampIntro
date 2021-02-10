using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public static void Add(Product product)
        {
            Console.WriteLine("Product " + product.ProductName + " has been added to the basket");
        }
        public static void Update(Product product)
        {
            Console.WriteLine("Product " + product.ProductName + " has been updated");
        }
    }
}
