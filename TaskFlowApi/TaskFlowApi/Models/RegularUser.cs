using System;
namespace TaskFlowApi.Models
{
	public class RegularUser : User
	{
        private const string role = "User";

        public RegularUser(string userName)
            :base(userName, role)
		{
		}

        public override bool CanAssignTask() => false;

        public override bool CanCreateTask() => false;
    }
}

