//John Lowney, Control Flow, v0.05
using System;

namespace controlFlow

{
    class controlFlow
    {
        static void Main(string[] args)
        {
            // DECLARACTIONS
            string favColor = "Green";
            int luckyNumber = 17;
            float myGPA = 4.0F;
            int myAge = 17;
            bool pineappleOnPizza = false;

            // if statememts -- Check for a single condition
            if (favColor == "Green") {
                Console.WriteLine("Green with envy!");
            }
            if (luckyNumber % 2 != 0) {
                Console.WriteLine("Your Lucky Number is odd");
            }

            // if-else statement: Checks for single condition, but has two actions.
            if (myAge > 15) {
                Console.WriteLine("You are eligible to drive");
            } else {
                Console.WriteLine("Start walking, scrub!");
            }

            // if -- else if -- else -- Checks multiple outcomes
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on straight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making honor roll!");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("You are graduation ready!");
            } else {
                Console.WriteLine("You want fries with that?");
            }
            // WHEN CHECKING NUMBER VALUES, START WITH THE HIGHEST VALUE!!!!

            // Nested Statements:
            if (pineappleOnPizza == true) {
                Console.WriteLine("you must be a boomer. How old are you?");
                if (myAge > 60) {
                    Console.WriteLine("Just as I suspected. What was it like growing up with dinosaurs?");
                } else {
                    Console.WriteLine("So you're not a boomer, you just have poor taste.");
                }
            } else {
                Console.WriteLine("Glad to see you have common sense");
            }  

            // for loop -- Best for when you know # of iterations needed.
            /*
                for (statement1; statement2; statement3) {
                    Code to loop.
            }
            statement1 is executed ONCE BEFORE the loop sarts
            statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts.
            statement3 is executed EVERYTIME after the loop executes.           
            

            for (int i = 0; i < 101; i++) {
               Console.WriteLine("" + i);
            }
                
            for (int i = 100; i > -1; i--) {
                Console.WriteLine("" + i);
            }

            // Nested Loop
            // Outer Loop
            for (int i = 1; i <=2; i++) {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++) {
                    Console.WriteLine("Inner: " + j);
                }
            }

            // while loop -- Best uded when # of iterations is unknown
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }

            // Special Keywords
            // break will immediatley exit a LOOP or an IF/ELSE IS/ELSE block.
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50) {
                    break;
                }
            }
            */
            // continue will SKIP the current iteration and then finish the loop
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50) {
                    continue;
                }
            }




        }
    }
}
