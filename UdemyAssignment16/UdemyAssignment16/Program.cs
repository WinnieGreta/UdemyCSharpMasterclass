using System;

namespace UdemyAssignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human arya = new Human("Arya", "Stark", "grey", 3);
            Human greta = new Human("Greta", "Winnie", "green", 26);

            arya.IntroduceMyself();
            greta.IntroduceMyself();
        }
    }
}
