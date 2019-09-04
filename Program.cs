using System;
using System.Linq;
using System.Collections.Generic;

namespace YahtzeeOne
{

    class Dice
    {
        int gameRound = 0;
        int gameLength = 3;

        Random rand = new Random();
        Dice[] gameDice = new Dice[5];
        int value;


        public Dice()
        {
            this.value = this.rollDice();
        }

        public int rollDice()
        {
            return rand.Next(1, 7);    
        }

        public int rollDice(Dice die)
        {
            return rand.Next(1, 7);
        }

        public Dice[] gameRoll()
        {
            for (int rolledDice = 0; rolledDice < gameDice.Length; rolledDice++)
            {
                gameDice[rolledDice] = new Dice();
            }
            Output.ConsoleIt(gameDice);
            return gameDice;
        }

        public Dice[] reRoll()
        {

            if (gameRound < gameLength)
            {
                {
                    Console.WriteLine("Would you like to reroll?: ");
                    string playerAnswer = Console.ReadLine();
                    if (playerAnswer == "yes" || playerAnswer == "y")
                    {
                        Console.WriteLine("Choose a dice to re-roll");
                        int diceReRollInput = Convert.ToInt32(Console.ReadLine());
                        Dice dieReRolled = gameDice[diceReRollInput];
                        dieReRolled.rollDice(dieReRolled);

                    } 
                    gameRound++;
                }
            }
            Output.ConsoleIt(gameDice);
            return gameDice;
        }

    }

    public class Game
    {
        int gameLength = 4;

        public void Round()
        {
                Dice Roll = new Dice();
                Dice[] showRoll = Roll.gameRoll();
                Output.ConsoleIt(showRoll);
        }


        public void ThreeRoundGame()
        {
            for (int gameRound = 1; gameRound < gameLength; gameRound ++)
            {
                Console.WriteLine("Round {0}", gameRound);
                Dice Roll = new Dice();
                Dice[] showRoll = Roll.gameRoll();
                Output.ConsoleIt(showRoll);
            }
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
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dice newGame = new Dice();
            Dice[] gameRoll = newGame.gameRoll();
            
        }
    }
}