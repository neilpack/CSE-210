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
    //Methods
    // public void Roll() {
    //     string diceFace = DisplayDice();
    //     Console.WriteLine($"{diceFace}");
    // }
    public string Roll() {
        int randomNumber = GenerateRandomNumber();
        string diceFace = diceSides[randomNumber - 1];
        return diceFace;
    }
    private int GenerateRandomNumber() {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 7);
        return randomNumber;
    }
}