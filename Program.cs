using System;

namespace Consolehomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin:");
            string userName = Console.ReadLine();

            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();

            User user = new User(userName, password);
            user.UserName = "hhehcjvjk";
            user.Password = "5cvqregt";
        }

    }
}



