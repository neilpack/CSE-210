using System;
using System.Numerics;

class Eternal : Goal {
    public void Create() {
        Console.Clear();
        Console.WriteLine("Now Creating an Eternal Goal!");
        string gt = "Eternal";
        goalType.Add(gt);

        int bonusTimes = 0;
        toCompleteBonus.Add(bonusTimes);

        int bonusAmount = 0;
        bonuses.Add(bonusAmount);

        int checklistPoop = 0;
        checklistGarbage.Add(checklistPoop);

        goalCompletionStatus.Add(false);

        skip();
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine(); 
        goals.Add(goalName);

        skip();
        Console.WriteLine("What is a short description of the goal? ");
        string goalDesc = Console.ReadLine(); 
        descriptions.Add(goalDesc);

        skip();
        Console.WriteLine("How many points do you want associated with this goal? ");
        bool done = false;
        int associatedPoints = 0; // Declare the variable outside the loop so it can be used later
        while (!done) {
            if (int.TryParse(Console.ReadLine(), out associatedPoints)) {
                points.Add(associatedPoints);
                done = true;
            } else {
                Console.WriteLine("Invalid input. Please enter a number.");
                skip();
            }
        }

        skip();
        Console.WriteLine("---- Eternal Goal Created! ---- ");
        Thread.Sleep(3000);
        Console.Clear();
    }
    public void recordEvent() {
        skip();
        // Check if the lists are empty
        if (goals.Count == 0 || descriptions.Count == 0 || points.Count == 0) {
            Console.WriteLine("No goals to display.");
            return;
        }
        Console.WriteLine("The Goals Are: ");

        // Loop through the goals list using the index
        for (int i = 0; i < goals.Count; i++) {
            string displayGoal = goals[i];
            int bulletPoint = (i + 1);
            string typeGoal = goalType[i];
            int bonu = toCompleteBonus[i];
            int poop = checklistGarbage[i];

            string checkmark = " ";
            if (typeGoal == "Simple") {
                checkmark = goalCompletionStatus[i] ? "X" : " ";
            } else if (typeGoal == "Checklist") {
                checkmark = goalCompletionStatus[i] ? " " : " ";
                if (poop == bonu) {
                    checkmark = goalCompletionStatus[i] ? "X" : " ";
                }
            } else if (typeGoal == "Eternal") {
                checkmark = goalCompletionStatus[i] ? "∞" : "∞";
            }
            Console.WriteLine($"{bulletPoint}. [{checkmark}] {displayGoal}");
        }

        bool done = false;
        while (!done) {
            bool isCompleted = false;
            Console.WriteLine("Which goal did you complete? ");
            string choice = Console.ReadLine();
            // Attempt to convert the string to an integer
            int goalIndex;
            if (int.TryParse(choice, out goalIndex)) {
                Console.WriteLine($"You chose goal number {goalIndex}");
                for (int i = 0; i < goals.Count; i++) {
                    int bulletPoint = (i + 1);
                    int displayPoint = points[i];
                    string typeGoal = goalType[i];
                    int cermp = toCompleteBonus[i];
                    if (goalIndex == bulletPoint) {
                        isCompleted = true;
                        // mark checkmark
                        goalCompletionStatus[i] = true;
                        //add points to scoreboard
                        _totalPoints.Add(displayPoint);
                        //tier up one checklist number
                        if (typeGoal == "Checklist") {
                            checklistGarbage[i] += 1;
                            int cg = checklistGarbage[i];
                            if (cg == cermp) {
                                _totalPoints.Add(bonuses[i]);
                                Console.WriteLine("You Earned A Bonus! ");
                            }
                        }
                    }
                    if (isCompleted) {
                        done = true;
                    }
                }
                if (!isCompleted) {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } else {
                // Invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}