using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current month number (1 to 12): ");
            byte monthNumber = Convert.ToByte(Console.ReadLine());


            Console.Write($"Min temp: ");
            decimal minTemp = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Max temp: ");
            decimal maxTemp = Convert.ToDecimal(Console.ReadLine());

            decimal averageTemp = (decimal) (maxTemp + minTemp) / 2;
            Console.WriteLine($"Average tempreture is {averageTemp:0.00}");
        }
    }
}
