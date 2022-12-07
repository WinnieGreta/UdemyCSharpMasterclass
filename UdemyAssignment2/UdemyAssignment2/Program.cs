using System;

namespace UdemyAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string var1;
            Console.WriteLine("Please enter your name and press enter");
            var1 = Console.ReadLine();
            Console.WriteLine(var1.ToUpper());
            Console.WriteLine(var1.ToLower());
            Console.WriteLine(var1.Trim());
            Console.WriteLine(var1.Substring(2));
        }
    }
}
