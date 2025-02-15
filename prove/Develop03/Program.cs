using System;

class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        while (!scripture.IsFinished()) {
            scripture.displayScripture();
        }
        
        Console.WriteLine("");
        Console.WriteLine("You Memorized the Scripture!");
        Console.WriteLine("");
    }
}


// How should this program work?
// User will be given a scripture (one scripture is required, but if you want to add more that will earn extra points)
// then it says "press enter or quit"
//after pressing enter then a random 3 were hidden (they have to be 3 different words, not the same word)
// detects once everything is hidden, it will exit the program

//classes -> program.cs scipture.cs verse.cs word.cs

//program class will contain scriptures

//main is the constructor here
//(method) enter: is the program finished? 