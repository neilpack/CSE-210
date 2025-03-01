using System;

// This class will just contain all of the attributes and methods that I don't want to duplicate
// the attributes will be protected instead of public that way the inheritance works

class Activity {

    //ATTRIBUTES
    protected string activityName = "";
    protected int Timer = 0;
    protected bool sessionComplete = false;
    protected string[] loadingAnimation = {
            "Loading Activity: [          ]",
            "Loading Activity: [█         ]",
            "Loading Activity: [██        ]",
            "Loading Activity: [███       ]",
            "Loading Activity: [████      ]",
            "Loading Activity: [█████     ]",
            "Loading Activity: [██████    ]",
            "Loading Activity: [███████   ]",
            "Loading Activity: [████████  ]",
            "Loading Activity: [█████████ ]",
            "Loading Activity: [██████████]",
        };
    




    //METHODS
    protected void StartCountdown(int seconds) { //Timer counts down
        for (int i = seconds; i > 0; i--) {
            Thread.Sleep(1000);
        }
        sessionComplete = true;
        Console.Clear();
        Console.WriteLine($"{Timer} Second {activityName} Session complete!");
        Thread.Sleep(3000);
    }
    protected void displayAnimation() { //displays loading animation before activities
        foreach (string frame in loadingAnimation) {
            Console.Write($"\r{frame}");
            Thread.Sleep(500);
        }
    }
    protected int getUserInput() { // get the user input for how long activity
        while (true) {
            Console.WriteLine("\rHow long, in seconds, would you like your session? ");  
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userInput)) {
                return userInput;
            } else {
                Console.WriteLine("\rInvalid input. Please enter a valid number.");
            }
        }
    }
}