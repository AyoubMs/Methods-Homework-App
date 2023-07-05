using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    public static class UserMethods
    {
        public static string GetUserName()
        {
            Console.Write("What is your name (or exit): ");
            string userName = Console.ReadLine();
            return userName;
        }

        public static void SayHello(string userName)
        {
            Console.WriteLine($"your name is {userName}");
        }
    }
}
