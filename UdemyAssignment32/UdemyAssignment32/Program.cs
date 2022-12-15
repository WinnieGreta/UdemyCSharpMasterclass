using System;
using System.Collections.Generic;

namespace UdemyAssignment32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            PrintArray(numbers);
            PrintArray(ReverseNumbers(numbers));
        }

        private static int[] ReverseNumbers(int[] numbers)
        {
            Stack<int> stack = new Stack<int>();
            int[] reverse = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[i] = stack.Pop();
            }

            return reverse;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
