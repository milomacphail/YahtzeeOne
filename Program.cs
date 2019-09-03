using System;
using System.Linq;
using System.Collections.Generic;

namespace YahtzeeOne
{
    class Dice
    {
        Random rand = new Random();
        List <Dice> gameDice = new List<Dice>();
        int gameLength = 3;
        int value;
        int gameRound = 0;

        public Dice()
        {
            this.value = this.rollDice();
        }

        public Dice(List<Dice> gameDice)
        {
            this.value = this.rollDice();
        }

        public int rollDice()
        {
            return rand.Next(1, 7);    
        }

        public List <Dice> gameRoll()
        {
            for (int rolledDice = 0; rolledDice < gameDice.Count; rolledDice++)
            {
                Dice die = new Dice();
                gameDice[rolledDice] = die;
            }
            return gameDice;
        }

        public List <Dice> reRoll()
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
        }

    }

    /*public class Game
    {
        if 
    }*/


    class Output
    {
        public static void ConsoleIt(List <Dice> gameDice)
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
            Dice Roll = new Dice();
            List <Dice> showRoll = Roll.gameRoll();
            Output.ConsoleIt(showRoll);
        }
    }
}