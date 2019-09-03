using System;
using System.Linq;
using System.Collections.Generic;

namespace YahtzeeOne
{
    class Dice
    {
        Random rand = new Random();
        Dice[] gameDice = new Dice[5];
        int value;


        public Dice()
        {
            this.value = this.rollDice();
        }

        /*public Dice(List<Dice> gameDice)
        {
            this.value = this.rollDice();
        }*/

        public int rollDice()
        {
            return rand.Next(1, 7);    
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

        /*public Dice[] reRoll()
        {

            if (gameRound < gameLength)
            {
                {
                    Console.WriteLine("Would you like to reroll?: ");
                    string playerAnswer = Console.ReadLine();
                    if (playerAnswer == "yes" || playerAnswer == "y")
                    {
                        Console.WriteLine("Choose a dice to re-roll");
                        string diceReRollInput = Console.ReadLine();
                        List<Dice> reRolledDie = new List <Dice>();
                    } 
                    gameRound++;
                }
            }
            return gameDice;
        }*/

    }

    public class Game
    {
        int gameLength = 4;

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
            Game playGame = new Game();
            playGame.ThreeRoundGame();
        }
    }
}