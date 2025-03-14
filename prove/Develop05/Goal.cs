using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

class Goal {
    // ------ ATTRIBUTES -------
    protected List<int> points = new List<int>();
    protected List<string> goals = new List<string>();
    protected List<string> descriptions = new List<string>();


    // ------ METHODS ------
    //creates a new line so i don't have to keep typing that massive line of code
    protected void skip() {
        Console.WriteLine(Environment.NewLine);
    }
}
