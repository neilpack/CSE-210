using System;
using System.ComponentModel;

class Checklist : Goal {
    public void Create() {
        Console.Clear();
        Console.WriteLine("Now Creating a Checklist Goal!");
        string gt = "Checklist";
        goalType.Add(gt);
        skip();

        goalCompletionStatus.Add(false);

        int checklistPoop = 0;
        checklistGarbage.Add(checklistPoop);

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
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int bonusTimes = 0;
        done = false;
        while (!done) {
            if (int.TryParse(Console.ReadLine(), out bonusTimes)) {
                toCompleteBonus.Add(bonusTimes);
                done = true;
            } else {
                Console.WriteLine("Invalid input. Please enter a number.");
                skip();
            }
        }
        skip();
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        int bonusAmount = 0;
        done = false;
        while (!done) {
            if (int.TryParse(Console.ReadLine(), out bonusAmount)) {
                bonuses.Add(bonusAmount);
                done = true;
            } else {
                Console.WriteLine("Invalid input. Please enter a number.");
                skip();
            }
        }
        skip();


        Console.WriteLine("---- Checklist Goal Created! ---- ");
        Thread.Sleep(3000);
        Console.Clear();
    }
    public void displayPoints() {
        int totalPoints = 0;
        for (int i = 0; i < _totalPoints.Count; i++) {
            int addingPoints = _totalPoints[i];
            totalPoints = addingPoints + totalPoints;
        }
        Console.WriteLine($"You have {totalPoints} Points");
    }
    public int returnPoints() {
        int totalPoints = 0;
        for (int i = 0; i < _totalPoints.Count; i++) {
            int addingPoints = _totalPoints[i];
            totalPoints = addingPoints + totalPoints;
        }
        return totalPoints;
    }


}