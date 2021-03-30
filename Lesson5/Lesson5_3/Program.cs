using System;
using System.IO;
using System.Collections.Generic;

namespace Lesson5_3
{
	/*
		Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный
		файл.
	*/
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter filename: ");
			string filename = Console.ReadLine();

			Console.Write("Enter numbers 0-255 dividing by space (e.g. \"4 8 15 16 23 42\"): ");
			string[] textNumbers = Console.ReadLine().Trim().Split(' ');

			// create byte array
			List<byte> numbers = new();
			foreach (string textNumber in textNumbers)
			{
				if (textNumber != "")
				{
					numbers.Add(Convert.ToByte(textNumber));
				}
			}
			
			File.WriteAllBytes(filename, numbers.ToArray());
		}
	}
}