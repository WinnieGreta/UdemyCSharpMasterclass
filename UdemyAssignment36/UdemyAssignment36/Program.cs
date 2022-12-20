using System;

namespace UdemyAssignment36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Wazowski", "Mike", 27);
            Boss boss = new Boss("Togami", "Byakuya", 300, "Porche");
            Trainee trainee = new Trainee("Fukawa", "Toko", 13, 21, 19);

            employee.Work();
            employee.Pause();

            boss.Work();
            boss.Lead();

            trainee.Work();
            trainee.Learn();

        }
    }
}
