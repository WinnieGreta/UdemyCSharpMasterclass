using System;

namespace UdemyAssignment43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask me anything!");
            Console.ReadLine();
            Answer();
        }

        private static void Answer()
        {
            Random ball = new Random();

            int num = ball.Next(1, 4);

            switch (num)
            {
                case 1: 
                    Console.WriteLine("Yes");
                    break;
                case 2:
                    Console.WriteLine("Maybe");
                    break;
                case 3:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
