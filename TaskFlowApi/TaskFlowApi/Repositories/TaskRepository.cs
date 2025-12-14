using System;
using TaskFlowApi.Models;

namespace TaskFlowApi.Repositories
{
	public class TaskRepository
	{

        private readonly List<TaskItem> tasks = new();
        private int idCounter = 1;

        public IEnumerable<TaskItem> GetAll() => tasks;

        public TaskItem? GetById(int id) => tasks.FirstOrDefault(t => t.Id == id);

        public TaskItem Add(TaskItem task)
        {
            task.Id = idCounter++;
            tasks.Add(task);
            return task;
        }

        public void Remove(TaskItem task)
        {
            tasks.Remove(task);
        }

    }
}

