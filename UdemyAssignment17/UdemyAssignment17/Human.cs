using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment17
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;
        
        public Human()
        {
            Console.WriteLine("Default human created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            if (firstName == null)
            {
                Console.Write("Hi, I'm default human");
            }
            else
            {
                Console.Write($"Hi, my name is {firstName}");
                if (lastName != null)
                {
                    Console.Write($" {lastName}");
                    if (eyeColor != null)
                    {
                        Console.Write($". My eye color is {eyeColor}");
                        if (age != 0)
                        {
                            if (age == 1)
                            {
                                Console.Write(". I'm 1 year old");
                            } 
                            else
                            {
                                Console.Write($". I'm {age} years old");
                            }
                        }
                    }
                }
            }
            Console.WriteLine(".");
        }
    }
}
