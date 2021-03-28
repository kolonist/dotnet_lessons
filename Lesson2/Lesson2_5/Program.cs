using System;
using System.Collections.Generic;

namespace Lesson2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> winter = new List<byte> { 12, 1, 2 };

            Console.Write("Current month number (1 to 12): ");
            byte monthNumber = Convert.ToByte(Console.ReadLine());

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("There is no such month");
                return;
            }

            // get month name
            string month = (new DateTime(1970, monthNumber, 1)).ToString("MMMM");

            Console.Write($"Min temp: ");
            decimal minTemp = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"Max temp: ");
            decimal maxTemp = Convert.ToDecimal(Console.ReadLine());

            // calc average temprerature
            decimal averageTemp = (decimal) (maxTemp + minTemp) / 2;

            Console.WriteLine($"Average tempreture is {averageTemp:0.00}");

            if (winter.Contains(monthNumber) && (averageTemp > 0))
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
