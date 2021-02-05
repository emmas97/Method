using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Hello_user(userName);
        }

        private static void Hello_user(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
