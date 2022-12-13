using System;

namespace UdemyAssignment28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = { 3, 2, 5, 4, 1 };

            Console.WriteLine("Current happiness:");
            foreach (int i in happiness)
            {
                Console.Write(i + " ");
            }

            IncreaseHappiness(happiness);
            Console.WriteLine();
            Console.WriteLine("Happiness has been increased!");
            foreach (int i in happiness)
            {
                Console.Write(i + " ");
            }
        }

        private static void IncreaseHappiness(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
    }
}
