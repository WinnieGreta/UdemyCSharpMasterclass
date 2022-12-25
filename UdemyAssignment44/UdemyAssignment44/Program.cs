using System;
using System.IO;
using System.Text.RegularExpressions;

namespace UdemyAssignment44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = File.ReadAllText(@"D:\Users\trush\source\repos\UdemyCSharpMasterclass\UdemyAssignment42\Assets\input2.txt");
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);
            foreach (Match match in matches)
            {
                int charValue = int.Parse(match.Value);
                char letter = (char)charValue;
                Console.WriteLine(letter);

            }

        }
    }
}
