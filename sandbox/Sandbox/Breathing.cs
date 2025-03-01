using System;
using System.Threading;
using System.Threading.Tasks; // used to execute multiple things at the same time

class Breathing : Activity
{
    public void RunActivity() {
        sessionComplete = false;
        activityName = "Breathing";
        Console.Clear();
        Console.WriteLine("\rNow running Breathing Activity!");
        Timer = getUserInput();
        Console.Clear();

        //Run animation and give user some time before activity
        displayLoadingAnimation();
        Console.Clear();

        // Run the countdown timer in a separate thread
        Task timerTask = Task.Run(() => StartCountdown(Timer));

        while (!sessionComplete) {
            if (!sessionComplete) {
                breathIn();
            } if (!sessionComplete) {
                breathOut();
            }
            Console.Write(Environment.NewLine);
        }
        // Ensure the timer finishes before exiting
        timerTask.Wait();
    }

    void breathIn() {
        Console.WriteLine($"\rBreathe in... ");
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

    void breathOut() {
        Console.WriteLine($"\rBreathe out... ");
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