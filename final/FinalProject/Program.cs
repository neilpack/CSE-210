using System;
using System.Data;

class Program : Util
{
    static void Main(string[] args)
    {
        //Load Objects
        Game game = new Game();
        Tutorial tutorial = new Tutorial();
        Statistic stat = new Statistic();

        //statistic load
        stat.CreateFile();
        stat.Load();

        //Welcome Message
        Line();
        Console.WriteLine("\r---=========---");
        Console.WriteLine("\rWelcome to TENZI!");
        Console.WriteLine("\rCreated by Neil Pack");
        Console.WriteLine("\r---=========---");
        Line();
        Thread.Sleep(5000);
        Console.Clear();

        //Display Menu
        bool done = false;
        while (!done) {
            Console.WriteLine("\r-=== Menu ===-");
            Console.WriteLine("\r   1. Start New Game");
            Console.WriteLine("\r   2. Tutorial");
            Console.WriteLine("\r   3. Check Statistics");
            Console.WriteLine("\r   4. Quit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    game.Start();
                    if (game.CheckWin()) {
                        stat.GetWinPoint();
                    } else {
                        stat.GetLossPoint();
                    }
                    break;
                case "2":
                    Console.Clear();
                    tutorial.Run();
                    break;
                case "3":
                    Console.Clear();
                    stat.DisplayStatistics();
                    break;
                case "4":
                    Console.Clear();
                    stat.Save();
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Invalid option");
                    Console.WriteLine(Environment.NewLine);
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
    }
}

// Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.

//Final Project Plan
// Program.cs : Util
// │── Game : Util
// |  |-BotPlayer (Polymorphism with EasyBot, MediumBot, HardBot)
// |  |
// │  |-Table : Util
// |    |-Dice
// │
// │── Statistic : Util (Scoreboard)
// │
// │── Tutorial : Util
// |  |-Table : Util
// │

// Game (Manages overall game flow)
// Controls the game loop
// Starts the game
// Manages players and bots

// Table (Tracks dice and actions)
// Holds a set of Dice
// Rolls dice manually
// Checks if all dice match (win condition)

// Dice
// Handles rolling mechanics
// Stores its own value
// Rolls a random number between 1-6

// Statistic (Tracks scores)
// Keeps track of wins/losses

// Tutorial
// Runs tutorial script
// runs another table to show gameplay

// Util
// Helper methods
// Takes player input

// BotPlayer
// Automates dice rolling using timers
// Different difficulty levels affect rolling speed
// Uses polymorphism to override rolling behavior