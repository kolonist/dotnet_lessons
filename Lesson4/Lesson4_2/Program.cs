using System;

namespace Lesson4_2
{
    /*
        Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести
        результат на экран.
    */
    class Program
    {
        private static int Sum(string[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToInt32(numbers[i]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter integer numbers dividet by space (e.g. 7 4 0 9): ");
            string strings = Console.ReadLine().Trim();

            string[] stringNumbers = strings.Split(' ');
            int sum = Sum(stringNumbers);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
