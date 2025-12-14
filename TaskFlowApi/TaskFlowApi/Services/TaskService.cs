using System;
using TaskFlowApi.Models;
using TaskFlowApi.Repositories;
using TaskFlowApi.Services.Contracts;

namespace TaskFlowApi.Services
{
	public class TaskService : IService
	{
        private readonly TaskRepository repo;

        public TaskService(TaskRepository repo)
		{
            this.repo = repo;
		}

        private User CreateUser(string username)
        {
            return username switch
            {
                "admin" => new Admin(username),
                "manager" => new Manager(username),
                _ => new RegularUser(username)
            };
        }

        public string AssignTask(string username, int taskId, string assignTo)
        {
            var user = CreateUser(username);

            if (!user.CanAssignTask())
                return $"{user.Username} cannot assign tasks.";

            var task = repo.GetById(taskId);

            if (task == null)
                return "There is no such task.";

            task.AssignedTo = assignTo;
            task.Status = "InProgress";

            return $"Task {task.Id} is given to {assignTo}.";
        }

        public string CreeateTask(string username, string title, string description)
        {
            var user = CreateUser(username);

            if (!user.CanCreateTask())
                return $"{user.Username} cannot create a task!";

            var task = new TaskItem(title, description);
            repo.Add(task);

            return $"Making '{title}' from {user.Username}.";
        }

        public void DeleteTask(int id)
        {
            var task = repo.GetById(id);
            if (task != null)
                repo.Remove(task);
        }

        public IEnumerable<TaskItem> GetAllTasks() => repo.GetAll();
    }
}

