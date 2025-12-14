using System;
using TaskFlowApi.Models.Contracts;

namespace TaskFlowApi.Models
{
	public class TaskItem : ITask
	{
		public TaskItem(string title, string description)
		{
            this.Title = title;
            this.Description = description;
		}

        public int Id { get; set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public string Status { get;  set; } = "Pending";

        public string? AssignedTo { get;  set; }
    }
}

