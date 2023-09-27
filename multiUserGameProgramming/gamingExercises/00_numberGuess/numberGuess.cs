//John Lowney, Number Guess, v0.05
/*
Generate secret number from a range 
Print game instructions including range and # of guesses allowed.
    MATCH == first player to score 3 points
    ROUND == guessing a specific number, until correct or no more attempts.
Ask player what difficulty they want.
Player guesses number
Determine if guess is correct or not
    If guess is correct {
        Tell them they have guessed correctly. 
        Give them a point
    } else {
        Tell them they are wrong
        Tell player if guess is too high or too low
        Check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.
            }
        }

    }
*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN.
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the number guess game!\nYou will select a difficulty next.\n");
            Console.WriteLine("Easy Mode: Range is 0-10 with 4 guesses.\nNormal mode: Range is 0-25 with 4 guesses.\nHard Mode: range is 0-50 with 3 guesses.\n");

            // DIFFICULTY SELECTION
            Console.WriteLine("Please enter Easy, Normal, or Hard and press enter.\n");
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to STRING by default
            Console.WriteLine("You have selected " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;
            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuesses = 3;
            } else {
                Console.WriteLine("You typed something wrong, so you will automatically be assigned Normal Difficulty.");
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // START THE MATCH
            while(playerScore != 3 && cpuScore != 3) {
                // Any code you want to run BEFORE each round goes here

                // Start each round
                for (int i = 0; i < numAttempts; i++) {
                    // Code to guess number
                    
                }

            }




        }
    }
}
