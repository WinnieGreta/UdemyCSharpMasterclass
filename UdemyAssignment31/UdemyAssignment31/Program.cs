using System;
using System.Collections.Generic;

namespace UdemyAssignment31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(21);
            stack.Push(32);
            stack.Push(43);
            stack.Push(54);

            while (stack.Count > 0)
            {
                int val = stack.Pop();
                Console.WriteLine(val);
                Console.WriteLine($"Stack count is {stack.Count}");
            }
        }
    }
}
