using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Acer Aspire 3";
            product1.Price = 5576;
            product1.Description = "Ryzen processor and 8 gigs of ram";

            Product product2 = new Product();
            product2.Name = "Lenovo Thinkpad L14";
            product2.Price = 7588;
            product2.Description = "Laptop with brilliant keyboard and ryzen";

            Product[] products = new Product[] { product1, product2 };

            // Equivalent to python's "for i in data"
            // If var is used c# will choose the data type itself
            //foreach (var item in products) 
            
            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Price);
            }

            BasketManager basketManager = new BasketManager();

            basketManager.Add(product1);
            basketManager.Add(product2);
        }
    }
}
