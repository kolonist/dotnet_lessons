using System;

namespace Lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();

            string reversed = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed += s[i];
            }

            Console.WriteLine($"              {reversed}");
        }
    }
}
