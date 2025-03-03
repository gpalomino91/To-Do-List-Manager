using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace ToDoListManager.Models
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private static int nextId = 1;
        public Task CreateTask()
        {
            Console.WriteLine("New task:");
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Task newTask = new Task()
            {
                ID = nextId++,
                Title = title,
                Description = description,
                IsCompleted = false
            };

        return newTask;
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        public void ViewTasks()
        {
            foreach (Task vtask in tasks)
            {
                Console.WriteLine($"ID: {vtask.ID}, Title: {vtask.Title}, Description: {vtask.Description}, Completed: {vtask.IsCompleted}");
            }
        }

        public bool CompleteTask(int id)
        {
            bool found = false;
            foreach (Task num in tasks)
            {
                if (num.ID == id)
                {
                    num.IsCompleted = true;
                    found = true;
                    Console.WriteLine("Task marked as completed.");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("ID not found.");
            }
            return found;
        }

        public void DeleteTask(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("Invalid ID. Please enter a positive number.");
                return;
            }
    
            Task taskToDelete = tasks.Find(t => t.ID == id);

            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine($"Task {id} deleted.");
            }
            else
            {
                Console.WriteLine("ID not found.");
            }
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}