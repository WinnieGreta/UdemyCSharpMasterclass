using System;
using System.Collections;

namespace UdemyAssignment29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();
            InsertIntoHashtable(students, studentsTable);
            CheckOnHashtable(studentsTable);
        }

        static void InsertIntoHashtable(Student[] students, Hashtable studentsTable)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if(studentsTable.ContainsKey(students[i].Id))
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists");
                }
                else
                {
                    studentsTable.Add(students[i].Id, students[i]);
                }
            }
        }

        static void CheckOnHashtable(Hashtable studentsTable)
        {
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student student = (Student)entry.Value;
                Console.WriteLine("Student id {0}, name {1}, GPA {2}.", student.Id, student.Name, student.GPA);
            }
        }
    }
}
