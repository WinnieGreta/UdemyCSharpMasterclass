using System;

namespace UdemyAssignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login(Registration());
        }

        public static string[] Registration()
        {
            string[] userData = new string[2];
            Console.WriteLine("Register for our services rigth now!");
            Console.WriteLine("Please enter your new username");
            userData[0] = Console.ReadLine();
            Console.WriteLine("Please enter your new password");
            userData[1] = Console.ReadLine();
            Console.WriteLine("Data recorder");
            return userData;
        }

        public static void Login(string[] userData)
        {
            string username = "";
            string password = "";
            Console.WriteLine("--------");
            Console.WriteLine("To use our services you need to login");
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            if (username == userData[0])
            {
                Console.WriteLine("Please enter your password");
                password = Console.ReadLine();
                if(password == userData[1])
                {
                    Console.WriteLine("Congratulations, you're all set!");
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            else
            {
                Console.WriteLine("Incorrect username");
            }
        }
    }
}
