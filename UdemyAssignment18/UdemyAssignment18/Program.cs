using System;

namespace UdemyAssignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.Width = 5;
            box1.Height = 2;
            box1.Length = 3;

            Console.WriteLine("Box 1 volume is " + box1.Volume);
            Console.WriteLine("Front surface of box 1 is " + box1.FrontSurface);

            box1.DisplayInfo();

            Box box2 = new Box(10, 2, 7);
            Console.WriteLine("Front surface of box 2 is " + box2.FrontSurface);
            box2.DisplayInfo();
        }
    }
}
