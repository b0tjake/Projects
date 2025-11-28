using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Account cmpt = new Account("123456", 1000, 1234);
        Account cmpt1 = new Account("1234567", 0, 1234);
        Account cmpt2 = new Account("1234568", 1, 1234);

        Atm atm = new Atm(new List<Account> { cmpt, cmpt1, cmpt2 });

        Account currentAccount = atm.Authentification();

        if (currentAccount == null)
        {
            Console.WriteLine("Authentication failed. Exiting...");
            return;
        }

        int choice = 0;

        while (choice != 5)
        {
            choice = atm.ShowMenu();
            atm.PerformAction(currentAccount, choice);
        }

        Console.WriteLine("\nSummary of all operations:");
        currentAccount.showTransactions();
    }
}
