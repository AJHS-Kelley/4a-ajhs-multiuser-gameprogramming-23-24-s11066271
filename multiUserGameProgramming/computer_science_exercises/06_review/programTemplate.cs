//John Lowney, Review, v0.02
using System;

namespace UPDATEFOREACHPROGRAM
{
    class UPDATEFOREACHPROGRAM
    {
        static void Main(string[] args)
        {
            
            // Declaring and Assigning variables
            // Integar -- -2,147,483,648 to 2,147,483,647
            // Integar = 4 Bytes
            int number = 5;

            // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // Long = 8 Bytes 
            long myLong = 4320980979079334;

            // Float -- Stores up to 6-7 decimal digits.
            // Float = 4 Bytes
            float myFloat = 6.4f;

            // Double -- Stores up to 15 decimal digits
            // Double = 8 Bytes
            double firstDouble = 8.340830850824D;

            // Boolean -- true / false
            // Boolean = 1 bit
            bool isTrue = false;

            // String
            // 2 Bytes PER CHARACTER
            // Must be in DOUBLE QUOTES " "
            string word = "Hello";

            // Character (char)
            // Single character, in SINGLE QUOTES ' '
            // 2-bytes
            char myChar = 'C';

            // Type Casting
            // IMPLICIT -- Happens automatically when going smaller -> larger

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            // char -> int -> long -> float -> double
            // EXPLICIT -- Must be done manually when going larger -> smaller
            // double -> float -> long -> int -> char
            double exampleDouble = 9.389324538D;
            int anotherInt = (int) myDouble;

            // Converstion Methods
            Convert.ToString(number) // String
            Convert.ToDouble(myFloat) // Double
            Convert.ToInt32(firstDouble) // Integar
            Convert.ToInt64(myInt) // Long
        }
    }
}
