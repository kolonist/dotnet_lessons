using System;

namespace Lesson3_4
{
    class Program
    {
        private static char[,] field = {
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'x', 'O' },
            { 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O', 'O' },
            { 'O', 'X', 'X', 'X', 'X', 'O', 'O', 'O', 'X', 'O' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' },
            { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O', 'O' },
            { 'X', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X' },
            { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
            { 'X', 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O' },
            { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
        };

        static void Main(string[] args)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    Console.Write($" {field[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
