using System;
using System.Collections.Generic;

namespace TaskK
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> a = new();
            a.Add("what", "what");
            a["what"] = "lol"; 
            foreach (var item in a)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            string ll = a["what"];
            Console.WriteLine("Hello World!");
        }
    }
}
