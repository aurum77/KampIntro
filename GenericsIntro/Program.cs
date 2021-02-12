using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names1= new List<string>();
            names1.Add("Bora");
            names1.Add("Tuna");
            names1.Add("Melih");

            MyList<string> names2 = new MyList<string>();
            names2.Add("Bora");
            names2.Add("Tuna");
            names2.Add("Melih");

            Console.WriteLine(names1.Count);
            Console.WriteLine(names2.Count);
        }
    }
}
