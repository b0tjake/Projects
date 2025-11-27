using System;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (!charCount.ContainsKey(c))
            {
                charCount[c] = 1;
            }
            else
            {
                charCount[c]++;
            }

            // Console.WriteLine($"input: {input}");
            // Console.WriteLine($"output: {c} : {charCount[c]}");
        }
        
        foreach(var item in charCount){
            Console.WriteLine($"{item.Key} , {item.Value}");
        }
    }
}
