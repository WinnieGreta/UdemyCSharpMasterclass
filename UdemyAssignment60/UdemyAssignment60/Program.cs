using System;
using System.Linq;
using System.Xml.Linq;

namespace UdemyAssignment60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Major>Physics</Major>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Age>25</Age>
                        <University>Yale</University>
                        <Major>Computer Science</Major>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                        <Major>Computer Science</Major>
                    </Student>
                    <Student>
                        <Name>Greta</Name>
                        <Age>22</Age>
                        <University>Beijing Tech</University>
                        <Major>Electrical Engineering</Major>
                    </Student>
                </Students>";

            XDocument studentXdoc = new XDocument();
            studentXdoc = XDocument.Parse(studentXML);

            var students = from student in studentXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Major = student.Element("Major").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from university {2} on major {3}", student.Name, student.Age, student.University, student.Major);
            }

            var studentsOrder = from student in studentXdoc.Descendants("Student") orderby student.Element("Name").Value
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Major = student.Element("Major").Value
                           };

            Console.WriteLine("Ordered students by name");

            foreach (var student in studentsOrder)
            {
                Console.WriteLine("Student {0} with age {1} from university {2} on major {3}", student.Name, student.Age, student.University, student.Major);
            }

            Console.WriteLine("Ordered students by age");

            var sortedStudents = from student in students orderby student.Age select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from university {2} on major {3}", student.Name, student.Age, student.University, student.Major);
            }
        }
    }
}
