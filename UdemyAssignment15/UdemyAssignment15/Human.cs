using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment15
{
    internal class Human
    {
        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, my first name is {0} and my last name is {1}", firstName, lastName);
        }
    }
}
