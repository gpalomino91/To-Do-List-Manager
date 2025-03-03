using System;
using ToDoListManager;
using ToDoListManager.Models;

namespace ToDoListManager
{

    class Program
    {
        public static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            int option = 0;

            do
            {
                Console.WriteLine("\n===== Task Manager =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch(option)
                {
                    case 1:
                        ToDoListManager.Models.Task newTask = taskManager.CreateTask();
                        taskManager.AddTask(newTask);  
                        break;
                    case 2:
                        Console.WriteLine("Tasks:");
                        if (taskManager.GetTasks().Count == 0)
                        {
                            Console.WriteLine("No tasks available to view.");
                            break;
                        }
                        taskManager.ViewTasks();
                        break;
                    case 3:
                        Console.WriteLine("Complete Task");
                        if (taskManager.GetTasks().Count == 0)
                        {
                            Console.WriteLine("No tasks available to complete.");
                            break;
                        }

                        taskManager.ViewTasks();

                        Console.WriteLine("Insert task ID");
                        int taskid;
                        if (!int.TryParse(Console.ReadLine(), out taskid))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        taskManager.CompleteTask(taskid);
                        break;
                    case 4:
                        Console.WriteLine("Delete Task");
                        if (taskManager.GetTasks().Count == 0)
                        {
                            Console.WriteLine("No tasks available to delete.");
                            break;
                        }

                        taskManager.ViewTasks();

                        Console.WriteLine("Introduce task ID to delete:"); 
                        int taskdelete;
                        if (!int.TryParse(Console.ReadLine(), out taskdelete))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }
                        taskManager.DeleteTask(taskdelete);
                        break;
                    case 5:
                        Console.WriteLine("Exiting Task Manager...");
                        break;   
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            while(option != 5);
        }
    }
}
