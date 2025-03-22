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


        //Launch Game
        table.PlayGame();

    }

    public void DebugGame() { //Only so I don't have to see cutscenes and can start instantly
        table.PlayGame();
    }




}