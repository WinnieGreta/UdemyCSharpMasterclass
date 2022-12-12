using System;

namespace UdemyAssignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[] {"Dasha", "Vova", "Anya", "Greta", "Hana"};

            foreach (string friend in friends)
            {
                Console.WriteLine("Hello, " + friend + " my friend");
            }
        }
    }
}
