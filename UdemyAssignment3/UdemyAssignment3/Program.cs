using System;

namespace UdemyAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string here:");
            string baseString = Console.ReadLine();
            Console.WriteLine("Enter the character to search:");
            char charToSearch = Console.ReadKey().KeyChar;
            Console.ReadLine();
            int charIndex = baseString.IndexOf(charToSearch);
            Console.WriteLine($"Index of first {charToSearch} is {charIndex}");

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
