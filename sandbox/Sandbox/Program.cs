using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Neil's Shopping Cart");
        Console.WriteLine("");

        List<string> names = new List<string>();
        List<double> prices = new List<double>();
    
        bool done = false;
        while (!done)
        {
            DisplayMenu();
            string choice = GetChoice();
            if (choice == "1"){
                Add(names, prices);
            }
            else if (choice == "2"){
                Remove();
            }
            else if (choice == "3"){
                Display(List<string> names, List<double> prices);
                
            }
            else if (choice == "4"){

            }
            else (choice == "5"){

            }

        }

    }

    static void Add(List<string> names, List<double> prices){
    //prompts the user and then adds it the the list
    Console.Write("Enter Price of Item: ");
    string name = Console.ReadLine();
    double price = Convert.ToDouble(prices);

    names.Add(name);
    prices.Add(price);

    }
    static void DisplayMenu(){
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Remove");
        Console.WriteLine("3) Display");
        Console.WriteLine("4) Total");
        Console.WriteLine("5) Quit");

    }
    static string GetChoice(){
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();
        return choice;
    }
    static double CalcTotal(List<double> prices){
        // Calculates total
        double total = 0;
        foreach (var price:double in prices){
            total += prices;
        }
        return 0.0;
    }
    static void Remove(){

    }
    static void CheckItem(){

    }
    static void Display(List<string> names, List<double> prices){
        Console.WriteLine("Cart");
        Console.WriteLine("==================");


        for (int i = 0; i < names.Count; i++){
            Console.WriteLine($"{names[0],15}");
        }

        Console.WriteLine("==================");
    }






}