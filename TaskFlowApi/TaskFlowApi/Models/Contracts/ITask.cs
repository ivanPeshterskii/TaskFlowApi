using System;
namespace TaskFlowApi.Models.Contracts
{
	public interface ITask
	{
        public int Id { get; }

        public string Title { get; }

        public string Description { get; }

        public string Status { get; }

        public string? AssignedTo { get; }
    }
}

