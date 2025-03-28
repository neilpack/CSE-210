using System;
using System.Runtime.InteropServices;

public class Game : Util {

    //Load Objects
    Table table = new Table();

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

        //Choose Gamemode


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
        Console.WriteLine("Press Enter or a number (0-9): ");

        //keep taking inputs from user if game isn't complete
        while (!gameComplete) {
            string input = DetectButton();
            if (!string.IsNullOrEmpty(input)) {
                ExecuteInput(input);
            }
        }

        //game finished (display final board)

        //Display After Game Scores (Did user win or lose?)

    }

    private void ExecuteInput(string input) {
        switch (input)
        {
            case "Enter":
                Console.WriteLine("You pressed Enter");
                //roll dice that aren't in kept list
                table.TakeTurn();
                break;
            case "1":
                Console.WriteLine("You pressed 1");
                table.KeepNumOne();
                break;
            case "2":
                Console.WriteLine("You pressed 2");
                table.KeepNumTwo();
                break;
            case "3":
                Console.WriteLine("You pressed 3");
                table.KeepNumThree();
                break;
            case "4":
                Console.WriteLine("You pressed 4");
                table.KeepNumFour();
                break;
            case "5":
                Console.WriteLine("You pressed 5");
                table.KeepNumFive();
                break;
            case "6":
                Console.WriteLine("You pressed 6");
                table.KeepNumSix();
                break;
            case "0":
                table.Debug();
                break;
            default:
                break;
        }
    }
    public void Debug() { //Only so I don't have to see cutscenes and can start instantly
        Console.WriteLine("Running Debugger");
    }




}