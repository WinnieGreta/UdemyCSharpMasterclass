using System;

namespace UdemyAssignment26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            foreach (int[] jagged in jaggedArray)
            {
                foreach (int i in jagged)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

            // don't need to use jaggedArray.GetLength(0) because it's in it's nature one-dimensional

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Console.WriteLine(jaggedArray.GetLength(1)); generates "array doesn't have this many dimensions
        }
    }
}
