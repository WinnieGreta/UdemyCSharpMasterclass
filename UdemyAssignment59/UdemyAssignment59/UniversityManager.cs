using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAssignment59
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager() 
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "KPI" });
            universities.Add(new University { Id = 2, Name = "NAUKMA" });
            students.Add(new Student { Id = 1, Name = "Greta", Age = 26, Gender = "female", UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Alvin", Age = 17, Gender = "male", UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Alex", Age = 20, Gender = "unknown", UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Mike", Age = 22, Gender = "male", UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Rosa", Age = 19, Gender = "female", UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Jessie", Age = 21, Gender = "unknown", UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students:");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female students:");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
    }
}
