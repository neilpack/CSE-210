using System;

class Statistic : Util {

    //variables
    private int losses = 0;
    private int wins = 0;
    private string filePath = "statistics.txt";

    //methods
    public void DisplayStatistics() {
        Console.WriteLine($"You have won {wins} times ");
        Line();

        Console.WriteLine($"You have lost {losses} times");
        Line();

        Thread.Sleep(3000);
        bool done = false;
        while (!done) {
            Console.WriteLine("\rPress ENTER to continue: ");
            string input = DetectButton();
            if (input == "Enter") {
                done = true;
            } else {
                done = false;
            }
        }

        Console.Clear();
    }
    public void Save() { //save info to txt file
        try {
            using (StreamWriter writer = new StreamWriter(filePath)) {
                writer.WriteLine(wins);
                writer.WriteLine(losses);
            }
        }
        catch (Exception ex) {
            Console.WriteLine($"Error saving statistics: {ex.Message}");
        }
    }
    public void Load() { //load info from txt file
        try {
            if (File.Exists(filePath)) {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 2) {
                    wins = int.Parse(lines[0]);
                    losses = int.Parse(lines[1]);
                }
            }
        }
        catch (Exception ex) {
            Console.WriteLine($"Error loading statistics: {ex.Message}");
        }
    }
    public void CreateFile() { //if txt file doesnt exist, create it
        if (!File.Exists(filePath)) {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating file: {ex.Message}");
            }
        }
    }
}