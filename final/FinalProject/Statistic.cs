using System;

class Statistic : Util {

    //variables
    private int losses = 0;
    private int wins = 0;
    private string filePath = "statistics.txt";

    //constructors
    public void GetWinPoint() {
        wins++;
    }
    public void GetLossPoint() {
        losses++;
    }

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
        using (StreamWriter writer = new StreamWriter(filePath)) {
            writer.WriteLine(wins);
            writer.WriteLine(losses);
        }
    }
    public void Load() { //load info from txt file
        if (File.Exists(filePath)) {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 2) {
                wins = int.Parse(lines[0]);
                losses = int.Parse(lines[1]);
            }
        }
    }
    public void CreateFile() { //if txt file doesnt exist, create it
        if (!File.Exists(filePath)) {
            using (StreamWriter writer = new StreamWriter(filePath)) {
                writer.WriteLine("0");
                writer.WriteLine("0");
            }
        }
    }
}