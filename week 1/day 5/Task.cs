using System;
using System.Collections.Generic;

class Program
{
    static List<Task> tasks = new List<Task>();

    static void AddTask()
    {
        Console.WriteLine("Enter Task Title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter Task Description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Due Date (yyyy-mm-dd) or leave blank:");
        string dueInput = Console.ReadLine();

        DateTime dueDate;
        if (!DateTime.TryParse(dueInput, out dueDate))
        {
            dueDate = DateTime.Now;
        }

        tasks.Add(new Task(title, description, dueDate));
        Console.WriteLine("Task Added Successfully!\n");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.\n");
            return;
        }

        Console.WriteLine("Tasks List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Task t = tasks[i];
            Console.WriteLine($"{i + 1}. {t.Title} - {t.Description} - {t.Status} - Due: {t.DueDate.ToShortDateString()}");
        }
        Console.WriteLine();
    }

    static void UpdateTaskStatus()
    {
        Console.WriteLine("Enter Task Number to Update Status:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Task t = tasks[index - 1];
            t.Status = t.Status == "Pending" ? "Completed" : "Pending";
            Console.WriteLine("Task Status Updated Successfully!\n");
        }
        else
        {
            Console.WriteLine("Invalid task number.\n");
        }
    }

    static void DeleteTask()
    {
        Console.WriteLine("Enter Task Number to Delete:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            Console.WriteLine("Are you sure you want to delete this task? (yes/no)");
            string confirm = Console.ReadLine().ToLower();
            if (confirm == "yes")
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task Deleted Successfully!\n");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid task number.\n");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Your Task Manager!");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task Status");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ViewTasks(); break;
                case "3": UpdateTaskStatus(); break;
                case "4": DeleteTask(); break;
                case "5": return;
                default: Console.WriteLine("Invalid choice.\n"); break;
            }
        }
    }
}
