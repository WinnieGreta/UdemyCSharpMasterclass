using System;

namespace UdemyAssignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Another way");

            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
