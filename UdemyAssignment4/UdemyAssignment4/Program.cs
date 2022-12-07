using System;

namespace UdemyAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteVar = 240;
            sbyte sbyteVar = -120;
            int intVar = 2_000_000_000;
            uint uintVar = 4_000_000_000;
            short shortVar = -32000;
            ushort ushortVar = 65000;
            long longVar = -570;
            ulong ulongVar = 8000;
            float floatVar = 2.45f;
            double doubleVar = 2.45;
            char charVar = 'f';
            bool boolVar = true;
            string stringVar = "Press to pay respect";
            decimal decimalVar = 1_000_000_000_000_000;

            string secondTask1 = "I control text";
            string secondTask2 = "3267";
            int secondTask2ToInt = Int32.Parse(secondTask2);

            Console.WriteLine(byteVar);
            Console.WriteLine(sbyteVar);
            Console.WriteLine(intVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(shortVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(longVar);
            Console.WriteLine(ulongVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(stringVar);
            Console.WriteLine(decimalVar);

            Console.WriteLine(secondTask1);
            Console.WriteLine(secondTask2ToInt);

        }
    }
}
