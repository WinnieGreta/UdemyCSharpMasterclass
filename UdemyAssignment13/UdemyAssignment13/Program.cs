using System;

namespace UdemyAssignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Count the people in the bus");
            while(Console.ReadLine() == "")
            {
                Console.Write(count + 1);
                count++;
            }
            Console.WriteLine("Okay, all {0} people in the bus", count);
        }
    }
}
