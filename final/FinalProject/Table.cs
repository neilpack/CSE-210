using System;

public class Table : Util {

    //Load Objects
    Dice dice = new Dice();

    //Variables
    private bool gameComplete = false;



    //Methods
        public void Play() {
            //Display Game Board (Table)
            Console.WriteLine("Press Enter or a number (0-9): ");

            //keep taking inputs from user if game isn't complete
            while (!gameComplete) {
                string input = DetectButton();
                if (!string.IsNullOrEmpty(input)) {
                    ExecuteInput(input);
                }
            }

            //game finished (display final board)
            
        }

    private void ExecuteInput(string input) {
        switch (input)
        {
            case "Enter":
                Console.WriteLine("You pressed Enter");
                //roll dice that aren't in kept list
                break;
            case "1":
                Console.WriteLine("You pressed 1");
                break;
            case "2":
                Console.WriteLine("You pressed 2");
                break;
            case "3":
                Console.WriteLine("You pressed 3");
                break;
            case "4":
                Console.WriteLine("You pressed 4");
                break;
            case "5":
                Console.WriteLine("You pressed 5");
                break;
            case "6":
                Console.WriteLine("You pressed 6");
                break;
            case "7":
                Console.WriteLine("You pressed 7");
                break;
            case "8":
                Console.WriteLine("You pressed 8");
                break;
            case "9":
                Console.WriteLine("You pressed 9");
                break;
            case "0":
                Console.WriteLine("You pressed 0");
                break;
            default:
                break;
        }
    }

    private void RollOneDice() {
        string result = dice.SimpleRoll();
        Console.WriteLine(result);
    }
}

//I think what I might have to do is work on the display last, so the dice won't look cool but look more like [1] [6] [5]