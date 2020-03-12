using System.Collections.Generic;
using System.Linq;
using ToDoList.Models;
using ToDoList.Controllers;

namespace ToDoList.Service
{
    public class TaskService
    {
        private static List<Task> tasks =
       new List<Task>
       {
            new Task{
                Id = 1,
                Name = "By Milk",
                Done = false,
                Deleted = false
            },
        new Task{
                Id = 2,
                Name = "By Ferarri",
                Done = false,
                Deleted = false
            }
       };
        public Task Create(Task task)
        {
            tasks.Add(task);
            return task;
        }

        public List<Task> All()
        {
            return tasks.ToList();
        }

        public Task Apdate(int id, Task newTask)
        {
            foreach(var task in tasks)
            {
                if(task.Id == id)
                {
                    task.Name = newTask.Name;
                    task.Done = newTask.Done;
                    task.Deleted = newTask.Deleted;
                }
            }
            return newTask;
        }

        public List<Task> Remove(int id)
        {
            foreach(var task in tasks)
            {
                if(task.Id == id)
                {
                 tasks.Remove(task);
                }
            }
            return tasks;
        }
    }
}
