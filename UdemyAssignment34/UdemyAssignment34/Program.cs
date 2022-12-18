using System;

namespace UdemyAssignment34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Arya", 3);
            Console.WriteLine($"This is my cat {cat.Name}. She's {cat.Age} years old.");
            cat.Play();
            cat.Eat();
            cat.MakeSound();
            cat.IsHungry = false;
            cat.Eat();
            cat.IsHappy = false;
            cat.Play();
            cat.IsHappy = true;
        }
    }
}
