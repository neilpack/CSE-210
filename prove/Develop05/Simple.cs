using System;

class Simple : Goal {
    public void Create() {
        Console.Clear();
        Console.WriteLine("Now Creating a Simple Goal!");
        string gt = "Simple";
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
        Console.WriteLine("---- Simple Goal Created! ---- ");
        Thread.Sleep(3000);
        Console.Clear();
    }
    public void displayList() {

        // Check if the lists are empty
        if (goals.Count == 0 || descriptions.Count == 0 || points.Count == 0) {
            Console.WriteLine("No goals to display.");
            return;
        }

        Console.Clear();

        // Loop through the goals list using the index
        for (int i = 0; i < goals.Count; i++) {
            string displayGoal = goals[i];
            string displayDescription = descriptions[i];
            int displayPoint = points[i];
            int bulletPoint = (i + 1);
            int bonu = toCompleteBonus[i];
            string typeGoal = goalType[i];

            int poop = checklistGarbage[i];

            string checkmark = " ";
            if (typeGoal == "Simple") {
                checkmark = goalCompletionStatus[i] ? "█" : " ";
            } else if (typeGoal == "Checklist") {
                checkmark = goalCompletionStatus[i] ? " " : " ";
                if (poop == bonu) {
                    checkmark = goalCompletionStatus[i] ? "█" : " ";
                }
            } else if (typeGoal == "Eternal") {
                checkmark = goalCompletionStatus[i] ? " " : " ";
            }

            skip();
            Console.WriteLine($"{bulletPoint}. [{checkmark}] {displayGoal} ({displayDescription}) --- {displayPoint} Points ");
            if (typeGoal == "Checklist") {
                Console.Write($"-- Currently Completed {poop}/{bonu} ");
            }
            
        }
        skip();
        Thread.Sleep(3000);
    }

    public void Save() {
        // Check if any list is empty
        if (goals.Count == 0 || descriptions.Count == 0 || points.Count == 0 || goalType.Count == 0 || bonuses.Count == 0 || toCompleteBonus.Count == 0) {
            Console.WriteLine("There is nothing to save yet!");
            return;
        }
        Console.Clear();

        using (StreamWriter writer = new StreamWriter("goals.txt")) {
            for (int i = 0; i < goals.Count; i++) {
                writer.WriteLine($"{goals[i]}:{descriptions[i]}:{points[i]}:{goalType[i]}:{toCompleteBonus[i]}:{bonuses[i]}:{goalCompletionStatus[i]}:{checklistGarbage[i]}");
            }
            writer.WriteLine("---TOTAL_POINTS---");
            foreach (int totalPoint in _totalPoints) {
                writer.WriteLine(totalPoint);
            }
        }
        
        skip();
        Console.WriteLine("Goals Saved!");
        Console.WriteLine("(saved to goals.txt)");
        skip();
        Thread.Sleep(3000);
    }

    public void Load() {
        Console.Clear();
        if (!File.Exists("goals.txt")) {
            Console.WriteLine("No saved goals found.");
            return;
        }

        // Clear existing lists before loading
        goals.Clear();
        descriptions.Clear();
        points.Clear();
        goalType.Clear();
        toCompleteBonus.Clear();
        bonuses.Clear();
        goalCompletionStatus.Clear();
        checklistGarbage.Clear();
        _totalPoints.Clear();

        using (StreamReader reader = new StreamReader("goals.txt")) {
            string line;
            bool loadingTotalPoints = false;

            while ((line = reader.ReadLine()) != null) {
                if (line == "---TOTAL_POINTS---") {
                    loadingTotalPoints = true;
                    continue;
                }

                if (!loadingTotalPoints) {
                    // Load goal data
                    string[] parts = line.Split(':');
                    if (parts.Length == 8) {  // Adjusted to 8 to match the saved format
                        goals.Add(parts[0]);                 // Goal name
                        descriptions.Add(parts[1]);          // Goal description
                        points.Add(int.Parse(parts[2]));     // Goal points
                        goalType.Add(parts[3]);              // Goal type
                        toCompleteBonus.Add(int.Parse(parts[4])); // Bonus completion times
                        bonuses.Add(int.Parse(parts[5]));    // Bonus amount
                        goalCompletionStatus.Add(bool.Parse(parts[6])); // Completion status (bool)
                        checklistGarbage.Add(int.Parse(parts[7])); // Checklist garbage (int)
                    }
                } else {
                    // Load _totalPoints
                    if (int.TryParse(line, out int totalPoint)) {
                        _totalPoints.Add(totalPoint);
                    }
                }
            }
        }

        Console.WriteLine("Goals Loaded Successfully.");
        skip();
        Thread.Sleep(3000);
    }
}