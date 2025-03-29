using System;

public class Util
{
    //Variables
    static protected int _botPoints1 = 0;
    static protected int _botPoints2 = 0;
    static protected int _botPoints3 = 0;

    // Methods
    static protected void Line() { //Helper Method that makes it easier to Create New Lines
        Console.WriteLine(Environment.NewLine);
    }

    protected string DetectButton() { //method to return string if a certain button is pressed from user
        ConsoleKeyInfo pressButton = Console.ReadKey(true);

        switch (pressButton.Key) {
            case ConsoleKey.Enter: return "Enter";
            case ConsoleKey.D1:    return "1";
            case ConsoleKey.D2:    return "2";
            case ConsoleKey.D3:    return "3";
            case ConsoleKey.D4:    return "4";
            case ConsoleKey.D5:    return "5";
            case ConsoleKey.D6:    return "6";
            case ConsoleKey.D7:    return "7";
            case ConsoleKey.D8:    return "8";
            case ConsoleKey.D9:    return "9";
            case ConsoleKey.D0:    return "0";
            default:               return "";
        }
    }
}