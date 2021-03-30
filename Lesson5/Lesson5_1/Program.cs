using System;
using System.IO;

namespace Lesson5_1
{
	/*
		Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter filename: ");
			string filename = Console.ReadLine();

			Console.Write("Enter text: ");
			string text = Console.ReadLine();

			File.WriteAllText(filename, text);
			Console.WriteLine("Text was saved to file");
		}
	}
}