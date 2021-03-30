using System;
using System.IO;

namespace Lesson5_2
{
	/*
		Написать программу, которая при старте дописывает текущее время в файл
		«startup.txt».
	 */
	class Program
	{
		static void Main(string[] args)
		{
			const string filename = "startup.txt";

			string date = DateTime.Now.ToString("hh:mm:ss\n");
			
			File.AppendAllText(filename, date);
			
			Console.WriteLine($"{date} was written to \"{filename}\"");
		}
	}
}
