using System;

public class Dice {

//Variables
private List<string> diceSides = new List<string>
// I need them to be as close to the wall
// as possible to prevent a weird display
{
    @"
 _______
|       |
|   0   |
|_______|
",  
    @"
 _______
| 0     |
|       |
|_____0_|
",
    @"
 _______
| 0     |
|   0   |
|_____0_|
",
    @"
 _______
| 0   0 |
|       |
|_0___0_|
",
    @"
 _______
| 0   0 |
|   0   |
|_0___0_|
",
    @"
 _______
| 0   0 |
| 0   0 |
|_0___0_|
"
};

private List<string> diceFramesRoof = new List<string>
{
    " _______ ",
    " _______ ",
    " _______ ",
    " _______ ",
    " _______ ",
    " _______ "
};
private List<string> diceFramesTop = new List<string>
{
    "|       |",
    "| 0     |",
    "| 0     |",
    "| 0   0 |",
    "| 0   0 |",
    "| 0   0 |"
};
private List<string> diceFramesMiddle = new List<string>
{
    "|   0   |",
    "|       |",
    "|   0   |",
    "|       |",
    "|   0   |",
    "| 0   0 |"
};
private List<string> diceFramesBottom = new List<string>
{
    "|_______|",
    "|_____0_|",
    "|_____0_|",
    "|_0___0_|",
    "|_0___0_|",
    "|_0___0_|"
};

    //Methods
    public string SimpleRoll() {
        int randomNumber = GenerateRandomNumber();
        string diceFace = diceSides[randomNumber - 1];
        return diceFace;
    }
    public void Roll() {
        //generate 10 random numbers
        int Dice1 = GenerateRandomNumber();
        int Dice2 = GenerateRandomNumber();
        int Dice3 = GenerateRandomNumber();
        int Dice4 = GenerateRandomNumber();
        int Dice5 = GenerateRandomNumber();
        int Dice6 = GenerateRandomNumber();
        int Dice7 = GenerateRandomNumber();
        int Dice8 = GenerateRandomNumber();
        int Dice9 = GenerateRandomNumber();
        int Dice10 = GenerateRandomNumber();

        //print roof layer
        Console.WriteLine($"{diceFramesRoof[Dice1 -1]} {diceFramesRoof[Dice2 -1]} {diceFramesRoof[Dice3 -1]} {diceFramesRoof[Dice4 -1]} {diceFramesRoof[Dice5 -1]} {diceFramesRoof[Dice6 -1]} {diceFramesRoof[Dice7 -1]} {diceFramesRoof[Dice8 -1]} {diceFramesRoof[Dice9 -1]} {diceFramesRoof[Dice10 -1]}");
        //print top layer
        Console.WriteLine($"{diceFramesTop[Dice1 -1]} {diceFramesTop[Dice2 -1]} {diceFramesTop[Dice3 -1]} {diceFramesTop[Dice4 -1]} {diceFramesTop[Dice5 -1]} {diceFramesTop[Dice6 -1]} {diceFramesTop[Dice7 -1]} {diceFramesTop[Dice8 -1]} {diceFramesTop[Dice9 -1]} {diceFramesTop[Dice10 -1]}");
        //print middle layer
        Console.WriteLine($"{diceFramesMiddle[Dice1 -1]} {diceFramesMiddle[Dice2 -1]} {diceFramesMiddle[Dice3 -1]} {diceFramesMiddle[Dice4 -1]} {diceFramesMiddle[Dice5 -1]} {diceFramesMiddle[Dice6 -1]} {diceFramesMiddle[Dice7 -1]} {diceFramesMiddle[Dice8 -1]} {diceFramesMiddle[Dice9 -1]} {diceFramesMiddle[Dice10 -1]}");
        //print bottom layer
        Console.WriteLine($"{diceFramesBottom[Dice1 -1]} {diceFramesBottom[Dice2 -1]} {diceFramesBottom[Dice3 -1]} {diceFramesBottom[Dice4 -1]} {diceFramesBottom[Dice5 -1]} {diceFramesBottom[Dice6 -1]} {diceFramesBottom[Dice7 -1]} {diceFramesBottom[Dice8 -1]} {diceFramesBottom[Dice9 -1]} {diceFramesBottom[Dice10 -1]}");
    }
    private int GenerateRandomNumber() {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 7);
        return randomNumber;
    }
}