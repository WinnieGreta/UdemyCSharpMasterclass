using System;

namespace UdemyAssignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array2DString = new string[3, 2]
            {
                { "one", "two"},
                { "three", "four" },
                { "five", "six" }
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine(array2DString[0, 0] + " " + array2DString[0, 1] + "\n"
                + array2DString[1, 0] + " " + array2DString[1, 1] + "\n"
                + array2DString[2, 0] + " " + array2DString[2, 1]);
        }
    }
}
