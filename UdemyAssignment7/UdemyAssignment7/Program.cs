using System;

namespace UdemyAssignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AskTheTemperature();
        }

        public static void AskTheTemperature()
        {
            Console.WriteLine("What's the temperature today?");
            string tString = Console.ReadLine();
            int tInt;
            try 
            {
                tInt = Int32.Parse(tString);
                AnalyzeTemperature(tInt);
            } 
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("That's like super hot. Or super cold");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("You should enter something");
            }
        }

        public static void AnalyzeTemperature(int t)
        {
            if (t < 0)
            {
                Console.WriteLine("Wear a warm coat, don't forget your scarf and hat");
            }
            else if (t == 0)
            {
                Console.WriteLine("Wear shoes with nice grip");
            }
            else if (t > 20)
            {
                Console.WriteLine("Wear shorts");
            }
            else if (t > 10)
            {
                Console.WriteLine("Wear a sweater");
            }
        }


    }
}
