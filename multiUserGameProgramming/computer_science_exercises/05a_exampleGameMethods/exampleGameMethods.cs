//John Lowney, exampleGameMethods, v1.1
using System;

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        static int weaponSelect(int num)
        {            
                if (num == 1) {
                    Console.WriteLine("You selected the Sword!");
                } else if (num == 2) {
                    Console.WriteLine("You selected the Axe!");
                } else if (num == 3) {
                    Console.WriteLine("You selected the Blunderbuss!");
                } else if (num == 4) {
                    Console.WriteLine("You selected your Fist!");
                } else {
                    Console.WriteLine("You picked something not on the list. Now you have to use your fists");
                    num = 4;
                }
            return num;
        }    
        static float getStat(int type, int num) //type is weapons or defenseItems, 1 or 2 respectively. num is the index of the item in its list, starting from 0. 
        { //i think theres about 10 different easier ways to do this, but it works.
            float itemStat = 1.0F;
            float[] weaponStats = {1.67F, 1.8F, 2.0F, 1.0F};
            float[] defenseStats = {0.6F, 0.2F, 0.5F, 0.0F, 1.0F};
            if (type == 1) {
                itemStat = weaponStats[num];
            } else if (type == 2) {
                itemStat = defenseStats[num];
            }
            return itemStat;
        }

        static int defenseSelect(int num)
        {            
                if (num == 1) {
                    Console.WriteLine("You selected the Shield!");
                } else if (num == 2) {
                    Console.WriteLine("You selected the Percision Shield!");
                } else if (num == 3) {
                    Console.WriteLine("You selected the Magic Spell!");
                } else if (num == 4) {
                    Console.WriteLine("You selected to dodge!");
                } else if (num == 5) {
                    Console.WriteLine("You selected Your Arm");
                } else {
                    Console.WriteLine("You picked something not on the list. Now you have to use your arm");
                    num = 5;
                }
            return num;
        }    
        static string getName()
        {
            Console.WriteLine("Please type the name you wish to be called.");
            string playerName = Console.ReadLine();
            return playerName;
        }

        static void checkForWinner(int currentPlayerHealth = 100, int currentEnemyHealth = 100)
        {
            if (currentPlayerHealth == 0 && currentEnemyHealth > 0) {
                Console.WriteLine("Game Over: You Lose")
            } else if (currentEnemyHealth == 0 && currentPlayerHealth > 0)
                Console.WriteLine("Game Over: You Win!")
        }
        static void Main(string[] args)
        {
            getName();

            Console.WriteLine("Please Select a Weapon.\n Type '1' for Sword, '2' for Axe, '3' for Blunderbuss, or '4' for Fist."); 
            int selectedWeapon = Convert.ToInt32(Console.ReadLine());
            weaponSelect(selectedWeapon);

            Console.WriteLine("Please Select a Defense Item.\n Type '1' for Shield, '2' for Percision Shield, '3' for Magic Spell, '4' to dodge, or '5' for your arm."); 
            int selectedDefense = Convert.ToInt32(Console.ReadLine());
            defenseSelect(selectedDefense);

            Console.WriteLine("Type 1 or 2 for attack or defense stat")
            int typeInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the number of the item you want from before to see its stat")
            int numInput = Convert.ToInt32(Console.ReadLine());
            int statOutput = getStat(typeInput, numInput);
            Console.WriteLine(statOutput);
  

        }
        }  
    }
