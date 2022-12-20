using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment36
{
    internal class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee()
        {

        }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} is studying for {1} hours", this.Name, this.SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("{0} is working for {1} hours", this.Name, this.WorkingHours);
        }
    }
}
