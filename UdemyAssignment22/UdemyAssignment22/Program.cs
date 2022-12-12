using System;

namespace UdemyAssignment22
{
    internal class Program
    {
        static int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        static void Main(string[] args)
        {
            PrintOddArray(matrix);
       
        }

        public static void PrintOddArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] % 2 != 0)
                    {
                        Console.Write(arr[i,j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
