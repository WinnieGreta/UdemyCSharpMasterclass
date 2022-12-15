using System;
using System.Collections.Generic;

namespace UdemyAssignment30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert(1));
            Console.WriteLine(Convert(2));
            Console.WriteLine(Convert(3));
            Console.WriteLine(Convert(10));
        }

        public static string Convert(int i)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" }
            };

            string number = null;

            if (numbers.TryGetValue(i, out number))
            {
                return number;
            }
            else
            {
                return "nope";
            }
        }
    }
}
