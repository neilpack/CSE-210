using System;
using System.Globalization;
using System.IO.Compression;

class BotPlayer : Util {
    //my objects
    Dice dice = new Dice();

    //variables
    private List<int> botDice = new List<int> {};
    public bool botHasWon = false; 
    private volatile bool _running = true; //volatile means all three different threads see the change instead of just one
    private int _botId;
    protected int difficultyDelay = 3000;
    
    //constructor to assign bot ID
    public BotPlayer(int botId) {
        _botId = botId;
    }
    
    //methods
    public void Start() {
        botDice.Clear();
        botHasWon = false;
        _running = true;

        //sets the bot difficulty
        UpdateDifficulty();

        //reset static util variables
        if (_botId == 1) _botPoints1 = 0;
        else if (_botId == 2) _botPoints2 = 0;
        else if (_botId == 3) _botPoints3 = 0;

        while (_running && !botHasWon) {
            BotTurn();
            Thread.Sleep(difficultyDelay); //this dynamically updates to change difficulty
        }
    }
    private void BotTurn() {
        int loopLimit = 10 - botDice.Count();
        for (int i = 0; i < loopLimit; i++) {
            int roll = dice.SimpleRoll();
            if (roll == 5) { //I chose 5 because it was an random number
                botDice.Add(roll);

                // Add a point based on thread ID
                if (_botId == 1) _botPoints1++;
                else if (_botId == 2) _botPoints2++;
                else if (_botId == 3) _botPoints3++;
            }
        }

        if (botDice.Count() == 10) {
            botHasWon = true;
        }
    }
    public void Stop() {
        _running = false;
    }

    //Bot difficulty Polymorphism Methods
    public virtual void UpdateDifficulty() {
        difficultyDelay = 3000;
    }
}
class EasyBot : BotPlayer {
    public EasyBot(int botId) : base(botId) { } //it is really complex what is going on here but
    public override void UpdateDifficulty() { // : base(botId) calls the constructor of the parent class (BotPlayer) and passes botId to it
        difficultyDelay = 6000; //easy
    }
}

class MediumBot : BotPlayer {
    public MediumBot(int botId) : base(botId) { }
    public override void UpdateDifficulty() {
        difficultyDelay = 3000; // medium difficulty
    }
}

class HardBot : BotPlayer {
    public HardBot(int botId) : base(botId) { }
    public override void UpdateDifficulty() {
        difficultyDelay = 1000; // hard
    }
}