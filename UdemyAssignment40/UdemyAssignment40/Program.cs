using System;
using System.IO;

namespace UdemyAssignment40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "highscore 1: 1000", "highscore 2: 989", "highscore 3: 987" };
            File.WriteAllLines(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment40\Assets\highScores1.txt", lines);

            using(StreamWriter file = new StreamWriter(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment40\Assets\highScores2.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment40\Assets\highScores2.txt", true))
            {
                file.WriteLine("Additional line");
            }
        }
    }
}
