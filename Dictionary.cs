using System;
using System.Collections.Generic;

namespace Collection
{
    internal class Class2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of the dictionary:");
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the key:");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value:");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Add(key, value);
            }

            foreach (KeyValuePair<int, int> i in numbers)
            {
                Console.WriteLine(i);
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}