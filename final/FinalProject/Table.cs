using System;

public class Table : Util {

    //Load Objects
    Dice dice = new Dice();

    //Variables
    private List<string> diceResults = new List<string> {}; 


    //Methods
    public void PlayGame() {
        for (int i = 0; i < 10; i++)
            {
                RollDice();
            }
        foreach (string result in diceResults)
            {
                Console.WriteLine(result);
            }

    }

    private void RollDice() {
        string result = dice.Roll();
        diceResults.Add(result);
    }
}

//I think what I might have to do is work on the display last, so the dice won't look cool but look more like [1] [6] [5]