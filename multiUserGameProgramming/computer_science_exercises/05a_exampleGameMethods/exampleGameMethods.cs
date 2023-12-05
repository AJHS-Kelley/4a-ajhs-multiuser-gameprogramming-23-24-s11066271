//John Lowney, exampleGameMethods, v1.4
using System;

/*This is a basic game where you attack and defend against a cpu with different weapons and items.
Currently I only have the attack method programmed, but in the future you'll be able to defend against attacks by the cpu.
Each weapon has its own damage multiplier. When you attack, you'll have a randomly generated attack value
that gets multiplied by the damage multiplier. 
If you succesfully defeat an enemy, they will drop a key that will be added to your inventory, which will be used later on.
*/

namespace exampleGameMethods
{
    class exampleGameMethods
    {
        //weaponSelect is used to determine the weapon that the player wants to use.
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
        //the getstats method is used for finding the damage multiplier when attacking. It can also be used to tell the player the stats of a weapon.
        static float getStat(int type, int num) //type is weapons or defenseItems, 1 or 2 respectively. num is the index of the item in its list, starting from 0. 
        { 
            float itemStat = 1.0F;
            //these 2 lists store the multiplier stats for the weapons and defense items.
            float[] weaponStats = {1.67F, 1.8F, 2.0F, 1.0F};
            float[] defenseStats = {0.6F, 0.2F, 0.5F, 0.0F, 1.0F};
            if (type == 1) {
                itemStat = weaponStats[num];
            } else if (type == 2) {
                itemStat = defenseStats[num];
            }
            return itemStat;
        }

        //defenseSelect method is used to determine the defense item the player wants to use.
        //currently this isn't used much, but it will be used in the future.
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
        //this is used to get the player's name.
        //currently it isn't used, but later on when there's a proper ui it will be used. 
        static string getName()
        {
            Console.WriteLine("Please type the name you wish to be called.");
            string playerName = Console.ReadLine();
            return playerName;
        }
        
        //This is the method to attack. The weaponMultiplier parameter would be the damgeMultiplier from the getStats() method.
        //This method takes a random number 1-10 and multiplies it by the damage multiplier of the selected weapon.
        //It returns the amount of damage done to the enemy as a float.
        static float attack(float weaponMultiplier)
        {
            Random rndNum = new Random();
            float damageDealt = rndNum.Next(1, 10);
            damageDealt = damageDealt * weaponMultiplier;
            return damageDealt;
        }

        //This function is used to check if a player has an item in their inventory.
        //The itemName parameter would be the item you're checking for when the method is called. 
        //The damageDealt parameter is to determine whether to add the key to the player inventory.
        //If the player does 10 or more damage, then their enemy is defeated and drops a key.
        //This is set to 0 by default so that the method can be called for items besides the key that don't need damageDealt.
        static bool checkForItem(string itemName, float damageDealt = 0)
        {
            bool trueFalse = false;
            string[] playerInventory = {"Apple", "Reflector", "Med Kit", "", ""};
            if (damageDealt >= 10) {
                playerInventory[4] = "Key";
            }            
            for (int i = 0; i < playerInventory.Length; i++) {
                if (playerInventory[i] == itemName) {
                    trueFalse = true;
                } else {
                    trueFalse = false;
                }
            }
            return trueFalse;
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

            Console.WriteLine("Type 1 or 2 for attack or defense stat");
            int typeInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the number of the item you want to see the stat of.");
            int numInput = Convert.ToInt32(Console.ReadLine());
            float statOutput = getStat(typeInput, numInput);
            Console.WriteLine("This item has a stat value of " + statOutput);

            float attackMultipier = getStat(1, selectedWeapon);
            float damageValue = attack(attackMultipier);
            bool keyStatus = checkForItem("Key", damageValue);
            if (keyStatus == true) {
                Console.WriteLine("You have the key!");
            } else {
                Console.WriteLine("You don't have the key.");
            }
        }
        }  
    }
// code reviewd by TRISTAN MCKAY AKA HIMMOTHY 
