﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment38
{
    internal class Audi : Car
    {
        public string Model { get; set; }
        private string brand = "Audi";

        public Audi()
        {

        }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("HP is {0}, color is {1}, brand {2} model {3}", this.HP, this.Color, brand, this.Model);
        }

        public new void Repair()
        {
            Console.WriteLine("{0} {1} is repaired!", brand, this.Model);
        }
    }
}

