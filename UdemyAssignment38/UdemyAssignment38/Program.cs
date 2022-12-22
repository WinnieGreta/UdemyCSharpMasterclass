using System;
using System.Collections.Generic;

namespace UdemyAssignment38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car0 = new Car(20, "Blue");
            BMW car1 = new BMW(30, "Red", "001");
            Audi car2 = new Audi(35, "Yellow", "002");

            car0.ShowDetails();
            car0.Repair();
            car1.ShowDetails();
            car1.Repair();
            car2.ShowDetails();

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car car3 = new Audi(100, "pink", "A5");
            Car car4 = new BMW(150, "magenta", "R7");

            car3.ShowDetails();
            car4.ShowDetails();

            Audi car5 = new Audi(310, "silver", "M5");
            car5.ShowDetails();

            Car carB = (Car)car5;
            carB.ShowDetails();
        }
    }
}
