using System;

namespace UdemyAssignment25_tictactoe
{
    internal class Program
    {
        static readonly string[,] startingField =
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };

        static void Main(string[] args)
        {
            StartGame();
        }

        private static void DrawField(string[,] field)
        {
            Console.Clear();
            for(int i = 0; i < 9; i++)
            {
                // we are checking when row number should change
                int j = i == 1 ? 0 : i == 4 ? 1 : 2;
                switch(i % 3)
                {
                    case 0:
                        Console.WriteLine("     |     |     ");
                        break;
                    case 1:
                        Console.WriteLine("  " + field[j, 0] + "  |  " + field[j, 1] + "  |  " + field[j, 2] + "  ");
                        break;
                    case 2:
                        if (i == 8)
                        {
                            Console.WriteLine("     |     |     ");
                        } 
                        else
                        {
                            Console.WriteLine("_____|_____|_____");
                        }
                        break;

                }
            }
        }

        private static void StartGame()
        {
            string[,] playingField = new string[3, 3];
            InitializeField(startingField, playingField);
            bool playerOneTurn = true;
            while (!GameFinished(playingField))
            {
                DrawField(playingField);
                MakeAMove(playerOneTurn, playingField);
                playerOneTurn = !playerOneTurn;
            }
            DrawField(playingField);
            if (!PlaceLeft(playingField))
            {
                Console.WriteLine("Game Over! It's a tie!");
            }
            else
            {
                Console.WriteLine("Game Over! Player {0} won!", !playerOneTurn ? "1" : "2");
            }
            OfferRematch();

        }

        private static void MakeAMove(bool playerOneTurn, string[,] playingField)
        {
            Console.WriteLine("Player {0}, choose your spot.", playerOneTurn ? "1" : "2");
            bool correctInput = false;
            int moveSpot;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out moveSpot))
                {
                    if (moveSpot >= 0 && moveSpot < 10)
                    {
                        if (TryPuttingMarkOnField(playingField, moveSpot, playerOneTurn))
                        {
                            correctInput = true;
                        }
                        else
                        {
                            Console.WriteLine("There's already a mark here. Choose from free slots on a field.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can't make a move outside the field. Please enter a number from 1 to 9.");
                    }
                }
                else 
                {
                    Console.WriteLine("I can't understand you. Please enter a number from 1 to 9.");
                }
            } while (!correctInput);
        }

        public static bool GameFinished(string[,] field)
        {
            if (HorizontalGameOver(field) || VerticalGameOver(field) || DiagonalGameOver(field) || !PlaceLeft(field))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int[] FindPlaceOnField(int fieldNumber)
        {
            int[] place = new int[2];
            place[0] = (fieldNumber - 1) / 3;
            place[1] = (fieldNumber - 1) % 3;
            return place;
        }

        private static bool TryPuttingMarkOnField(string[,] field, int moveSpot, bool playerOneTurn)
        {
            int[] place = new int[2];
            place = FindPlaceOnField(moveSpot);

            if(IsPlaceFree(place, field))
            {
                if (playerOneTurn)
                {
                    field[place[0], place[1]] = "X";
                }
                else
                {
                    field[place[0], place[1]] = "O";
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPlaceFree(int[] place, string[,] field)
        {
            return int.TryParse(field[place[0], place[1]], out _);
        }

        private static bool HorizontalGameOver(string[,] field)
        {
            for(int i = 0; i < field.GetLength(0); i++)
            {
                if (field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool VerticalGameOver(string[,] field)
        {
            for(int i = 0; i < field.GetLength(1); i++)
            {
                if (field[0, i] == field[1, i] && field[1, i] == field[2, i])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DiagonalGameOver(string[,] field)
        {
            if((field[0,0] == field[1,1] && field[1,1] == field[2,2])
                || (field[0,2] == field[1,1] && field[1,1] == field[2,0]))
            {
                return true;
            }
            return false;
        }

        private static bool PlaceLeft(string[,] field)
        {
            foreach(string s in field)
            {
                if (s != "X" && s != "O")
                {
                    return true;
                }
            }
            return false;
        }

        private static void OfferRematch()
        {
            Console.WriteLine("Want to play again? (y/n)");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                StartGame();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Bye-bye!");
            }
            else
            {
                Console.WriteLine("I'll consider this as a no");
            }
        }

        private static void InitializeField(string[,] standardField, string[,] newField)
        {
            for(int i = 0; i < standardField.GetLength(0); i++)
            {
                for(int j = 0; j < standardField.GetLength(1); j++)
                {
                    newField[i,j] = standardField[i,j];
                }
            }
        }
    }
}
