using System;
using System.Globalization;

namespace UdemyAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0,85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatForString = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine(stringForFloat);
            int intForString = Int32.Parse(stringForInt);
            Console.WriteLine(stringForInt);

        }
    }
}
