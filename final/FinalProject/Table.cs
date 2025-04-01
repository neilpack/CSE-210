using System;
using System.Globalization;

public class Table : Util {

    //Load Objects
    Dice dice = new Dice();

    //Variables
    private List<int> diceOnTable = new List<int> {};
    private List<int> keptDice = new List<int> {};

    //Methods
    public bool TakeTurn() {
        Console.Clear();
        diceOnTable.Clear();

        dice.Roll();
        StoreRoll();
        DisplayRoll();

        if (DetectWin()) {
            return true;
        } else {
            return false;
        }
    }
    private void StoreRoll() {
        if (keptDice.Count > 0) {
            int loopLimit = dice.userRoll.Count - keptDice.Count;

            foreach (int number in keptDice) {
                diceOnTable.Add(number);
            }
            for (int i = 0; i < loopLimit; i++) {
                int number = dice.userRoll[i];
                diceOnTable.Add(number);
            }
        } else {
            diceOnTable.AddRange(dice.userRoll);
        }
        dice.userRoll.Clear();
    }
    private void DisplayRoll() {

        Console.WriteLine("\r=======================================================================================================================");
        
        Line();

        Console.WriteLine($"\rPlayer 2: {_botPoints1}/10 ");
        Console.WriteLine($"\rPlayer 3: {_botPoints2}/10 ");
        Console.WriteLine($"\rPlayer 4: {_botPoints3}/10 ");

        Line();

        string Roof = " _______ ";
        int Dice1 = diceOnTable[0];
        int Dice2 = diceOnTable[1];
        int Dice3 = diceOnTable[2];
        int Dice4 = diceOnTable[3];
        int Dice5 = diceOnTable[4];
        int Dice6 = diceOnTable[5];
        int Dice7 = diceOnTable[6];
        int Dice8 = diceOnTable[7];
        int Dice9 = diceOnTable[8];
        int Dice10 = diceOnTable[9];
        //print roof layer
        Console.WriteLine($"\r{Roof}   {Roof}   {Roof}   {Roof}   {Roof}   {Roof}   {Roof}   {Roof}   {Roof}   {Roof}");
        // Print top layer
        Console.WriteLine($"\r{dice.GetTopFrame(Dice1 - 1)}   {dice.GetTopFrame(Dice2 - 1)}   {dice.GetTopFrame(Dice3 - 1)}   {dice.GetTopFrame(Dice4 - 1)}   {dice.GetTopFrame(Dice5 - 1)}   {dice.GetTopFrame(Dice6 - 1)}   {dice.GetTopFrame(Dice7 - 1)}   {dice.GetTopFrame(Dice8 - 1)}   {dice.GetTopFrame(Dice9 - 1)}   {dice.GetTopFrame(Dice10 - 1)}");
        // Print middle layer
        Console.WriteLine($"\r{dice.GetMiddleFrame(Dice1 - 1)}   {dice.GetMiddleFrame(Dice2 - 1)}   {dice.GetMiddleFrame(Dice3 - 1)}   {dice.GetMiddleFrame(Dice4 - 1)}   {dice.GetMiddleFrame(Dice5 - 1)}   {dice.GetMiddleFrame(Dice6 - 1)}   {dice.GetMiddleFrame(Dice7 - 1)}   {dice.GetMiddleFrame(Dice8 - 1)}   {dice.GetMiddleFrame(Dice9 - 1)}   {dice.GetMiddleFrame(Dice10 - 1)}");
        // Print bottom layer
        Console.WriteLine($"\r{dice.GetBottomFrame(Dice1 - 1)}   {dice.GetBottomFrame(Dice2 - 1)}   {dice.GetBottomFrame(Dice3 - 1)}   {dice.GetBottomFrame(Dice4 - 1)}   {dice.GetBottomFrame(Dice5 - 1)}   {dice.GetBottomFrame(Dice6 - 1)}   {dice.GetBottomFrame(Dice7 - 1)}   {dice.GetBottomFrame(Dice8 - 1)}   {dice.GetBottomFrame(Dice9 - 1)}   {dice.GetBottomFrame(Dice10 - 1)}");

        Line();

        Console.WriteLine("\r=======================================================================================================================");

        Line();
    }
    public void Clean() { //when playing a second time it's good to reset the dice
        diceOnTable.Clear();
        keptDice.Clear();
    }
    private bool DetectWin() {
        if (diceOnTable.Count == 0) //if list empty then false
            return false;

        int referenceNum = diceOnTable[0];
        foreach (int num in diceOnTable) {
            if (num != referenceNum) { // if any number is different, return false
                return false;
            }
        }

        return true;
    }
    public void DisplayBaseScreen() {
        Console.WriteLine("\r=======================================================================================================================");
        Line();
        Console.WriteLine("\rPlayer 2: 0/10 ");
        Console.WriteLine("\rPlayer 3: 0/10 ");
        Console.WriteLine("\rPlayer 4: 0/10 ");
        Line();

        //this is where the dice would go
        Line();
        Console.WriteLine(Environment.NewLine);
        Line();

        Console.WriteLine("\r=======================================================================================================================");
    }

    //keep specific dice methods
     public void KeepNumOne() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 1) {
                keptDice.Add(number);
            }
        }
    }
    public void KeepNumTwo() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 2) {
                keptDice.Add(number);
            }
        }
    }
    public void KeepNumThree() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 3) {
                keptDice.Add(number);
            }
        }
    }
    public void KeepNumFour() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 4) {
                keptDice.Add(number);
            }
        }
    }
    public void KeepNumFive() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 5) {
                keptDice.Add(number);
            }
        }
    }
    public void KeepNumSix() {
        keptDice.Clear();
        foreach (int number in diceOnTable) {
            if (number == 6) {
                keptDice.Add(number);
            }
        }
    }

    //debugger + helper methods
    public void Debug() {
        Line();
        Console.WriteLine("Dice on Table");
        foreach (int number in diceOnTable) {
            Console.Write($"{number} ");
        }
        Line();
        Console.WriteLine("Kept Dice");
        foreach (int number in keptDice) {
            Console.Write($"{number} ");
        }
    }
}