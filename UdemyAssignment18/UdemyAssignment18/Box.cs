using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment18
{
    internal class Box
    {
        public Box()
        {

        }

        public Box(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public int FrontSurface
        {
            get
            {
                return Height * Length;
            }
        }

        public int Volume
        {
            get
            {
                return this.Height * this.Width * this.Length;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, so the volume is {3}.", Length, Height, Width, Volume);
        }
    }
}
