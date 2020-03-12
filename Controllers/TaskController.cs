using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Net;

using ToDoList.Models;
using ToDoList.Service;

namespace ToDoList.Controllers
{
    [Route("tasks")]
    [ApiController]


    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            this._taskService = taskService;

        }

        //GET api/tasks
        [HttpGet("")]
        public List<Task> GetTasks()
        {
            return _taskService.All();
        }

       // POST api/tasks
        [HttpPost("")]
        public Task PostTasks(Task task)
        {
            return _taskService.Create(task);
        }

       // PUT api/tasks/5
        [HttpPut("{id}")]
        public Task PutTask(int id, Task value)
        {
            return _taskService.Apdate(id, value);
        }

        // DELETE api/tasks/5
        [HttpDelete("{id}")]
        public List<Task> DeleteTaskById(int id)
        {
            return _taskService.Remove(id);

        }
    }
}