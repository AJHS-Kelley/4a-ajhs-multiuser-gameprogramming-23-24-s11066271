//made this to test another game idea without deleting the main one
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        string[] weapons = {"Sword", "Axe", "Blunderbuss", "Fist"};
        string[] defenseItems = {"Normal Shield", "Percision Shield", "Magic Circle", "Arm"};
        static void attack()
        {
            Console.WriteLine("Please Select a Weapon.\n Type '1' for Sword, '2' for Axe, '3' for Blunderbuss, or '4' for Fist. \n Type '0 to view stats.");
            
            int i = 0;
            while (i == 0) {
                int selectedWeapon = Convert.ToInt32(Console.ReadLine());
                if (selectedWeapon == 1) {
                    Console.WriteLine("You selected the Sword!");
                    i++;
                } else if (selectedWeapon == 2) {
                    Console.WriteLine("You selected the Axe!");
                    i++;
                } else if (selectedWeapon == 3) {
                    Console.WriteLine("You selected the Blunderbuss!");
                    i++;
                } else if (selectedWeapon == 4) {
                    Console.WriteLine("You selected your Fist!");
                    i++;
                } else if (selectedWeapon == 0) {
                    Console.WriteLine("Weapon | Damage | Accuracy\n Sword | 6 | 8\n Axe | 8 | 6\n Blunderbuss | 10 | 3");
                } else {
                    Console.WriteLine("Pick one of those numbers, fool");
                }
            }
        }    
        static void shootBall()
        {
            
        }

        static void coinFlip() 
        {
        
        }

        static void passBall()
        {
            
        }
        static void Main(string[] args)
        {
            attack();
        }
        }  
    }
