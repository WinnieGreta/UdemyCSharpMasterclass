using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment33
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Wathching the TV!");
            }
            else
            {
                Console.WriteLine("Please turn the TV on to watch it!");
            }
        }
    }
}
