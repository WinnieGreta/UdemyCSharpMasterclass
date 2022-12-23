using System;
using System.IO;

namespace UdemyAssignment41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment41\Assets\input.txt");

            foreach (string line in input)
            {
                if(line.Contains("split"))
                {
                    string[] splitResult = line.Split(' ');
                    using(StreamWriter file = new StreamWriter(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment41\Assets\output.txt", true))
                    {
                        file.Write(splitResult[4] + " ");
                    }
                }
            }
        }
    }
}
