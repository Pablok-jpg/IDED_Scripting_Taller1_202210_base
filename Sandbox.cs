using System.Collections.Generic;
using System;
using System.Linq;


namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}: {1}");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");

            Dictionary<int, string> result = new Dictionary<int, string>();

            result.Add(2, "Two");
            result.Add(4, "Two");
            result.Add(5, "Five");
            result.Add(7, "Seven");
            result.Add(10, "Two");

            var items = from pair in result
                        orderby pair.Key descending
                        select pair;

            foreach (var value in items)
            {
                Console.WriteLine(value);
            }
        }
    }
}