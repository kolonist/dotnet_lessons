using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isOdd = n % 2 == 0;

            Console.Write("Number is ");
            Console.WriteLine(isOdd ? "odd" : "even");
        }
    }
}
