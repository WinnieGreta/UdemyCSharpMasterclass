using System;

namespace UdemyAssignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human("Alesia");
            Human human3 = new Human("Anna", "Frank");
            Human human4 = new Human("Franz", "Ferdiant", "brown");
            Human human5 = new Human("Mark", "Brown", "blue", 1);
            Human human6 = new Human("Jeff", "Bezos", "grey", 69);

            human1.IntroduceMyself();
            human2.IntroduceMyself();
            human3.IntroduceMyself();
            human4.IntroduceMyself();
            human5.IntroduceMyself();
            human6.IntroduceMyself();
        }
    }
}
