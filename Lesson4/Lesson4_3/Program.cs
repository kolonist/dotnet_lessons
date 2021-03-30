using System;

namespace Lesson4_3
{
    /*
        Написать метод по определению времени года. На вход подаётся число – порядковый номер
        месяца. На выходе — значение из перечисления (enum) — ​Winter, Spring, Summer,
        Autumn​
        . Написать метод, принимающий на вход значение из этого перечисления и
        возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
        ввести с клавиатуры номер месяца и вывести название времени года. Если введено
        некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
    */
    class Program
    {
        [Flags]
        public enum Season {
            Winter,
            Spring,
            Summer,
            Autumn​
        }

        // WinterMonths not used here but we definitely should define it for
        // future use in case of getSeason() method refactoring
        private static readonly int[] WinterMonths = { 12,  1,  2 };
        private static readonly int[] SpringMonths = {  3,  4,  5 };
        private static readonly int[] SummerMonths = {  6,  7,  8 };
        private static readonly int[] AutumnMonths = {  9, 10, 11 };

        /*
            According to the task this method could (and probably should) be
            written the same way as getSeasonName() was (using switch-case).
            But it was written this way because in similar tasks values
            and their lists could be more complex. There could be hundreds and
            thousands values which could be read from files or from DB. So its
            ideologically better to perform such tasks this way.
        */
        public static Season getSeason(byte month)
        {
            // Use Winter by default.
            //
            // No matter what season used by default, cause anyway we cover all
            // existing months.
            //
            // But really its totally wrong in production use. We need to
            // check `month` parameter to be sure it is in range from 1 to 12
            // and return special value if it is not or throw corresponding
            // exception.
            Season season = Season.Winter;

            if (Array.IndexOf(SpringMonths, month) >= 0)
            {
                season = Season.Spring;
            }
            else if (Array.IndexOf(SummerMonths, month) >= 0)
            {
                season = Season.Summer;
            }
            else if (Array.IndexOf(AutumnMonths, month) >= 0)
            {
                season = Season.Autumn​;
            }

            return season;
        }

        public static string getSeasonName(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    return "зима";
                case Season.Spring:
                    return "весна";
                case Season.Summer:
                    return "лето";
                case Season.Autumn​:
                    return "осень";

                // it could never be reached according to business logic of this
                //  method but it is strongly needed by compiler
                default:
                    return "Ошибка: несуществующий сезон";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Month number (1 to 12): ");
            byte month = Convert.ToByte(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }

            Season season = getSeason(month);
            string seasonName = getSeasonName(season);

            Console.WriteLine($"Season name is \"{seasonName}\"");
        }
    }
}
