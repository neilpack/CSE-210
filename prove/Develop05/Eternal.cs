using System;

class Eternal : Goal {
    public void Create() {
        Console.Clear();
        Console.WriteLine("Now Creating a Simple Goal!");
        skip();
        Console.WriteLine("What is the name of your goal? ");
        skip();
        Console.WriteLine("What is a short description of the goal? ");
        skip();
        Console.WriteLine("How many points do you want associated with this goal? ");
        skip();
        Console.WriteLine("---- Eternal Goal Created! ---- ");
        Thread.Sleep(3000);
        Console.Clear();
    }



}