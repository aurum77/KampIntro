using System;

namespace ValueOrReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, bool = value types (stack)
            int n1 = 10;
            int n2 = 30;

            n1 = n2;
            n2 = 65;

            Console.WriteLine(n1);

            // array, class, interface = reference types (heap)

            int[] arr1 = new int[] { 10, 20, 30 };
            int[] arr2 = new int[] { 100, 200, 300 };

            arr1 = arr2;

            arr2[0] = 777;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr1[1]);

            int a = 117;
            Console.WriteLine("Value of a in main: " + a);
            PrintNumber1(a);
            Console.WriteLine("Value of a in main after pass by value: " + a);
            PrintNumber2(ref a);
            Console.WriteLine("Value of a in main after pass by reference: " + a);
        }

        // Pass parameter by value
        static void PrintNumber1(int a)
        {
            a = 7;
            Console.WriteLine("Value of a in function pass by value: " + a);
        }

        // The 'ref' keyword allows us to pass the parameter by reference
        static void PrintNumber2(ref int a)
        {
            a = 7;
            Console.WriteLine("Value of a in pass by reference: " + a);
        }
    }
}
