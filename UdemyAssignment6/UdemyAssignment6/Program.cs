using System;

namespace UdemyAssignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in two whole numbers and I'll add them for you:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("You added {0} and {1}, the result is {2}", num1, num2, Add(num1, num2));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
