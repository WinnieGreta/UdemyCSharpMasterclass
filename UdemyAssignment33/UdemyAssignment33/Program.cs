using System;

namespace UdemyAssignment33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio1 = new Radio(true, "Brand1");
            Radio radio2 = new Radio(false, "Brand2");

            TV tv1 = new TV(false, "Brand3");
            TV tv2 = new TV(true, "Brand4");

            radio1.ListenRadio();
            radio2.ListenRadio();
            radio2.SwitchOn();
            radio2.ListenRadio();

            tv1.WatchTV();
            tv2.WatchTV();
            tv2.SwitchOff();
            tv2.WatchTV();
        }
    }
}
