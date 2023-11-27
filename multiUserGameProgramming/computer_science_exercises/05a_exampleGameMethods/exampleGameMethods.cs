//John Lowney, Example Game Methods, v0.3
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        static void startGame()
        {
            Pass;
        }

        static void shootBall()
        {
            Pass;
        }

        static bool coinFlip() 
        //Flips a coin and lets the player guess it. If the player is right, they go first.
        //If they're wrong, the computer goes first.
        {
            Random rndNum = new Random();
            bool goesFirst = True;
            int faceUp = rndNum.Next(1, 2);
            int playerGuess = Convert.ToInt32(Console.ReadLine("Type '1' to guess heads, or '2' to guess tails."));
            if (playerGuess == faceUp) {
                Console.WriteLine("You guessed correctly, and will start with the ball.")
                goesFirst = True
            }
            else {
                Console.WriteLine("You guessed wrong. The computer will start with the ball.")
                goesFirst = False
            }
            return goesFirst;        
        }

        static void passBall()
        {
            Pass;
        }
        static void Main(string[] args)
        {
            coinFlip();
        }
    }    
}

