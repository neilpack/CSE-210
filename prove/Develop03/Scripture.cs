using System;
using System.Collections.Generic;

// 13 Behold, I am a disciple of Jesus Christ, the Son of God.
// I have been called of him to declare his word among his people,
// that they might have everlasting life.

public class Scripture
{
    Verse verse = new Verse(); // Instance so I can call my classes


    //method to display scripture (including the hidden words)
    public void displayScripture()
    {
        Console.WriteLine("");
        Console.WriteLine("Here is the scripture: ");
        Console.WriteLine("3 Nephi 5:13");

        foreach (var word in verse.GetWords()) { // Access words from Verse class
            Console.Write(word.GetText() + " "); 
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Erase 3 Words");
        Console.WriteLine("Or press Escape to Quit Program");
        Console.WriteLine("");
        string action = WaitForKey();

        if (action == "pressed_enter") {
            // Call a method to erase 3 words
            verse.ChooseRandomWord();
            verse.ChooseRandomWord();
            verse.ChooseRandomWord();

        } 
        else if (action == "pressed_escape") {
            Environment.Exit(0);
        }
    }

    //detects if a key has been pressed and returns a string
    public string WaitForKey() {
    while (true) {
        var key = Console.ReadKey(true).Key; 
        if (key == ConsoleKey.Enter) {
            Console.WriteLine("You Pressed Enter");
            return "pressed_enter"; 
        } 
        else if (key == ConsoleKey.Escape) {
            Console.WriteLine("You Pressed Escape! Now Quitting...");
            return "pressed_escape";
        } 
        else {
            Console.WriteLine("Please Press Escape or Enter");
            Console.WriteLine("Try Again");
        }
    }
}

    //method to check if finished
    public bool IsFinished() {
        if (verse.IsFinished()){
            return true;
        }
        else {
            return false;
        }
    }
}