using System;

namespace UdemyAssignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            analyzeTemp();
        }

        public static void analyzeTemp()
        {
            int temp;
            string message;
            Console.WriteLine("Enter the temperature in celcius:");
            if (!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("Not a valid temperature.");
            } 
            else
            {
                message = temp <= 15 ? "it's too cold here" : temp >= 16 && temp <= 28 ? "it is ok" : "it's hot here";
                Console.WriteLine(message);
            }
        }
    }
}
