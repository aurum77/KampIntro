using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("1", "Cake");
            dictionary.Add("2", "Pasta");
            dictionary.Add("3", "Kebab");

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("1", "Cake");
            myDictionary.Add("2", "Pasta");
            myDictionary.Add("3", "Kebab");
        }
    }
}
