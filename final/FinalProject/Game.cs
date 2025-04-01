using System;
using System.Runtime.InteropServices;
using System.Threading;

public class Game : Util {

    //Load Objects
    Table table = new Table();

    //Variables
    private bool gameComplete = false;
    private string botLevel = "";

    // Methods
    public void Start() {
        //Warning Message
        Console.WriteLine("Ensure the VS Code Console is in fullscreen");
        Console.WriteLine("for optimal visual effect.");
        Line();
        Thread.Sleep(3000);
        Console.Clear();

        //Reset Game (if playing a second time)
        gameComplete = false;
        table.Clean();

        //Set Difficulty for bots
        bool done = false;
        while (!done) {
            Console.WriteLine("Choose Bot Level Difficulty: ");
            Console.WriteLine(" 1. Easy");
            Console.WriteLine(" 2. Medium");
            Console.WriteLine(" 3. Hard");

            Line();

            botLevel = "";
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You Chose Easy");
                    Thread.Sleep(2000);
                    Console.Clear();
                    botLevel = "Easy";
                    done = true;
                    break;
                case "2":
                    Console.WriteLine("You Chose Medium");
                    Thread.Sleep(2000);
                    Console.Clear();
                    botLevel = "Medium";
                    done = true;
                    break;
                case "3":
                    Console.WriteLine("You Chose Hard");
                    Thread.Sleep(2000);
                    Console.Clear();
                    botLevel = "Hard";
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }

        //Start Timer
        Console.WriteLine("Starting Game in: ");
        Console.Write("\r3");
        Thread.Sleep(1500);
        Console.Write("\r2");
        Thread.Sleep(1500);
        Console.Write("\r1");
        Thread.Sleep(1500);
        Console.Write("\r0");
        Thread.Sleep(1500);
        Console.Clear();

        // ----=== Launch Game ===----
        //Display Game Board (Table)
        table.DisplayBaseScreen();

        // Run Bot Threads until win scenario
        Thread[] botThreads = new Thread[3]; // Track the threads
        BotPlayer[] bots = new BotPlayer[3]; // Track the bot instances
        for (int i = 0; i < 3; i++) {
            if (botLevel == "Easy") { // Create bot with ID 1, 2, 3
                bots[i] = new EasyBot(i + 1);
            } else if (botLevel == "Medium") {
                bots[i] = new MediumBot(i + 1);
            } else if (botLevel == "Hard"){
                bots[i] = new HardBot(i + 1);
            }
            botThreads[i] = new Thread(bots[i].Start);
            botThreads[i].IsBackground = true; // Ensures threads close when main thread exits
            botThreads[i].Start();
        }

        //keep taking inputs from user if game isn't complete
        while (!gameComplete) {
            bool anyBotHasWon = false;
            for (int i = 0; i < 3; i++) {
                if (bots[i].botHasWon) {
                    anyBotHasWon = true;
                    break;
                }
            }

            if (anyBotHasWon) {
                gameComplete = true;
            } else {
                string input = DetectButton();
                if (!string.IsNullOrEmpty(input)) {
                    ExecuteInput(input);
                }
            }
        }

        //close all the bots
        foreach (var bot in bots) {
            bot.Stop();
        }
        foreach (Thread t in botThreads) {
            t.Join(); // Wait for each bot thread to finish
        }

        //game finished (display final board)
        Line();
        Console.WriteLine("---====---");
        Console.WriteLine("Game Completed");
        Console.WriteLine("---====---");
        Line();
        Thread.Sleep(4000);

        // Display After Game Scores (Did user win or lose?)
        bool anyBotHasWonFinal = false;
        for (int i = 0; i < 3; i++) {
            if (bots[i].botHasWon) {
                anyBotHasWonFinal = true;
                break;
            }
        }
        if (!anyBotHasWonFinal) {
            Console.WriteLine("You Won!");
            Console.WriteLine("Congratulations!");
        } else {
            Console.WriteLine("You Lost... :(");
            if (_botPoints1 == 10) {
                Console.WriteLine("Bot Player Number Two Won");
            } else if (_botPoints2 == 10) {
                Console.WriteLine("Bot Player Number Three Won");
            } else if (_botPoints3 == 10) {
                Console.WriteLine("Bot Player Number Four Won");
            }
        }
        Thread.Sleep(2000);

        Console.Clear();
    }

    private void ExecuteInput(string input) {
        switch (input)
        {
            case "Enter":
                bool detectWin = table.TakeTurn();
                //roll dice that aren't in kept list
                //the bool returns true if the turn came back
                //as a win
                if (detectWin) {
                    gameComplete = true;
                }
                break;
            case "1":
                table.KeepNumOne();
                break;
            case "2":
                table.KeepNumTwo();
                break;
            case "3":
                table.KeepNumThree();
                break;
            case "4":
                table.KeepNumFour();
                break;
            case "5":
                table.KeepNumFive();
                break;
            case "6":
                table.KeepNumSix();
                break;
            case "0":
                table.Debug();
                break;
            default:
                break;
        }
    }
}