using System;
using System.Net;

class Tutorial : Util {

    //load objects
    Table table = new Table();

    //methods
    public void Run() {
        Console.WriteLine("You Started the Tutorial! ");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("Weclome to Neil's Tenzi Program!");
        Thread.Sleep(2000);
        Line();
        Console.WriteLine("This program is a recreation of the popular ");
        Console.WriteLine("dice rolling game named Tenzi");
        Continue();
        Line();

        Console.WriteLine("The game is really simple. ");
        Console.WriteLine("The user gets 10 dice and rolls them ");
        Console.WriteLine("until they get all of the same number. ");
        Console.WriteLine("First person to do this wins! ");
        Continue();
        Line();
        Console.WriteLine("However, after the first roll, players can ");
        Console.WriteLine("set aside matching dice and reroll the rest ");
        Console.WriteLine("until all ten dice match. ");
        Continue();
        Console.Clear();

        table.DisplayBaseScreen();
        Thread.Sleep(2000);
        Line();
        Console.WriteLine("This is the game table ");
        Line();
        Console.WriteLine("To roll the dice press enter ");
        Continue();
        Console.Clear();

        DisplayFirstTutorialTable();
        Line();
        Console.WriteLine("Since the six was rolled the most out of your roll");
        Console.WriteLine("You could press 6 on your keyboard ");
        Console.WriteLine("and then press enter to roll again");
        Thread.Sleep(3000);
        Line();
        Continue();
        Console.Clear();

        DisplaySecondTutorialTable();
        Line();
        Console.WriteLine("Notice how all the saved dice moved to the left ");
        Console.WriteLine("and the program generated new ones ");
        Continue();
        Line();
        Console.WriteLine("Now you just need to keep rolling dice ");
        Console.WriteLine("and saving them until you get all ten! ");
        Continue();
        Line();
        Console.WriteLine("Watch out for the other bots though, if ");
        Console.WriteLine("you don't move quick enough they could win");
        Continue();
        Console.Clear();

        Console.WriteLine("You finished the tutorial! ");
        Line();
        Continue();
        Console.Clear();
    }

    private void Continue() {
        bool done = false;
        while (!done) {
            Console.WriteLine("\rPress ENTER to continue: ");
            string input = DetectButton();
            if (input == "Enter") {
                done = true;
            } else {
                done = false;
            }
        }
    }
    private void DisplayFirstTutorialTable() {
        Console.WriteLine("\r=======================================================================================================================");
        Line();
        Console.WriteLine("\rPlayer 2: 0/10 ");
        Console.WriteLine("\rPlayer 3: 0/10 ");
        Console.WriteLine("\rPlayer 4: 0/10 ");

        Line();
        Console.WriteLine(" _______     _______     _______     _______     _______     _______     _______     _______     _______     _______ ");
        Console.WriteLine("| 0   0 |   | 0   0 |   |       |   | 0     |   | 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   | 0     |");
        Console.WriteLine("| 0   0 |   |   0   |   |   0   |   |   0   |   | 0   0 |   |   0   |   | 0   0 |   |   0   |   | 0   0 |   |   0   |");
        Console.WriteLine("|_0___0_|   |_0___0_|   |_______|   |_____0_|   |_0___0_|   |_0___0_|   |_0___0_|   |_0___0_|   |_0___0_|   |_____0_|");
        Line();

        Console.WriteLine("\r=======================================================================================================================");
    }
    private void DisplaySecondTutorialTable() {
        Console.WriteLine("\r=======================================================================================================================");
        Line();
        Console.WriteLine("\rPlayer 2: 0/10 ");
        Console.WriteLine("\rPlayer 3: 0/10 ");
        Console.WriteLine("\rPlayer 4: 0/10 ");

        Line();
        Console.WriteLine(" _______     _______     _______     _______     _______     _______     _______     _______     _______     _______ ");
        Console.WriteLine("| 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   |       |   | 0   0 |   | 0   0 |   | 0   0 |   |       |");
        Console.WriteLine("| 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   | 0   0 |   |   0   |   | 0   0 |   |   0   |   |   0   |   |   0   |");
        Console.WriteLine("|_0___0_|   |_0___0_|   |_0___0_|   |_0___0_|   |_0___0_|   |_______|   |_0___0_|   |_0___0_|   |_0___0_|   |_______|");
        Line();

        Console.WriteLine("\r=======================================================================================================================");
    }
}