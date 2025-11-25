// challenge 1
using System.Collections.Generic;


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int>Numbers = new List<int>();        
         int number = Convert.ToInt32(Console.ReadLine());
         int length = Convert.ToInt32(Console.ReadLine());
         
            for(int i = 1 ; i <= length ; i++){
                Numbers.Add(number*i);
            }
                Console.WriteLine(string.Join(",", Numbers));
        }
    }


// challenge 2

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler



// using System.Collections.Generic;


// using System;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         string enter = Console.ReadLine();
//         string newEnter ;
//         newEnter = enter[0].ToString();
//         for(int i=1 ; i < enter.Length ; i++){
//             if (enter[i] != enter[i-1]){
//                 newEnter += enter[i];
//             }
//         }
//         Console.WriteLine(newEnter);
//         }
//     }
