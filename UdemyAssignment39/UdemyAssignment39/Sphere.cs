using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment39
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return Math.PI * (double)4 / (double)3 * Math.Pow(Radius, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The radius of a shpere is {Radius}");
        }
    }
}
