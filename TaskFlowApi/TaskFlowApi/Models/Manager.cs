using System;
namespace TaskFlowApi.Models
{
	public class Manager : User
	{
        private const string role = "Manager";

        public Manager(string userName)
            :base(userName,role)
		{
		}

        public override bool CanAssignTask() => true;

        public override bool CanCreateTask() => true;
    }
}

