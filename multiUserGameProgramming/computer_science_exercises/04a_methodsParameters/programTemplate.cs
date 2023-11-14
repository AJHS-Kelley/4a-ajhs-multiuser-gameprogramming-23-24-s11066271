//John Lowney, MethodsParameters, v0.01
// All required examples given. 
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        //Method -- Named block of code, can be used multiple times like a function.
        // All methods have a signature that defines their name, parameters, and output.
        // Example signature
        static void myMethod()
        {
            Console.Writeline("Hello.\n");
        }

        // static -- This method belongs to the current class, it is not an object
        // void -- This method has no return value

        static int DoubleUp()
        {
            int sum = 0;
            Console.Writeline("This method will double a number and return it");
            Console.Writeline("Please enter a number on the next line");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.Writeline(sum);
            return sum;
        }

        // Method with Parameters
        static void MakePancakes(int num)
        {
            for(int i = 0; i < num; i++)
            {
                Console.Writeline("One pancake coming up!");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.Writeline("You have ordered" + num + "eggs" + style + ".\n");
        }


        //Named arguments
        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.Writeline("My favorite child is " + child3);
        }

        //Method Overloading
        // Find sum of int
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.Writeline("Sum: " + sum);
            return sum;
        }

        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes();
            //MakeEggs(10, "Scrambled");
            //MakeBurger(10);
            //AllMyChildren(child3: "Steve", child2: "Susan", child1: "Chewbacca");
            FindSum(1, 5); // two integers
            FindSum(9.5, 2.4); // two doubles
            FindSum(5, 2.5); // one of each
        }
    }
}
