using System;

namespace UdemyAssignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human arya = new Human();
            arya.firstName = "Arya";
            arya.lastName = "Stark";

            Human vova = new Human();
            vova.firstName = "Vova";
            vova.lastName = "Crass";

            arya.IntroduceMyself();
            vova.IntroduceMyself();
        }
    }
}
