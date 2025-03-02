using System;
using System.Runtime.Versioning;

class Reflection : Activity
{

    private string[] firstPrompts = {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private string[] secondPrompts = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    public void RunActivity() {
        sessionComplete = false;
        activityName = "Reflection";
        Console.Clear();
        Console.WriteLine("\rNow running Reflection Activity!");
        Console.Write(Environment.NewLine);
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.Write(Environment.NewLine);
        Timer = getUserInput();
        Console.Clear();
        
        // loading animation
        displayLoadingAnimation();
        Console.Clear();

        // provide first prompt
        provideFirstPrompt();

        // press enter
        Console.WriteLine("Press Any Key When you are Ready: ");
        Console.ReadKey();

        // Run the countdown timer in a separate thread
        Task timerTask = Task.Run(() => StartCountdown(Timer));

        //press second prompts until timer ends
        while (!sessionComplete) {
            if (!sessionComplete) {
                provideSecondPrompt();
            }
            displayThinkingAnimation();
        }
        Console.Write(Environment.NewLine);

        //wait for the timer to end to
        timerTask.Wait();
    }
    void provideFirstPrompt() {
        Random rnd = new Random();
        int index = rnd.Next(firstPrompts.Length); // Get a random index
        string randomChoice = firstPrompts[index]; // Select the random item
        Console.Write(Environment.NewLine);
        Console.WriteLine(randomChoice);
        Console.Write(Environment.NewLine);
    }
    void provideSecondPrompt() {
        Random rnd = new Random();
        int index = rnd.Next(secondPrompts.Length); // Get a random index
        string randomChoice = secondPrompts[index]; // Select the random item
        Console.Write(Environment.NewLine);
        Console.WriteLine(randomChoice);
    }
}