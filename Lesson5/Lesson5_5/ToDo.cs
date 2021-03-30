using System;

namespace Lesson5_5
{
	public class ToDo
	{
		/**
		 * <summary>Task description</summary>
		 */
		public string Title { get; set; }


		/**
		 * <summary>Flag to show if task is done</summary>
		 */
		public bool IsDone  { get; set; }


		/**
		 * <summary>Create not performed task</summary>
		 * <param name="title">Description of task. Default is empty string.</param>
		 */
		public ToDo(string title = "")
		{
			this.Title = title;
			this.IsDone = false;
		}


		/**
		 * <summary>Mark task as done</summary>
		 */
		public void MakeDone()
		{
			this.IsDone = true;
		}


		/**
		 * <summary>Create text representation of task to show it on console</summary>
		 */
		public override string ToString()
		{
			return $"[{(this.IsDone ? "x" : " ")}] {this.Title}";
		}
	}
}