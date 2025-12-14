using System;
using TaskFlowApi.Models.Contracts;

namespace TaskFlowApi.Models
{
    public abstract class User : IUser
    {
        public string Username { get; }

        public string Role { get; }

        protected User(string userName, string role)
        {
            this.Username = userName;
            this.Role = role;
        }

        public abstract bool CanAssignTask();

        public abstract bool CanCreateTask();
    }
}

