using System;

namespace Lesson2_6
{
    class Program
    {
        [Flags]
        private enum Week
        {
            Monday    = 0b_0000001,
            Tuesday   = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday  = 0b_0001000,
            Friday    = 0b_0010000,
            Saturday  = 0b_0100000,
            Sunday    = 0b_1000000
        }

        static void Main(string[] args)
        {
            Week officeA, officeB, officeC;

            // all week 7/7
            officeA = 0
                | Week.Monday | Week.Tuesday | Week.Wednesday | Week.Thursday
                | Week.Friday | Week.Saturday | Week.Sunday;

            // only work days 5/7
            officeB = 0
                | Week.Monday | Week.Tuesday | Week.Wednesday | Week.Thursday
                | Week.Friday;

            // weekend days are sunday and monday
            officeC = 0
                | Week.Tuesday | Week.Wednesday | Week.Thursday
                | Week.Friday | Week.Saturday;

            Console.WriteLine($"Timetable A: {officeA}");
            Console.WriteLine($"Timetable B: {officeB}");
            Console.WriteLine($"Timetable C: {officeC}");
            Console.WriteLine();

            // now check if user choosed week day is work day
            Console.Write("Enter day number (1 to 7): ");
            byte weekDayNumber = Convert.ToByte(Console.ReadLine());

            if (weekDayNumber < 1 || weekDayNumber > 7)
            {
                Console.WriteLine("No such day of week");
                return;
            }

            // convert weekDayNumber to Week
            // assume that numer of day is position of "1" in Week bitmask
            Week weekDay = (Week) (1 << (weekDayNumber - 1));

            // check all offices for work day
            if ((officeA & weekDay) != 0)
            {
                Console.WriteLine($"{weekDay} is work day at Office A");
            }

            if ((officeB & weekDay) != 0)
            {
                Console.WriteLine($"{weekDay} is work day at Office B");
            }

            if ((officeC & weekDay) != 0)
            {
                Console.WriteLine($"{weekDay} is work day at Office C");
            }
        }
    }
}
