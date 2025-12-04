// exercice 1 
public class HelloWorld
{
    public static void Main(string[] args)
    {

        Console.WriteLine ("hello world");
    }
}
//exercice 2 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name = "trafeh zouhair";
        int age = 21;
        Console.WriteLine("hello my name is "+ name +" and my age is " + age );
    }
}
// exercice 3
public class HelloWorld
{
    public static void Main(string[] args)
    {
 int var1 = 29;
 int var2 = 1;
 int sum = var1 + var2;
 Console.WriteLine(sum);
    }
}

// exercice 4
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int userAge = 17;
        if(userAge>=18){
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }
        
    }
}
//exercice 5
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i=10;
        while (i>0){
            Console.WriteLine(i);
            i--;
        }
        Console.WriteLine("Liftoff");
        
    }
}
//exercice 6

using System;
public class HelloWorld
{
        public static void SayHello(string name){
            Console.WriteLine("hello "+ name);
        }
   public static void Main(string[] args)
    {
        SayHello("charaf");
        SayHello("asaad");
        SayHello("karim");
    }
}

//exercice 7

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for( int i =0 ; i<=10 ; i++){
            if(i%2 == 0){
                Console.WriteLine("number " + i + " is even");
            }
            else {
                Console.WriteLine("number " + i + " is odd");
            }
        }
}
}

// exercice 8

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int C = Convert.ToInt32(Console.ReadLine());
        float F = C * (9/5) + 32;

        Console.WriteLine(F);
    }
}

// exercice 9
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c;
        c = a;
        a=b;
        b=c;
        
        Console.WriteLine("a = "+  a +" b = " +b);
    }
}
//exercice 10

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i = 1 ;  i <= 10 ; i++){
        Console.WriteLine(number * i);
        }
    }
}
