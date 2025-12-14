using System;
namespace TaskFlowApi.DTOs
{
	public class AssignTaskDto
	{
        public string Username { get;  set; }

        public int TaskId { get;  set; }

        public string AssignTo { get;  set; }
    }
}

