using System;

namespace UdemyAssignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Vova";
            string name2 = "Dasha";
            string name3 = "Anya";

            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }
    }
}
