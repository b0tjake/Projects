using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;



class Program
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
        transactions.Add(new Transactions(id,title,amount,category,date));
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
    static void summary()
{
    decimal totalIncome = 0;
    decimal totalExpense = 0;
    decimal balance = 0;

    Dictionary<string, decimal> expenseByCategory = new Dictionary<string, decimal>();

    foreach (var tr in transactions)
    {
        if (tr.price > 0)
        {
            totalIncome += tr.price;
        }
        else
        {
            totalExpense += tr.price;

            if (!expenseByCategory.ContainsKey(tr.category))
            {
                expenseByCategory[tr.category] = 0;
            }

            expenseByCategory[tr.category] += tr.price;
        }
    }

    balance = totalIncome + totalExpense;

    Console.WriteLine($"Total Income: {totalIncome}");
    Console.WriteLine($"Total Expense: {totalExpense}");
    Console.WriteLine($"Balance: {balance}");

    Console.WriteLine("\nExpenses by Category:");
    foreach (var item in expenseByCategory)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
static void saveAsJson()
    {
        string json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText("transactions.json", json);
    }
    public static List<Transactions> loadTransaction()
    {
        if (!File.Exists("transactions.json"))
        {
            return new List<Transactions>();

        }
            string json = File.ReadAllText("transactions.json");
                return JsonSerializer.Deserialize<List<Transactions>>(json);
        }

        static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. Show Transactions");
            Console.WriteLine("3. Update Transaction");
            Console.WriteLine("4. Delete Transaction");
            Console.WriteLine("5. Summary");
            Console.WriteLine("6. Save Transactions");
            Console.WriteLine("7. Load Transactions");
            Console.WriteLine("8. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addTransaction();
                    break;
                case "2":
                    showTransactions();
                    break;
                case "3":
                    updateTransaction();
                    break;
                case "4":
                    deleteTransaction();
                    break;
                case "5":
                    summary();
                    break;
                case "6":
                    saveAsJson();
                    break;
                case "7":
                    transactions = loadTransaction();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }


}


