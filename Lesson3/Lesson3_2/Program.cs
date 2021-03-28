using System;

namespace Lesson3_2
{
    class Program
    {
        private static string[,] phoneBook = {
            { "Ivan Ivanov"       , "79991234567" },
            { "Petr Petrov"       , "74012457896" },
            { "Sidor Sidorov"     , "79004563217" },
            { "Roga & Kopita Inc.", "78124523698" },
            { "MicroZaim"         , "78005353535" },
        };

        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine().ToLower();

            // find only first entry
            bool found = false;
            int i = 0;
            while (!found && i < phoneBook.GetLength(0))
            {
                if (phoneBook[i, 0].ToLower().Contains(name))
                {
                    Console.WriteLine("Found:");
                    Console.WriteLine($"{phoneBook[i, 0]}: {phoneBook[i, 1]}");

                    found = true;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine();

            // find all entrys
            found = false;
            for (i = 0; i < phoneBook.GetLength(0); i++)
            {
                if (phoneBook[i, 0].ToLower().Contains(name))
                {
                    if (!found)
                    {
                        Console.WriteLine("Found:");
                        found = true;
                    }
                    Console.WriteLine($"{phoneBook[i, 0],-20}: {phoneBook[i, 1]}");
                }
            }
        }
    }
}
