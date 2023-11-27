//John Lowney, Example Game Methods, v0.3
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        int score = 0;
        static void startGame() //resets the score to 0 and allows player to choose difficulty. the difficulty effects the chance of scoring when a player takes a shot
        {
            int score = 0;
            Console.WriteLine("Please select difficulty")
            int difficulty = Convert.ToInt32(Console.ReadLine("Type '1' for easy, '2' for medium, or '3' for hard."));
            if (difficulty == 1) {
                stats = 
            } else if (difficulty == 2) {

            } else if (difficulty == 3) {

            } else {

            }
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

        //Allows the player to pass the ball to a random teammate. The player then takes control of that teammate. 
        static void passBall()
        {
            string[] teammates = {"Ronaldo", "Messi", "Rob"};
            int targetPlayer = Convert.ToInt32(Console.ReadLine("Type '1' to pass to Ronaldo, '2' to pass to Messi, or '3' to pass to Rob."));

        }
        static void Main(string[] args)
        {
            coinFlip();
        }
    }    
}

