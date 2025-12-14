using System;
namespace TaskFlowApi.Models
{
	public class Admin : User
	{
        private const string role = "Admin";

		public Admin(string userName)
            : base(userName, role)
		{
		}

        public override bool CanAssignTask() => true;

        public override bool CanCreateTask() => true;
    }
}

