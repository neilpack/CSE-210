using System;

class Listing : Activity
{
    string[] listingPrompts = {
        " --- Who are people that you appreciate? --- ", 
        " --- What are personal strengths of yours? --- ",
        " --- Who are people that you have helped this week? --- ",
        " --- When have you felt the Holy Ghost this month? --- ",
        " --- Who are some of your personal heroes? --- "
    };
    List<string> entries = new List<string> {};
    public void RunActivity() {
        sessionComplete = false;
        activityName = "Listing";
        entries.Clear(); //clears list so activity can be ran again
        Console.Clear();
        Console.WriteLine("Now running Listing Activity!");
        Console.Write(Environment.NewLine);
        Console.WriteLine("This activity will help you reflect on the good things in your life by");
        Console.WriteLine("having you list as many things as you can in a certain area.");
        Console.Write(Environment.NewLine);
        Timer = getUserInput();
        Console.Clear();

        // loading animation
        displayLoadingAnimation();
        Console.Clear();

        // give prompt
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Random rnd = new Random();
        int index = rnd.Next(listingPrompts.Length); // Get a random index
        string randomChoice = listingPrompts[index]; // Select the random item
        Console.WriteLine(randomChoice);
        Console.WriteLine("You may begin in: ");
        fiveSecondCountdown();
        Console.Clear();
        Console.WriteLine(randomChoice);
        Console.Write(Environment.NewLine);

        // Run the countdown timer in a separate thread
        Task timerTask = Task.Run(() => StartCountdown(Timer));

        // user starts listing
        while (!sessionComplete && !timerTask.IsCompleted) {
            if (!sessionComplete) {
                Console.Write("> ");
                string entryInput = Console.ReadLine();
                entries.Add(entryInput);
                Console.WriteLine("");
            }
        }
        if (sessionComplete) {
            int newEntryCount = entries.Count - 1;
            Console.WriteLine($"You listed {newEntryCount} items!");
            Console.WriteLine("Well Done!");
            Console.Write(Environment.NewLine);
        }
    }
    void fiveSecondCountdown() {
        Console.Write(" ");
        Console.Write($"\r5 "); 
        Thread.Sleep(1000);
        Console.Write($"\r4 "); 
        Thread.Sleep(1000);
        Console.Write($"\r3 "); 
        Thread.Sleep(1000);
        Console.Write($"\r2 "); 
        Thread.Sleep(1000);
        Console.Write($"\r1 "); 
        Thread.Sleep(1000);
        Console.Write($"\r ");
    }
}