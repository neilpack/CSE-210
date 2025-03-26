using System;
using System.Runtime.InteropServices;

public class Game : Util {

    //Load Objects
    Table table = new Table();

    //Variables


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

        //Launch Game
        table.Play();

        //Display After Game Scores (Did user win or lose?)

    }

    public void DebugGame() { //Only so I don't have to see cutscenes and can start instantly
        table.Play();
    }




}