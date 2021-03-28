using System;

namespace Lesson2_2
{
    class Program
    {
        [Flags]
        public enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }

        static void Main(string[] args)
        {
            Console.Write("Current month number: ");
            byte monthNumber = Convert.ToByte(Console.ReadLine());

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("There is no such month");
                return;
            }

            // method 1, only for english named months
            // WTF #1: this works with russian names too
            Console.WriteLine($"Current month is \"{(Months) monthNumber}\"");

            // method 2, probably the best because of internationalization
            {
                DateTime date = new DateTime(1970, monthNumber, 1);
                string month = date.ToString("MMMM");
                Console.WriteLine($"Current month is \"{month}\"");
            }

            // method 3, simplest but the longest one
            // also difficult for maintenance
            {
                string month;
                switch (monthNumber)
                {
                    case 1:
                        month = "Январь";
                        break;
                    case 2:
                        month = "Февраль";
                        break;
                    case 3:
                        month = "Март";
                        break;
                    case 4:
                        month = "Апрель";
                        break;
                    case 5:
                        month = "Май";
                        break;
                    case 6:
                        month = "Июнь";
                        break;
                    case 7:
                        month = "Июль";
                        break;
                    case 8:
                        month = "Август";
                        break;
                    case 9:
                        month = "Сентябрь";
                        break;
                    case 10:
                        month = "Октябрь";
                        break;
                    case 11:
                        month = "Ноябрь";
                        break;
                    case 12:
                        month = "Декабрь";
                        break;

                    // we have input validation so this case has no meaning here
                    default:
                        Console.WriteLine("There is no such month");
                        return;
                }
                Console.WriteLine($"Current month is \"{month}\"");
            }
        }
    }
}
