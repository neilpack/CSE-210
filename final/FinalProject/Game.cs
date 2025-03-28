using System;
using System.Runtime.InteropServices;

public class Game : Util {

    //Load Objects
    Table table = new Table();
    BotPlayer bot = new BotPlayer();

    //Variables
    private bool gameComplete = false;

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
        DisplayBaseScreen();

        //Run Bot Thread until win scenario

        //keep taking inputs from user if game isn't complete
        while (!gameComplete) {
            string input = DetectButton();
            if (!string.IsNullOrEmpty(input)) {
                ExecuteInput(input);
            }
        }

        //game finished (display final board)
        Line();
        Console.WriteLine("---====---");
        Console.WriteLine("Game Completed");
        Console.WriteLine("---====---");
        Line();
        Thread.Sleep(4000);

        //Display After Game Scores (Did user win or lose?)

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
    private void DisplayBaseScreen() {
        Console.WriteLine("\r=======================================================================================================================");
        Line();
        Console.WriteLine("\rPlayer 2: 0/10 ");
        Console.WriteLine("\rPlayer 3: 0/10 ");
        Console.WriteLine("\rPlayer 4: 0/10 ");
        Line();

        //this is where the dice would go
        Line();
        Console.WriteLine(Environment.NewLine);
        Line();

        Console.WriteLine("\r=======================================================================================================================");

    }
}