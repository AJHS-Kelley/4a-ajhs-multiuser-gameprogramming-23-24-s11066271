//John Lowney, Example Game Methods, v0.01
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        static void MethodOne()
        {
            
        }

        static void MethodTwo()
        {

        }

        static int DiceRoll()
        {
            int diceRoll = 0;
            Random rndNum = new Random();
            diceRoll = rndNum.Next(1, 6);
            Console.WriteLine("You rolled a " + diceRoll);
            return diceRoll;
        }
    }
}
