using System;
using System.IO;
using System.Collections.Generic;

namespace Lesson5_4
{
	/*
		Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с
		рекурсией и без.
	*/
	class Program
	{
		static void Main(string[] args)
		{
			const string filenameRecursion = "../../../recursion.txt";
			const string filenameFlat = "../../../flat.txt";

			string dir;
			if (args.Length > 0)
			{
				dir = args[0];
			}
			else
			{
				Console.Write("Enter directory name: ");
				dir = Console.ReadLine();
			}

			if (!Directory.Exists(dir))
			{
				Console.WriteLine("Directory \"{dir}\" not exists");
				return;
			}

			string[] entriesRecursion = getDirContent(dir);
			File.WriteAllLines(filenameRecursion, entriesRecursion);
			Console.WriteLine($"Recursion version in file \"{filenameRecursion}\"");
			
			string[] entriesFlat = Directory.GetFileSystemEntries(dir, "*", SearchOption.AllDirectories);
			File.WriteAllLines(filenameFlat, entriesFlat);
			Console.WriteLine($"Flat version in file \"{filenameFlat}\"");
		}


		private static string[] getDirContent(string dirname)
		{
			List<string> fileList = new();

			string[] entries = Directory.GetFileSystemEntries(dirname, "*", SearchOption.TopDirectoryOnly);
			foreach (string entry in entries)
			{
				fileList.Add(entry);

				if (Directory.Exists(entry))
				{
					fileList.AddRange(getDirContent(entry));
				}
			}

			return fileList.ToArray();
		}
	}
}