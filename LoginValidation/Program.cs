using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Adming";
            string password = "pass1234";
            string userName, userPassword;
            int Number = 3;

            while(Number>0)
            {
                Console.WriteLine("Enter your username:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                userPassword = Console.ReadLine();
                if (login != userName || password!=userPassword)
                {
                    Console.WriteLine("Oops. Something went wrong.");
                    Number = Number - 1;
                    Console.WriteLine("You have ",Number," tries.");
                }
                else
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
            }

        }
    }
}
