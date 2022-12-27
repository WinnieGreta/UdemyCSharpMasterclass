using System;
using System.Collections.Generic;

namespace UdemyAssignment46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Run
    {
        // TODO

        /*static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b; */

        static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>()
        {
            {"+", (a, b) => a + b},
            {"-", (a, b) => a - b},
            {"/", (a, b) => a / b},
            {"*", (a, b) => a * b}
        };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            else
            {
                return null;
            }
        }
    }

}
