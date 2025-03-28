using System;

public class Dice {

//Variables
public List<int> userRoll = new List<int> {};
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

    //Constructors (So Table Can Access Dice Frames)
    public string GetTopFrame(int index) { //top
        if (index >= 0 && index < diceFramesTop.Count) {
            return diceFramesTop[index]; 
        } else {
            return "Invalid index";
        }
    }
    public string GetMiddleFrame(int index) { //middle
        if (index >= 0 && index < diceFramesMiddle.Count) {
            return diceFramesMiddle[index]; 
        } else {
            return "Invalid index";
        }
    }
    public string GetBottomFrame(int index) { //bottom
        if (index >= 0 && index < diceFramesBottom.Count) {
            return diceFramesBottom[index]; 
        } else {
            return "Invalid index";
        }
    }

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

        // append to userRoll list
        userRoll.Add(Dice1);
        userRoll.Add(Dice2);
        userRoll.Add(Dice3);
        userRoll.Add(Dice4);
        userRoll.Add(Dice5);
        userRoll.Add(Dice6);
        userRoll.Add(Dice7);
        userRoll.Add(Dice8);
        userRoll.Add(Dice9);
        userRoll.Add(Dice10);
    }
    private int GenerateRandomNumber() {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 7);
        return randomNumber;
    }
}