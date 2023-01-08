using System;
using System.Collections.Generic;
using System.Linq;

namespace UdemyAssignment58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            OddNumbers(numbers);
            EvenNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            //Console.WriteLine(oddNumbers.ToString());
            foreach (int i in oddNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void EvenNumbers(int[] numbers)
        {
            Console.WriteLine("Even numbers");
            IEnumerable<int> evenNumbers = from number in numbers where number % 2 == 0 select number;
            //Console.WriteLine(oddNumbers.ToString());
            foreach (int i in evenNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
