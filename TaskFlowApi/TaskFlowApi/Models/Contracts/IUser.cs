using System;
namespace TaskFlowApi.Models.Contracts
{
	public interface IUser
	{
		public string Username { get; }
		public string Role { get; }

		public bool CanCreateTask();
		public bool CanAssignTask();
	}
}

