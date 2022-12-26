using System;

namespace UdemyAssignment45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Now is {0}", dateTime);
            Console.WriteLine("It is {0} today", dateTime.DayOfWeek);
            Console.WriteLine("Tomorrow will be {0}", GetTomorrow());
            Console.WriteLine("First day of 2019 is {0}", GetFirstDayOfYear(2019));

            Console.WriteLine("{0} o'clock {1} minutes {2} seconds", dateTime.Hour, dateTime.Minute, dateTime.Second);

            DateTime birthday = new DateTime();

            Console.WriteLine("Write your birthday in format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out birthday)) 
            {
                TimeSpan daysPassed = dateTime.Subtract(birthday);
                Console.WriteLine("You've been born {0} days ago", daysPassed);
            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
