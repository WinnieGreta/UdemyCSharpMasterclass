using System;

namespace UdemyAssignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            string input = Console.ReadLine();
            CheckInput(input);
        }

        public static void CheckInput(string input)
        {
            Console.WriteLine("Select the Data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
            bool validChoise = false;
            do
            {
                string datatype = Console.ReadLine();
                switch (datatype)
                {
                    case "1":
                        validChoise = true;
                        CheckIfString(input);
                        break;
                    case "2":
                        validChoise = true;
                        CheckIfInt(input);
                        break;
                    case "3":
                        validChoise = true;
                        CheckIfBool(input);
                        break;
                    default:
                        Console.WriteLine("Choose a type by entering numbers from 1 to 3");
                        break;
                }
            } while (!validChoise);

        }

        public static void CheckIfString(string input)
        {
            bool validString = true;
            foreach(char c in input)
            {
                if (!char.IsLetter(c) && c != (char)32)
                {
                    validString = false;
                    break;
                }
            }
            PrintResults(input, validString, "String");
        }

        public static void CheckIfInt(string input)
        {
            PrintResults(input, int.TryParse(input, out _), "Integer");
        }

        public static void CheckIfBool(string input)
        {
            PrintResults(input, bool.TryParse(input, out _), "Boolean");
        }

        public static void PrintResults(string input, bool isOfType, string type)
        {
            Console.WriteLine("You have entered a value: " + input);
            if (isOfType)
            {
                Console.Write("It is valid: ");
            }
            else
            {
                Console.Write("It is invalid: ");
            }
            Console.WriteLine(type);
        }
    }
}
