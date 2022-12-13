using System;

namespace UdemyAssignment27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[][]
            {
                new string[] { "Martha", "Nick" },
                new string[] { "Jeff", "Kate" },
                new string[] { "Anna", "Arno" }
            };

            IntroduceFriends(friends);
        }

        public static void IntroduceFriends(string[][] friends)
        {
            for(int i = 0; i < friends.Length; i++)
            {
                if (i == friends.Length - 1)
                {
                    Console.WriteLine("Hi, {0}! I'm {1}.", friends[i][0], friends[0][1]);
                }
                else
                {
                    Console.WriteLine("Hi, {0}! I'm {1}.", friends[i][0], friends[i + 1][1]);
                }
            }
        }
    }
}
