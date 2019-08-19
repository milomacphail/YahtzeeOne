using System;

namespace YahtzeeOne
{
    class Dice
    {
        Random diceNumber = new Random();
        int[] gameDice = new int[5];

        public void rollDice()
        {
            int diceRoll = diceNumber.Next(1, 6);
            Console.WriteLine(diceRoll);
        }

        public void gameRoll()
        {
            for (int rolledDice = 0; rolledDice < gameDice.Length; rolledDice++)
            {
                int diceRoll = diceNumber.Next(1, 6);
                gameDice[rolledDice] = diceRoll;
                Console.WriteLine(gameDice[rolledDice]);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Dice Roll = new Dice();
                Roll.gameRoll();
            }
        }
    }
}
