using System;

namespace UdemyAssignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageScoreCalculator();
        }

        public static void AverageScoreCalculator()
        {
            double averageScore;
            int sumScore = 0;
            int studentCount = 0;
            string score = "";
            Console.WriteLine("Enter the scores of your students");
            do
            {
                score = Console.ReadLine();
                int oneScore = ScoreParser(score);
                if (oneScore < -1 || oneScore > 20)
                {
                    Console.WriteLine("Enter appropriate score (whole number from 0 to 20)");
                } else if (oneScore == -1)
                {
                    Console.WriteLine("Finished. Calculating........");
                } else
                {
                    sumScore += oneScore;
                    studentCount++;
                    Console.WriteLine("Recorded, enter next score");
                }
            } while (score != "-1");

            if (studentCount > 0)
            {
                averageScore = (double)sumScore / studentCount;
                Console.WriteLine("Average score is " + averageScore);
            } else
            {
                Console.WriteLine("Nothing to calculate");
            }
            Console.WriteLine("Bye-bye!");
        }

        public static int ScoreParser(string strScore)
        {
            int score;
            if (!int.TryParse(strScore, out score))
            {
                score = -2;
            }
            return score;
        }
    }
}
