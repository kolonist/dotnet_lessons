using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            DateTime date = DateTime.Now;

            Console.WriteLine($"Привет, {username}, сегодня {date.ToString("dd.MM.yyy")}");
        }
    }
}
