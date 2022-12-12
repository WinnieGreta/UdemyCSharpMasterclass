using System;

namespace UdemyAssignment24
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
            Console.WriteLine("Diagonal elements:");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Negative diagonal elements:");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = matrix.GetLength(1) - 1; j >= 0 ; j--)
                {
                    if (i == matrix.GetLength(1) - j - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }
        }
    }
}
