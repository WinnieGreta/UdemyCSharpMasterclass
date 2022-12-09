using System;

namespace UdemyAssignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            FindState(temperature);

            temperature += 10;
            FindState(temperature);
            
            temperature += 100;
            FindState(temperature);
        }

        public static void FindState(int temp)
        {
            string stateOfMatter;
            stateOfMatter = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine(stateOfMatter);
        }
    }
}
