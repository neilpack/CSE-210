using System;
using System.Xml.Linq;

class Program {
  static void Main() {
    // MY OBJECTS
    Checklist checklist = new Checklist();
    Simple simple = new Simple();
    Eternal eternal = new Eternal();

    // WELCOME MESSAGE
    if (!File.Exists("goals.txt")) File.Create("goals.txt").Close(); //if goals.txt doesn't exist, then create it
    Console.WriteLine("Welcome to Neil's Goal Tracker Program!");
    Console.Write(Environment.NewLine);

    //PRELOAD GOALS
    simple.Load();

    // RUN GOAL TRACKER GAME LOOP
    bool done = false;
    while (!done) {

        // DISPLAY POINTS
        checklist.displayPoints();
        Console.Write(Environment.NewLine);

        // MENU
        Console.WriteLine("\rMenu Options: ");
        Console.WriteLine("\r   1. Create New Goal");
        Console.WriteLine("\r   2. List Goals");
        Console.WriteLine("\r   3. Save Goals");
        Console.WriteLine("\r   4. Load Goals");
        Console.WriteLine("\r   5. Record Event");
        Console.WriteLine("\r   6. Win Game (1000 Points)");
        Console.WriteLine("\r   7. Quit");
        Console.WriteLine("\r   8. Hard Reset");
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
            Console.WriteLine("Goals Loaded Successfully.");
            Console.WriteLine(Environment.NewLine);
            Thread.Sleep(3000);
        // Record Event
        } else if (UserChoice == "5") {
            eternal.recordEvent();
        } else if (UserChoice == "6") {
            if (checklist.returnPoints() >= 1000) {
                Console.Clear();
                Console.WriteLine("----- YOU WIN! -----");
                Thread.Sleep(5000);
            } else {
                Console.WriteLine("You do not have enough points!");
                Console.WriteLine("Try again later...");
            }
        // Quit
        } else if (UserChoice == "7") {
            done = true;
            Console.Clear();
            Console.WriteLine("\rQuitting...");
            Environment.Exit(0);
        // Hard Reset
        } else if (UserChoice == "8") {
            Console.WriteLine("Are you sure you want to hard reset?");
            Console.WriteLine("This will erase all your goals and progress!");
            UserChoice = "0";
            bool goaldone = false;
            while (!goaldone) {
                Console.WriteLine("\rPress Y or N");

                UserChoice = Console.ReadLine();

                if (UserChoice == "y") {
                    Console.WriteLine("RESETTING ALL PROGRESS");
                    goaldone = true;
                    File.WriteAllText("goals.txt", "");
                    simple.clearLists();
                } else if (UserChoice == "n") {
                    Console.WriteLine("Hard Reset Cancelled");
                    goaldone = true;
                } else {
                    Console.WriteLine("\rPlease input Y or N, then press enter!");
                }
            }
        // Input Correct Number and Try Again
        } else {
            Console.WriteLine("\rPlease input a number from the menu!");
        }
    }
  }
}