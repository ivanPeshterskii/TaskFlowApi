using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskFlowApi.DTOs;
using TaskFlowApi.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskFlowApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class TasksController : ControllerBase
    {
        private readonly TaskService service;

        public TasksController(TaskService service)
        {
            this.service = service;
        }

        [HttpPost("create")]
        public IActionResult CreateTask(CreateTaskDto dto)
        {
            var result = service.CreeateTask(dto.Username, dto.Title, dto.Description);
            return Ok(new { message = result });
        }

        [HttpPost("assign")]
        public IActionResult AssignTask(AssignTaskDto dto)
        {
            var result = service.AssignTask(dto.Username, dto.TaskId, dto.AssignTo);
            return Ok(new { message = result });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = service.GetAllTasks().FirstOrDefault(t => t.Id == id);
            if (task == null)
                return NotFound(new { message = "Task not found." });

            service.DeleteTask(id);
            return Ok(new { message = $"Task {id} deleted." });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(service.GetAllTasks());
        }
    }
}

