using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment38
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.HP = 10;
            this.Color = "Green";
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("HP is {0}, color is {1}", this.HP, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
