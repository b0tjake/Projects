// exercice 1

using System.Collections.Generic;
using System;

class Helloworld{
     static void Main(){
List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
List<int> values = new List<int> { 10, 20, 30 };

Dictionary<string , int> dict = new Dictionary<string,int>();
for(int i = 0; i < keys.Count ; i++){
    dict[keys[i]] = values[i];
}
foreach(var item in dict){
    Console.WriteLine($"{item.Key} : {item.Value}");

}
}
    
}
// exercice 2
// using System;
// using System.Collections.Generic;

// class HelloWorld {
//     static void Main() {
//         Dictionary<string, int> family = new Dictionary<string, int>
//         {
//             {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
//         };

//         int total = 0;

//         foreach(var f in family)
//         {
//             int cost = 0;
//             if(f.Value < 3) cost = 0;
//             else if(f.Value <= 12) cost = 10;
//             else cost = 15;

//             Console.WriteLine($"{f.Key} : ${cost}");
//             total += cost;
//         }

//         Console.WriteLine($"Total cost: ${total}");
//     }
// }

//exercice 3
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var brand = new Dictionary<string, object>
//         {
//             {"name", "Zara"},
//             {"creation_date", 1975},
//             {"creator_name", "Amancio Ortega Gaona"},
//             {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
//             {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
//             {"number_stores", 7000},
//             {"major_color", new Dictionary<string, List<string>>
//                 {
//                     {"France", new List<string>{"blue"}},
//                     {"Spain", new List<string>{"red"}},
//                     {"US", new List<string>{"pink", "green"}}
//                 }
//             }
//         };

        // 1. 
//         brand["number_stores"] = 2;

         // 2. 
//         var types = brand["type_of_clothes"] as List<string>;
//         Console.WriteLine($"Zara sells clothes for: {string.Join(", ", types)}");

         // 3.
//         brand["country_creation"] = "Spain";
         // 4.
//         if (brand.ContainsKey("international_competitors"))
//         {
//             var competitors = brand["international_competitors"] as List<string>;
//             competitors.Add("Desigual");
//         }

         // 5.
//         brand.Remove("creation_date");

         // 6.
//         var lastCompetitor = (brand["international_competitors"] as List<string>)[1];
//         Console.WriteLine($"Last international competitor: {lastCompetitor}");

         // 7.
//         var colors = (brand["major_color"] as Dictionary<string, List<string>>)["US"];
//         Console.WriteLine("Major colors in US: " + string.Join(", ", colors));

         // 8.
//         Console.WriteLine("Number of key-value pairs: " + brand.Count);

         // 9.
//         Console.WriteLine("Keys:");
//         foreach (var key in brand.Keys)
//             Console.WriteLine(key);

         // 10.
//         var extraInfo = new Dictionary<string, object>
//         {
//             {"owner", "Inditex"},
//             {"HQ", "Arteixo"}
//         };
//         foreach (var item in extraInfo)
//             brand[item.Key] = item.Value;
//     }
// }




//exercise 4


// void DescribeCity(string city, string country = "Iceland")
// {
//     Console.WriteLine($"{city} is in {country}.");
// }

// DescribeCity("casablanca","denmark");

//exercise 5


// static void genNumber(int num)
// {
//     Random random = new Random();
//     int generatedNum = random.Next(0,100);
//     if(num == generatedNum)
//     {
//         Console.WriteLine("successfulu");
//     }
//     else
//     {
//         Console.WriteLine("no sorry");
//         Console.WriteLine($"the generated num was {generatedNum}");
//     }
// }  

// exercise 6

// void MakeShirt(string size = "Large", string text = "I love C#")
// {
//     Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
// }

// MakeShirt();
// MakeShirt("medium");
// MakeShirt("xxl" , "arthur morgan was here");

//exercise 7

// static int GetRandomTemp(string season)
// {
//     Random rnd = new Random();
//     int min = -10, max = 40;

//     if (season == "winter") { min = -10; max = 16; }
//     if (season == "spring") { min = 0; max = 23; }
//     if (season == "summer") { min = 16; max = 40; }
//     if (season == "autumn") { min = 0; max = 23; }

//     return rnd.Next(min, max + 1);
// }
// static void Main(){
    
//     string inputedSeason = Console.ReadLine();
//     int tmp = GetRandomTemp(inputedSeason);
// if (tmp < 0)
// {
//     Console.WriteLine("its freezy");
// }
// else if (tmp <= 16)
// {
//     Console.WriteLine("its kind of cold be careful");
// }
// else if (tmp > 16)
// {
//     Console.WriteLine("its warm");
// }
//     }


//exercise 8


// using System;
// using System.Collections.Generic;
// class HelloWorld {
//     static void Ask(List<Dictionary<string,string>>data){
//         List<string> wrongAnswers = new List<string>();
//     foreach(var d in data) {
//             Console.WriteLine("Q: " + d["question"]);
//          var yourAnswer = Console.ReadLine();
//          if(yourAnswer == d["answer"]){
//              Console.WriteLine("correct");
//          }
//          else{
//             Console.WriteLine("wrong the answer is: " + d["answer"]);
//             wrongAnswers.Add(yourAnswer);
//          }
        
//     }
//     var a = wrongAnswers as List<string>;
    
//     Console.WriteLine(string.Join(", ", a));
//     Console.WriteLine($"correct : {data.Count - a.Count} \n incorrect : {a.Count}");
//     if(a.Count>=3){
//         Console.WriteLine("try again");
//     }
// }
//   static void Main() {
// var data = new List<Dictionary<string, string>>
// {
//     new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
//     new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
//     new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
//     new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
//     new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
//     new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
// };
// Ask(data);
//   }
// }

//exercise 9


// using System;
//     public class Cat{
//       public  string catName;
//       public int catAge;
// class HelloWorld {
//   static void Main() {
//       Cat myCat1 = new Cat();
//       Cat myCat2 = new Cat();
//       Cat myCat3 = new Cat();
//         myCat1.catAge = 22; myCat1.catName = "dark";
//         myCat2.catAge = 12; myCat2.catName = "snow";
//         myCat3.catAge = 32; myCat3.catName = "bianca";
//       Console.WriteLine(myCat1.catAge + " " + myCat1.catName);
//       Console.WriteLine(myCat2.catAge + " "  + myCat2.catName);
//       Console.WriteLine(myCat3.catAge + " "  + myCat3.catName);
//              Cat oldest = FindOldestCat(new Cat[] { myCat1, myCat2, myCat3 });
//         Console.WriteLine($"The oldest cat is {oldest.catName} and is {oldest.catAge}");
//     }
//   }
//    static Cat FindOldestCat(Cat[] cats)
//     {
//         Cat oldest = cats[0];
//         foreach (var cat in cats)
//         {
//             if (cat.catAge > oldest.catAge)
//             {
//                 oldest = cat;
//             }
//         }
//         return oldest;
//     }
// }


//exercise 10

// using System;

// class Dog{
//     public string dogName ;
//     public float dogHeight;
    
//     public Dog(string name , float height){
//         dogName = name;
//         dogHeight = height;
//     }
    
//     public void Bark(){
//     Console.WriteLine($"{dogName} goes woof");
//     }
//     public void Jump(){
//         Console.WriteLine($"{dogName} jumps {dogHeight*2} cm");
//     }
// }

// class HelloWorld {
//   static void Main() {
//       Dog davidsDog  = new Dog("rex" , 50);
//       Dog sarahsDog  = new Dog("teacup" , 20);
//       davidsDog.Bark();
//       davidsDog.Jump();
//       sarahsDog.Jump();
//       sarahsDog.Bark();
//       if(davidsDog.dogHeight > sarahsDog.dogHeight){
//           Console.WriteLine("david's one is taller");
//       }
//       else{
//           Console.WriteLine("sarah's one is taller");
//       }
//   }
// }

//exercise 11

/*
using System;
using System.Collections.Generic;


public class Song{
    List<string> lyrics;
    public Song( List<string> lyr){
        lyrics = lyr;
    }
    public void singMeaSong(){
    Console.WriteLine(string.Join(", ", lyrics));
    }

}
class HelloWorld {
  static void Main() {
    Song emptiness_machine = new Song(new List<string>{"There’s a lady who's sure" , "all that glitters is gold" , "and she’s buying a stairway to heaven"});
emptiness_machine.singMeaSong();
}
}
*/

// exercise 12


// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Zoo
// {
//     public string Name;
//     private List<string> animals = new List<string>();

//     public Zoo(string zooName) => Name = zooName;

//     public void AddAnimal(string newAnimal)
//     {
//         if (!animals.Contains(newAnimal)) animals.Add(newAnimal);
//     }

//     public void GetAnimals() => Console.WriteLine(string.Join(", ", animals));

//     public void SellAnimal(string animalSold) => animals.Remove(animalSold);

//     public Dictionary<char, List<string>> SortAnimals()
//     {
//         return animals
//             .OrderBy(a => a)
//             .GroupBy(a => char.ToUpper(a[0]))
//             .ToDictionary(g => g.Key, g => g.ToList());
//     }

//     public void GetGroups()
//     {
//         foreach (var kvp in SortAnimals())
//             Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Zoo newYorkZoo = new Zoo("New York Zoo");

//         newYorkZoo.AddAnimal("Lion");
//         newYorkZoo.AddAnimal("Ape");
//         newYorkZoo.AddAnimal("Bear");
//         newYorkZoo.AddAnimal("Cougar");
//         newYorkZoo.GetAnimals();        
//         newYorkZoo.SellAnimal("Bear");
//         newYorkZoo.GetAnimals();        
//         newYorkZoo.GetGroups();         
//     }
// }
