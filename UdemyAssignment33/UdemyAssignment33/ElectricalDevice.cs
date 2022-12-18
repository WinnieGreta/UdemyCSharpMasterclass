using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment33
{
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice (bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
