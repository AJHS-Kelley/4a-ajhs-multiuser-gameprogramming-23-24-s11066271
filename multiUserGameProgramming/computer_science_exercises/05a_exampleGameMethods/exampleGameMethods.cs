//John Lowney, Example Game Methods, v0.2
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
            numDice = System.Convert.ToInt32(Console.ReadLine());
            while(i < numDice){
            Random rndNum = new Random();
            diceRoll = rndNum.Next(1, 6);
            Console.WriteLine("You rolled a " + diceRoll);
            i++;
            }
        }
        static void Main(string[] args)
        {
            DiceRoll();
        }
    }
}
