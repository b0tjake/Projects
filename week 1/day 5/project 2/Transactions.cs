using System;
using System.Collections.Generic;

public class Program
{
    static List<Transactions> transactions = new List<Transactions>();
    static void addTransaction()
    {
        Console.WriteLine("add a title");
        string title = Console.ReadLine();
        Console.WriteLine("enter the amount");
        decimal amount = decimal.Parse(Console.ReadLine());
        Console.WriteLine("enter the category");
        string category = Console.ReadLine();
        Console.WriteLine("enter the date (yyyy-mm-dd)");
        DateTime date = DateTime.Parse(Console.ReadLine());
        int id = transactions.Count + 1;
        transactions.Add(new Transactions(id,title,amount,categorycategory,date));
    }
    
}