using System;

namespace YahtzeeOne
{
    class Dice
    {
        Random diceNumber = new Random();

        public void rollDice()
        {
            int diceRoll = diceNumber.Next(1, 6);
            Console.WriteLine(diceRoll);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dice gameRoll = new Dice();
            gameRoll.rollDice();
        }
    }
}
