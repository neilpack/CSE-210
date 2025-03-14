using System;
using System.Xml.Linq;

class Program {
  static void Main() {
    // MY OBJECTS
    Checklist checklist = new Checklist();
    Simple simple = new Simple();
    Eternal eternal = new Eternal();

    // WELCOME MESSAGE
    if (!File.Exists("goal.txt")) File.Create("goals.txt").Close(); //if goals.txt doesn't exist, then create it
    Console.WriteLine("Welcome to Neil's Goal Tracker Program!");
    Console.Write(Environment.NewLine);

    // DISPLAY POINTS
    Console.WriteLine("You have 0 Points");
    Console.Write(Environment.NewLine);

    // RUN GOAL TRACKER GAME LOOP
    bool done = false;
    while (!done) {
        Console.WriteLine("\rMenu Options: ");
        Console.WriteLine("\r   1. Create New Goal");
        Console.WriteLine("\r   2. List Goals");
        Console.WriteLine("\r   3. Save Goals");
        Console.WriteLine("\r   4. Load Goals");
        Console.WriteLine("\r   5. Record Event");
        Console.WriteLine("\r   6. Quit");
        Console.WriteLine("\rSelect a choice from the menu: ");
        
        string UserChoice = Console.ReadLine();

        // Create Goal
        if (UserChoice == "1") {
            UserChoice = "0";
            bool goaldone = false;
            while (!goaldone) {
                Console.WriteLine("\rThe types of goals are: ");
                Console.WriteLine("\r   1. Simple");
                Console.WriteLine("\r   2. Eternal");
                Console.WriteLine("\r   3. Checklist");
                Console.WriteLine("\rWhich type of goal Would you like to create? ");

                UserChoice = Console.ReadLine();

                if (UserChoice == "1") {
                    simple.Create();
                    goaldone = true;
                } else if (UserChoice == "2") {
                    eternal.Create();
                    goaldone = true;
                } else if (UserChoice == "3") {
                    checklist.Create();
                    goaldone = true;
                } else {
                    Console.WriteLine("\rPlease input a number associated with the goal!");
                }
            }
        // List Goals
        } else if (UserChoice == "2") {
            simple.displayList();
        // Save Goals
        } else if (UserChoice == "3") {
            simple.Save();
        // Load Goals
        } else if (UserChoice == "4") {
            simple.Load();
        // Record Event
        } else if (UserChoice == "5") {
            Console.WriteLine("placeholder");
        // Quit
        } else if (UserChoice == "6") {
            done = true;
            Console.Clear();
            Console.WriteLine("\rQuitting...");
            Environment.Exit(0);
        // Input Correct Number and Try Again
        } else {
            Console.WriteLine("\rPlease input a number from the menu!");
        }
    }
  }








}