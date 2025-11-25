
// fizzbuzz challenge 1

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number between 1 and 100");
        int number = Convert.ToInt32(Console.ReadLine());
        while (number<=0 || number >100){
            Console.WriteLine("enter a number between 1 and 100");
         number = Convert.ToInt32(Console.ReadLine());
        }
        
            if(number %3 == 0 && number %5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            else if(number %3 == 0 && number%5 != 0){
                Console.WriteLine("Fizz");
            }
            else if(number %3 != 0 && number%5 == 0){
                Console.WriteLine("Buzz");
            
        }
        }
    }

    // fizzbuzz challenge 2

//     using System.Collections.Generic;


// using System;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//             for (int i = 0 ; i<=5 ; i++){
//                 Console.WriteLine(new string('*',i));
//             }
//         }
//     }


// fizzbuzz challenge 3


// using System.Collections.Generic;


// using System;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//             string input = Console.ReadLine();
//             string reversed = "";
//             for(int i = input.Length-1 ; i>=0 ; i--){
//                 reversed+=input[i];
//             }
//             Console.WriteLine(reversed);
//         }
//     }
