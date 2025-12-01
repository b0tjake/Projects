
using System;

class Transactions
{
    public int id;
    public string title;
    public decimal price;
    public string category;
    public DateTime Date;
public Transactions(int id, string title, decimal price, string category, DateTime date)
{
    this.id = id;
    this.title = title;
    this.price = price;
    this.category = category;
    this.Date = date;
}
}