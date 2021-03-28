using System;

namespace Lesson4_1
{
    /*
        Написать метод ​GetFullName(string
        firstName,
        string lastName, string
        patronymic)​, принимающий на вход ФИО в разных аргументах и возвращающий
        объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
        3–4 разных ФИО.
    */
    class Program
    {
        private static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иван" , "Иванов" , "Иванович"));
            Console.WriteLine(GetFullName("Петр" , "Петров" , "Петрович"));
            Console.WriteLine(GetFullName("Сидор", "Сидоров", "Сидорович"));
            Console.WriteLine(GetFullName("Джон" , "Локк"   , "Биллович"));
        }
    }
}
