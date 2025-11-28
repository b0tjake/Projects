using System;
using System.Collections.Generic;


class Account
{
   public string AccountNumber;
    public int Pin;
    public double Balance;
    public List<string> Transactions;

    public Account(string AccountNumber, int Balance , int Pin)
    {
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
        this.Pin = Pin;
        Transactions = new List<string>();
    }
    public void checkBalance()
    {
        Console.WriteLine(Balance);
    }
    public void deposit(double amount)
    {
        Balance += amount;
        Transactions.Add($"deposited: {amount}");
    }
    public void withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            Balance -= amount;
            Transactions.Add($"withdrawn: {amount}");
        }
    }
    public void showTransactions()
    {
        foreach(var item in Transactions)
        {
            Console.WriteLine(item);
        }
    }

}