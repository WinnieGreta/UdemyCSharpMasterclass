
using System;

namespace UdemyAssignment59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromKPI();
            Console.WriteLine("Put in university Id");
            um.AllStudentsFromInputUniversity(Console.ReadLine());
        }
    }
}
