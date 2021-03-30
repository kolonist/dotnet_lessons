using System;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Lesson5_5
{
	/*
		Список задач (ToDo-list):
		● написать приложение для ввода списка задач;
		● задачу описать классом ToDo с полями Title и IsDone;
		● на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить
		  из него массив имеющихся задач и вывести их на экран;
		● если задача выполнена, вывести перед её названием строку «[x]»;
		● вывести порядковый номер для каждой задачи;
		● при вводе пользователем порядкового номера задачи отметить задачу с этим
		  порядковым номером как выполненную;
		● записать актуальный массив задач в файл tasks.json/xml/bin.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			const string filename = "tasks.json";
			ToDo[] tasks = ReadTasks(filename) ?? new ToDo[]{};

			bool quit = false;
			while (!quit)
			{
				// display ToDo list
				Console.WriteLine("Todo list:");
				for (int i = 0; i < tasks.Length; i++)
				{
					Console.WriteLine($"{i + 1,2}: {tasks[i].ToString()}");
				}

				// display menu
				Console.WriteLine("[q] Quit    [+] Add new ToDo    [x] Mark task as done");
				char key = Console.ReadKey().KeyChar;
				Console.WriteLine();

				// perform action
				switch (key)
				{
					// save ToDo list and quit from application
					case 'q':
						var options = new JsonSerializerOptions
						{
							Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
							WriteIndented = true
						};
						byte[] json = JsonSerializer.SerializeToUtf8Bytes(tasks, options);
						File.WriteAllBytes(filename, json);
						quit = true;
						break;

					// add new ToDo task
					case '+':
						Console.Write("Enter task: ");
						string title = Console.ReadLine();

						ToDo task = new(title);
						
						Array.Resize(ref tasks, tasks.Length + 1);
						tasks[^1] = task;
						
						break;
					
					// mark task as Done
					case 'x':
						if (tasks.Length > 0)
						{
							bool correct = false;
							while (!correct)
							{
								Console.Write("Enter task number: ");
								int taskNum = Convert.ToInt32(Console.ReadLine());

								if (taskNum > 0 && taskNum <= tasks.Length)
								{
									tasks[taskNum - 1].MakeDone();
									correct = true;
								}
								else
								{
									Console.WriteLine("No task with this number, please try again");
								}
							}
						}
						else
						{
							Console.WriteLine("No tasks yet, you should add one");
						}
						break;
					
					// unknown command
					default:
						Console.WriteLine("Unknown command, please try again");
						break;
				}
			}
		}
		
		
		private static ToDo[]? ReadTasks(string filename)
		{
			try
			{
				byte[] json = File.ReadAllBytes(filename);
				ToDo[] tasks = JsonSerializer.Deserialize<ToDo[]>(json);
				return tasks;
			}
			catch
			{
				return null;
			}
		}
	}
}