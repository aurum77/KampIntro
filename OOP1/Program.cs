using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an object
            Product product1 = new Product();
            // Props are not given this way in real applications,
            // They might be taken from a database etc.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Thinkpad L14";
            product1.UnitPrice = 6500;
            product1.UnitsInStock = 7;

            // Another way to declare an object
            Product product2 = new Product() { Id = 2, CategoryId = 5, UnitsInStock = 2, ProductName = "Pencil", UnitPrice = 10 };

            // Class names are written in Pascal case 
            // Object names are written in Camel case
            ProductManager productManager = new ProductManager();
            ProductManager.Add(product1);

            // Create
            // Read
            // Update
            // Delete
            // Lists can be used for easier storage of arrays
            List<string> list = new List<string> { "Bora", "Fatma", "Mehmet" };
            // List class has many methods such as add, count, clear etc. 
            list.Add("Tuna");
        }
    }
}
