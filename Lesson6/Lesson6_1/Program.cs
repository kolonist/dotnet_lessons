using System;
using System.Diagnostics;
using System.Linq;

namespace Lesson6_1
{
	/*
		Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
		позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
		помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
		утилиты Windows tasklist и taskkill.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Process[] procList = Process.GetProcesses();

			// no arguments, show tasks
			if (args.Length == 0)
			{
				Console.WriteLine("PId    Start time           Proc name");
				foreach (Process proc in procList)
				{
					Console.WriteLine($"{proc.Id,5}  {proc.StartTime,19}  {proc.ProcessName}");
				}
				Console.WriteLine("Use PId or Proc name as parameter to terminate process");
			}
			// kill task
			else
			{
				// process to kill
				Process? proc = null;

				try
				{
					// find process by PId
					int pid = Convert.ToInt32(args[0]);
					proc = Array.Find(procList, (Process p) => p.Id == pid);
				}
				catch (FormatException)
				{
					// find process by procName
					string procName = args[0];
					proc = Array.Find(procList, (Process p) => p.ProcessName == procName);
				}

				try
				{
					proc.Kill();
					proc.WaitForExit();
					Console.WriteLine($"Process \"{proc.ProcessName}\" exited");
				}
				catch (NullReferenceException)
				{
					Console.WriteLine("No such process");
				}
			}			
		}
	}
}