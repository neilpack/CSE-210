using System;

class Program
{
    static void Main() {
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Breathing breathing = new Breathing();

        Console.WriteLine("Welcome to Neil's Mindfulness Program!");
        Console.Write(Environment.NewLine);

        bool done = false;
        while (!done) {
            Console.WriteLine("\rMenu Options: ");
            Console.WriteLine("\r   1. Start Breathing Activity");
            Console.WriteLine("\r   2. Start Reflecting Activity");
            Console.WriteLine("\r   3. Start Listing Activity");
            Console.WriteLine("\r   4. Quit");
            Console.WriteLine("\rSelect a choice from the menu: ");
            
            string UserChoice = Console.ReadLine();

            if (UserChoice == "1") {
                breathing.RunActivity();
            } else if (UserChoice == "2") {
                reflection.RunActivity();
            } else if (UserChoice == "3") {
                listing.RunActivity();
            } else if (UserChoice == "4") {
                done = true;
                Console.WriteLine("\rQuitting...");
                Environment.Exit(0);
            } else {
                Console.WriteLine("\rPlease input a number from the menu!");
            }
        }
    }
}


// program
// activity - contains the timer and animation
//breathing, reflection, and list - has the methods and attributes of each game

// this class will just run the entire program until it quits

//NOTES FOR INHERITANCE
//The parents know nothing about the kids, the way you have been thinking of it has been backwards
//essentially things you don't want to duplicate goes in activity and the program just calls on the three seperate activities,
//a timer and animation to duplicate it in each activity would be annoying so you put those in the activity.cs