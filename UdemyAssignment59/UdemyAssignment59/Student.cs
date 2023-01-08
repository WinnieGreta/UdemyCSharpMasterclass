using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment59
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // foreign key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0}, {1}, {2} years old, studying at {3} with Id {4}", Name, Gender, Age, UniversityId, Id);
        }
    }
}
