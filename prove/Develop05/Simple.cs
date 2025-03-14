using System;

class Simple : Goal {
    public void Create() {
        Console.Clear();
        Console.WriteLine("Now Creating a Simple Goal!");
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

            skip();
            Console.WriteLine($"{bulletPoint}. [ ] {displayGoal} ({displayDescription}) --- {displayPoint} Points");
        }
        skip();
        Thread.Sleep(3000);
    }

    public void Save() {
        // Check if the lists are empty
        if (goals.Count == 0 || descriptions.Count == 0 || points.Count == 0) {
            Console.WriteLine("There is nothing to save yet!");
            return;
        }
        Console.Clear();
        
        // Append goals, descriptions, and points to the file
        File.AppendAllLines("goals.txt", goals.Select((goal, index) => $"{goal}:{descriptions[index]}:{points[index]}"));
        
        skip();
        Console.WriteLine("Goals Saved!");
        Console.WriteLine("(saved to goals.txt)");
        skip();
        Thread.Sleep(3000);
    }
    public void Load() {
        Console.Clear();
        if (File.Exists("goals.txt")) {
            goals.Clear();
            descriptions.Clear();
            points.Clear();

            using (StreamReader reader = new StreamReader("goals.txt")) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    // Split the line by colon to separate goal, description, and points
                    string[] parts = line.Split(':');
                    if (parts.Length == 3) {
                        // Add to respective lists
                        goals.Add(parts[0]);         // Goal name
                        descriptions.Add(parts[1]);  // Goal description
                        points.Add(int.Parse(parts[2])); // Goal points
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        } else {
            Console.WriteLine("No saved goals found.");
        }
        skip();
        Thread.Sleep(3000);
    }


}