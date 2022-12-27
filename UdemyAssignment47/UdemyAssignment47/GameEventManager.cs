using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment47
{
    internal class GameEventManager
    {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started");
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if(OnGameOver != null)
            {
                Console.WriteLine("The game is over");
                OnGameOver();
            }
        }
    }
}
