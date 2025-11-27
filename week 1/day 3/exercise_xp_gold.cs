// exercise_xp_gold.cs 1 and 2
using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {

Dictionary<string, string> birthday = new Dictionary<string, string>();
birthday.Add("zouhair", "2004/09/23");
birthday.Add("salma", "2005/10/24");
birthday.Add("iman", "2006/11/25");
birthday.Add("ali", "2007/12/26");
birthday.Add("ghait", "2008/13/27");

foreach (var item in birthday)
{
    Console.WriteLine($"the person {item.Key} has birthday on {item.Value}");
}

Console.WriteLine("welcome user , you can look up the birthdays");
var input = Console.ReadLine();
if (birthday.ContainsKey(input))
{
    Console.WriteLine($"the person {input} has birthday on {birthday[input]}");
}
else
{
    Console.WriteLine($"Sorry, we don’t have the birthday information for {input}");
}



  }
}

// exercise_xp_gold.cs 3

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter an integer X: ");
//         int X = int.Parse(Console.ReadLine());

//         int result = SumSequence(X);
//         Console.WriteLine($"Result: {result}");
//     }

//     static int SumSequence(int X)
//     {
//         string sX = X.ToString();
//         int XX = int.Parse(sX + sX);
//         int XXX = int.Parse(sX + sX + sX);
//         int XXXX = int.Parse(sX + sX + sX + sX);

//         return X + XX + XXX + XXXX;
//     }
// }

// exercise_xp_gold.cs 4


/*
using System;
using System.Collections.Generic;
using System.Linq;

class DiceSimulation
{
    static void Main()
    {
        MainSimulation();
    }

    static int ThrowDice(Random rand)
    {
        return rand.Next(1, 7);
    }

    static int ThrowUntilDoubles(Random rand)
    {
        int count = 0;
        int die1, die2;

        do
        {
            die1 = ThrowDice(rand);
            die2 = ThrowDice(rand);
            count++;
        } while (die1 != die2);

        return count;
    }

    static void MainSimulation()
    {
        Random rand = new Random(); // single random instance
        List<int> results = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            results.Add(ThrowUntilDoubles(rand));
        }

        int totalThrows = results.Sum();
        double averageThrows = results.Average();

        Console.WriteLine($"Total number of throws: {totalThrows}");
        Console.WriteLine($"Average number of throws to reach doubles: {Math.Round(averageThrows, 2)}");
    }
}

*/