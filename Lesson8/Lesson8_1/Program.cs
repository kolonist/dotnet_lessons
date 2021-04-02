using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Lesson8_1
{
	/*
		Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
		приложения (application-scope). Запросить у пользователя имя, возраст и род деятельности, а затем
		сохранить данные в настройках. При следующем запуске отобразить эти сведения. Задать
		приложению версию и описание.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			var appSettings = ConfigurationManager.AppSettings;
			Console.WriteLine(appSettings["greetings"]);

			// show name, age and occupation
			if (appSettings["name"] != null)
			{
				Console.WriteLine($"Your name: {appSettings["name"]}");
			}
			
			if (appSettings["age"] != null)
			{
				Console.WriteLine($"Your name: {appSettings["age"]}");
			}

			if (appSettings["occupation"] != null)
			{
				Console.WriteLine($"Your name: {appSettings["occupation"]}");
			}
			
			// enter name, age and occupation
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();

			Console.Write("Enter your age: ");
			string age = Console.ReadLine();
			
			Console.Write("Enter you occupation: ");
			string occupation = Console.ReadLine();

			
			// write to config
			var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			
			configFile.AppSettings.Settings.Remove("name");
			configFile.AppSettings.Settings.Add("name", name);

			configFile.AppSettings.Settings.Remove("age");
			configFile.AppSettings.Settings.Add("age", age);
			
			configFile.AppSettings.Settings.Remove("occupation");
			configFile.AppSettings.Settings.Add("occupation", occupation);
			
			configFile.Save();
		}
	}
}