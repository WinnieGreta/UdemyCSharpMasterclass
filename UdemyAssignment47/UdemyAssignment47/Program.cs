using System;

namespace UdemyAssignment47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("player1");
            Player player2 = new Player("player2");

            GameEventManager.TriggerGameStart();
            Console.WriteLine("The game is runnung...");
            Player player3 = new Player("player3");
            GameEventManager.TriggerGameOver();
        }
    }
}
