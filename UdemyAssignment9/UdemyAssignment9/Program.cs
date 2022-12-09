using System;

namespace UdemyAssignment9
{
    internal class Program
    {
        public static int highscore = 1000;
        public static string highscorePlayer = "Greta";

        static void Main(string[] args)
        {
            int score1 = 10;
            string player1 = "aaa";

            int score2 = 2000;
            string player2 = "bbb";

            int score3 = 1400;
            string player3 = "ccc";

            CheckHighscore(score1, player1);
            CheckHighscore(score2, player2);
            CheckHighscore(score3, player3);
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
                highscore = score;
                highscorePlayer = playerName;
            }
            else 
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }
    }
}
