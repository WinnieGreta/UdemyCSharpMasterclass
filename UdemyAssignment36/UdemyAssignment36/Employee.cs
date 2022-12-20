using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment36
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            this.Name = "Doe";
            this.FirstName = "Jane";
            this.Salary = 10;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("{0} {1} is working.", this.FirstName, this.Name);
        }

        public virtual void Pause()
        {
            Console.WriteLine("{0} {1} has paused.", this.FirstName, this.Name);
        }
    }
}
