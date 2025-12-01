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
    static void showTransactions()
    {
        foreach (var tr in transactions)
        {
            Console.WriteLine($"ID: {tr.id}, Title: {tr.title}, Amount: {tr.price}, Category: {tr.category}, Date: {tr.Date.ToShortDateString()}");
        }

    }
    static void updateTransaction()
    {
        Console.WriteLine("enter the id of the transaction to update");
        int id = int.Parse(Console.ReadLine());
        var tr = transactions.Find(t => t.id == id);
        if (tr != null)
        {
            Console.WriteLine("enter new title");
            tr.title = Console.ReadLine();
            Console.WriteLine("enter new amount");
            tr.price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter new category");
            tr.category = Console.ReadLine();
            Console.WriteLine("enter new date (yyyy-mm-dd)");
            tr.Date = DateTime.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("transaction not found");
        }
    }
    static void deleteTransaction()
    {
        Console.WriteLine("enter the id of the transaction u want to delete");
        var id = int.Parse(Console.ReadLine());
        var tr = transactions.Find(t => t.id == id);
        if(tr != null)
        {
            transactions.Remove(tr);
            Console.WriteLine("transaction deleted");
        }
        else
        {
            Console.WriteLine("transaction not found");
        }
    }

}