using System;
using System.Collections.Generic;

class Atm
{
    private List<Account> accounts;
    public Atm(List<Account> accounts)
    {
        this.accounts = accounts;
    }
public Account Authentification()
{
    while (true)
    {
        Console.Write("Enter your account number: ");
        string accNumber = Console.ReadLine();

        Console.Write("Enter your PIN: ");
        int pin = Convert.ToInt32(Console.ReadLine());

        // search for account
        foreach (var acc in accounts)
        {
            if (accNumber == acc.AccountNumber && pin == acc.Pin)
            {
                Console.WriteLine("Login successful!");
                return acc;
            }
        }

        Console.WriteLine("Incorrect account number or PIN. Please try again.\n");
    }
}

    public int ShowMenu()
    {
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Show Transactions");
        Console.WriteLine("5. Exit");
        var choice = Console.ReadLine();
        return Convert.ToInt32(choice);
    }
    public void PerformAction(Account account, int choice)
    {
        switch(choice)
        {
            case 1:
                account.checkBalance();
                break;
            case 2:
                Console.WriteLine("Enter amount to deposit:");
                double depAmount = Convert.ToDouble(Console.ReadLine());
                account.deposit(depAmount);
                break;
            case 3:
                Console.WriteLine("Enter amount to withdraw:");
                double withAmount = Convert.ToDouble(Console.ReadLine());
                account.withdraw(withAmount);
                break;
            case 4:
                account.showTransactions();
                break;
            case 5:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}