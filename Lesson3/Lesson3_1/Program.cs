using System;

namespace Lesson3_1
{
    class Program
    {
        private static int[,] arr = { {  1,  2,  3,  4,  5 },
                                      {  6,  7,  8,  9, 10 },
                                      { 11, 12, 13, 14, 15 },
                                      { 16, 17, 18, 19, 20 },
                                      { 21, 22, 23, 24, 25 },
                                      { 21, 22, 23, 24, 25 },
                                    };

        static void Main(string[] args)
        {
            // this is what you probably expect
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"[{i}, {j}]: {new String(' ', j * 2)} {arr[i, j],2}");
                    }
                }
            }
            Console.WriteLine();

            // this is what it really should be
            int minDimension = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
            for (int i = 0; i < minDimension; i++)
            {
                Console.WriteLine($"[{i}, {i}]: {new String(' ', i * 2)} {arr[i, i],2}");
            }

        }
    }
}
