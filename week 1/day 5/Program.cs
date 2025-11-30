using System;

class Task
{
    public string Title;
    public string Description;
    public string Status;
    public DateTime DueDate;

    public Task(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        Status = "Pending";
        DueDate = dueDate;
    }
}
