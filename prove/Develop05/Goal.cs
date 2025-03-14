using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

class Goal {
    // ------ ATTRIBUTES -------
    protected static List<int> points = new List<int>();
    protected static List<string> goals = new List<string>();
    protected static List<string> descriptions = new List<string>();
    protected static List<string> goalType = new List<string>();

    protected static List<int> bonuses = new List<int>();
    protected static List<int> toCompleteBonus = new List<int>();
    protected static List<bool> goalCompletionStatus = new List<bool>();
    protected static List<int> checklistGarbage = new List<int>(); //This is a stupid tier up checklist thing that was super annoying to make

    protected static List<int> _totalPoints = new List<int>(); //scoreboard points


    // ------ METHODS ------
    //creates a new line so i don't have to keep typing that massive line of code
    protected void skip() {
        Console.WriteLine(Environment.NewLine);
    }
}
