using System;
using TaskFlowApi.Models;

namespace TaskFlowApi.Services.Contracts
{
	public interface IService
	{
		public string CreeateTask(string username, string title, string description);

		public string AssignTask(string username, int taskId, string assignTo);

		public IEnumerable<TaskItem> GetAllTasks();

    }
}

