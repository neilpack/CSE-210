using System;

class Program {
  static void Main() {
    // MY OBJECTS
    Checklist checklist = new Checklist();
    Simple simple = new Simple();
    Eternal eternal = new Eternal();

    // WELCOME MESSAGE
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

        if (UserChoice == "1") {
            Console.WriteLine("placeholder");
        } else if (UserChoice == "2") {
            Console.WriteLine("placeholder");
        } else if (UserChoice == "3") {
            Console.WriteLine("placeholder");
        } else if (UserChoice == "4") {
            Console.WriteLine("placeholder");
        } else if (UserChoice == "5") {
            Console.WriteLine("placeholder");
        } else if (UserChoice == "6") {
            done = true;
            Console.Clear();
            Console.WriteLine("\rQuitting...");
            Environment.Exit(0);
        } else {
            Console.WriteLine("\rPlease input a number from the menu!");
        }
    }
  }
}