using System;

class Program : Util
{
    static void Main(string[] args)
    {
        //Load Game Object
        Game game = new Game();

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
            Console.WriteLine("\r   2. Check Statistics");
            Console.WriteLine("\r   3. Tutorial");
            Console.WriteLine("\r   4. Quit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    game.Start();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Scoreboard");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Tutorial");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);
                    break;
                case "debug":
                    game.Debug();
                    break;
                default:
                    Console.Clear();
                    Line();
                    Console.WriteLine("Invalid option");
                    Line();
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    }
}

//Final Project Plan
// Program.cs
// │── GameMode (Abstract)
// │   │── ClassicTenzi
// │   │── SpeedTenzi
// │
// │── Player
// │   │── BotPlayer (Overrides RollDice)
// │
// │── Scoreboard
// │── UserInterface
// │── Dice


// Class Plan and Hierarchy
// Base Classes

// Game (Manages overall game flow)
// Controls the game loop
// Starts and stops the game
// Manages players and bots

// Player (Tracks dice and actions)
// Holds a set of Dice
// Rolls dice manually
// Checks if all dice match (win condition)

// GameMode (Abstract Class) (Defines rules for different game types)
// Provides StartGame(), CheckWinCondition(), etc.
// Enforced polymorphism by requiring subclasses to implement their own rules

// Scoreboard (Tracks scores)
// Keeps track of wins/losses

// UserInterface (Handles input/output)
// Displays game info
// Takes player input

// Derived Classes (Inheritance and Polymorphism)
// BotPlayer (Inherits from Player)
// Automates dice rolling using timers
// Different difficulty levels affect rolling speed
// Uses polymorphism to override rolling behavior

// ClassicTenzi (Inherits from GameMode)
// Implements standard Tenzi rules

// SpeedTenzi (Inherits from GameMode)
// Overrides CheckWinCondition() to add time-based mechanics

// Independent Utility Class
// Dice (Handles rolling mechanics)
// Stores its own value
// Rolls a random number between 1-6




// Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.