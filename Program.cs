using System;

namespace YahtzeeOne
{
    class Dice
    {
        Random rand = new Random();
        Dice[] gameDice = new Dice[5];
        int gameRound = 0;
        int gameLength = 3;
        int value;

        public Dice()
        {
            this.value = this.rollDice();
        }

        public int rollDice()
        {
            return rand.Next(1, 6);    
        }

        public Dice[] gameRoll()
        {
            for (int rolledDice = 0; rolledDice < gameDice.Length; rolledDice++)
            {
                Dice die = new Dice();
                gameDice[rolledDice] = die;
            }
            return gameDice;
        }

        public Dice[] reRoll()
        {
            if (gameRound < gameLength)
            {
                {
                    gameDice = gameRoll();
                    gameRound++;
                }
            }
            return gameDice;
        }

    }

    class Output
    {
        public static void ConsoleIt(Dice[] gameDice)
        {
            foreach (Dice item in gameDice)
            {
                Console.WriteLine(item.rollDice()); ;
            }

            //Console.WriteLine("Total Cards:  {0}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dice Roll = new Dice();
            var showRoll = Roll.gameRoll();
            Output.ConsoleIt(showRoll);
        }
    }
}