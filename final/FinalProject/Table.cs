using System;
using System.Globalization;

public class Table : Util {

    //Load Objects
    Dice dice = new Dice();

    //Variables
    private List<int> diceOnTable = new List<int> {};
    private List<int> keptDice = new List<int> {};


    //Methods
    public void TakeTurn() {
        Console.Clear();
        diceOnTable.Clear();
        dice.Roll();
        StoreRoll();
        DisplayRoll();
    }
    private void StoreRoll() {
        if (keptDice.Count > 0) {
            int keptNum = keptDice[0];
            int loopLimit = dice.userRoll.Count - keptDice.Count;

            foreach (int number in keptDice) {
                diceOnTable.Add(number);
            }
            for (int i = 0; i < loopLimit; i++) {
                int number = dice.userRoll[i];
                diceOnTable.Add(number);
            }
            dice.userRoll.Clear();
        } else {
            diceOnTable.AddRange(dice.userRoll); // Move all numbers from userRoll to diceOnTable
            dice.userRoll.Clear();
        }
    }
    private void DisplayRoll() {
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
        Console.WriteLine($"{Roof} {Roof} {Roof} {Roof} {Roof} {Roof} {Roof} {Roof} {Roof} {Roof}");
        // Print top layer
        Console.WriteLine($"{dice.GetTopFrame(Dice1 - 1)} {dice.GetTopFrame(Dice2 - 1)} {dice.GetTopFrame(Dice3 - 1)} {dice.GetTopFrame(Dice4 - 1)} {dice.GetTopFrame(Dice5 - 1)} {dice.GetTopFrame(Dice6 - 1)} {dice.GetTopFrame(Dice7 - 1)} {dice.GetTopFrame(Dice8 - 1)} {dice.GetTopFrame(Dice9 - 1)} {dice.GetTopFrame(Dice10 - 1)}");
        // Print middle layer
        Console.WriteLine($"{dice.GetMiddleFrame(Dice1 - 1)} {dice.GetMiddleFrame(Dice2 - 1)} {dice.GetMiddleFrame(Dice3 - 1)} {dice.GetMiddleFrame(Dice4 - 1)} {dice.GetMiddleFrame(Dice5 - 1)} {dice.GetMiddleFrame(Dice6 - 1)} {dice.GetMiddleFrame(Dice7 - 1)} {dice.GetMiddleFrame(Dice8 - 1)} {dice.GetMiddleFrame(Dice9 - 1)} {dice.GetMiddleFrame(Dice10 - 1)}");
        // Print bottom layer
        Console.WriteLine($"{dice.GetBottomFrame(Dice1 - 1)} {dice.GetBottomFrame(Dice2 - 1)} {dice.GetBottomFrame(Dice3 - 1)} {dice.GetBottomFrame(Dice4 - 1)} {dice.GetBottomFrame(Dice5 - 1)} {dice.GetBottomFrame(Dice6 - 1)} {dice.GetBottomFrame(Dice7 - 1)} {dice.GetBottomFrame(Dice8 - 1)} {dice.GetBottomFrame(Dice9 - 1)} {dice.GetBottomFrame(Dice10 - 1)}");
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

    //unused methods
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
    private void RollOneDice() {
        string result = dice.SimpleRoll();
        Console.WriteLine(result);
    }
}

//I think what I might have to do is work on the display last, so the dice won't look cool but look more like [1] [6] [5]