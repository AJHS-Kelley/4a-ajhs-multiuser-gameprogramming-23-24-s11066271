//John Lowney, Operators, v0.04
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string nerd = "nerd";
            string leftSeat = "Xavier";

            int someNumber = 17;
            int kennethBrainCells = 3;

            float lapTime = 84.36F;
            float amarionBraincells = 3.01F;
            
            // Arithmetic Operators
            Console.WriteLine(someNumber + kennethBrainCells);
            Console.WriteLine(nerd + leftSeat);
            Console.WriteLine(lapTime + amarionBraincells);
            Console.WriteLine(kennethBrainCells + amarionBraincells);

            Console.WriteLine(someNumber - kennethBrainCells);
            //Console.WriteLine(nerd - leftSeat); DOES NOT APPLY TO STRINGS
            Console.WriteLine(lapTime - amarionBraincells);
            Console.WriteLine(kennethBrainCells - amarionBraincells);

            Console.WriteLine(someNumber * kennethBrainCells);
            //Console.WriteLine(nerd * leftSeat); DOES NOT APPLY TO STRINGS
            Console.WriteLine(lapTime * amarionBraincells);
            Console.WriteLine(kennethBrainCells * amarionBraincells);

            Console.WriteLine(someNumber / kennethBrainCells);
            //Console.WriteLine(nerd / leftSeat); DOES NOT APPLY TO STRINGS
            Console.WriteLine(lapTime / amarionBraincells);
            Console.WriteLine(kennethBrainCells / amarionBraincells);

            Console.WriteLine("Modulus");
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            // Increment
            kennethBrainCells = 1;
            kennethBrainCells++;
            Console.WriteLine(kennethBrainCells);

            // Decrement
            someNumber =2;
            someNumber--;
            Console.WriteLine(someNumber);

            // Assignment Operators
            lapTime = 2.2F;
            amarionBraincells += 1;
            kennethBrainCells -= 2;
            someNumber *= 9;
            someNumber /= 3;

            // Comparison Operators
            Console.WriteLine(someNumber == 6);
            Console.WriteLine(amarionBraincells > 1);
            Console.WriteLine(kennethBrainCells >= 1);
            Console.WriteLine(kennethBrainCells < amarionBraincells);
            Console.WriteLine(someNumber <= lapTime);
            Console.WriteLine(leftSeat != nerd);

            // Logical Operators
            // And -- All conditions must be true for the statement to be true
            Console.WriteLine(3 > 2 && 2 == 2); // True and True = True
            Console.WriteLine(3 > 2 && 5 > 6); // True and False = False
            // Or -- One condition must be true for the statement to be true
            Console.WriteLine(5 < 9 || 5 != 5); // True or True = True
            Console.WriteLine(9 < 10 || 3 > 5); // True or False = True
            // Not -- Find the 'opposite' value
            Console.WriteLine(!(5 > 4)); //False
        }
    }
}
