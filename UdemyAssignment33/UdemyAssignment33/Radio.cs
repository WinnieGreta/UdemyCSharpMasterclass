using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment33
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Please turn the radio on to listen to it!");
            }
        }
    }
}
