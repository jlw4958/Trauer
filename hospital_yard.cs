using System;
using System.Collections.Generic;
using System.Text;


/*
 * Program Name: Trauer
 * Date: 10 / 15 / 2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 * Updated 10 / 15 / 2020: added all code related to the yard; added animal attributes; created attribute arrays;
 * Updated 10/25/2020: removed static keyword from all methods
 * Updated 10/30/2020: removed unnecessary comments
 */

namespace WashingtonJ_HW1
{
    class hospital_yard
    {
        //method for the note on the door
        public void DoorNote(string name)
        {
            Console.WriteLine("\n\nYou walk up to the door and see a note that says: ");
            Console.WriteLine("\n\n" + name.ToUpper() + " DO NOT ENTER. \nDO NOT USE KEY.");
        }

        //method for looking for key/trying to open door
        public bool FrontDoor()
        {
            int PlayerRoll;
            int PlayerRoll1;
            int PlayerRoll2;
            bool ReturnVal = false;

            Console.WriteLine("\n\nOkay player, you need to roll two dice to look for the key. Let's hope you roll a high number.");
            PlayerRoll1 = config.DiceRoll(1, 7); //DiceRoll method
            PlayerRoll2 = config.DiceRoll(1, 7, 10);

            PlayerRoll = PlayerRoll1 + PlayerRoll2;

            Console.ReadLine();
            Console.WriteLine("\n\nIt looks like you rolled a " + PlayerRoll + ".");
            if (PlayerRoll > 4)
            {
                //player lives, continues playing
                ReturnVal = true;
            }
            else if (PlayerRoll <= 4)
            {
                //player dies :( end of game for them
                Console.WriteLine("\nYou go to search for the key, but you have no idea where to look. You scan the area around you and " +
                    "\nnotice a strangely shaped rock sitting slightly away from the path to the hospital. It captures your attention, " +
                    "\nso you slowly move towards it.");
                Console.ReadLine();
                Console.WriteLine("As you pass the scraggly bushes that line the path, you fail to notice the bones resting inside of them." +
                    "\nYou head to the rock and take a brief look at it. It's noticeably smaller than all of the other rocks that are scattered across " +
                    "\nthe path, and slightly less dirty. A slight wind blows through your thin shirt, and a shiver runs down your spine.");
                Console.ReadLine();
                Console.WriteLine("\nYou suddenly notice how ominous the area around you is. Thick trees fill your periphery and a deep fog settles on the area.");
                Console.ReadLine();
                Console.WriteLine("\nA slight bit of fear begins to fill you, but you ignore it and check for the key under the rock. You see two keys, " +
                    "\none modern key and one very old key. 'The hospital looks pretty old to me,' you think. 'So this must be it.' " +
                    "\nYou grab the key, then look to your right. There on the ground, right next to the rock, is a small wooden rectangle. " +
                    "\n'Looks like it might lead to a cellar or a basement.' You look at the key in your hand, then to the hospital " +
                    "\nfar to your left, then look back to the cellar door. 'Maybe this key works here too?' You grab the rusted lock " +
                    "\nhanging off of the small handle and test the key. Sure enough, it works. You pop off the old lock and move to lift the door. " +
                    "\nYou crack it slightly, and your eyes see nothing but darkness. You open the door all the way and get ready to enter. " +
                    "\nAll of a sudden, a large pair of hands emerges from the darkness and grabs you by the neck of your shirt. " +
                    "\nYou begin to scream, but your voice is drowned out by a even larger one. " +
                    "\n\n'YOU AREN'T SUPPOSED TO BE HERE, YOU WEREN'T CHOSEN!' the voice bellows. " +
                    "\n\nYou struggle to escape the hands, but the grip is firm. Suddenly, you're yanked into the darkness. " +
                    "\n\nDarkness fills your mind.");
                ReturnVal = false;
                
            }
            return ReturnVal;
        }//returns a value (bool)

        //method where player encounters animals
        public void FrontDoorChallenge(int[] nums, config End)
        {
            //making object of animals class
            Animals AnimalEncounter = new Animals();
            string AnimalChoice;
            string QuitMessage = "You quit the game";
            string PetDeath = "You died from exposure to mutated rabies";
            string ScratchDeath = "You died from being scratched to death";
            

            //calling DiceRoll method to find random array value
            int RandomChoice1 = config.DiceRoll(0,9);

            //calling greeting mehotd from animals class
            AnimalEncounter.AnimalGreeting(nums, RandomChoice1);
            
           
            Console.WriteLine("\n\nWhat do you want to do? (P)et the animals, (G)ive them nuts, (T)ry to move past them\n\nPress Q to quit");

            AnimalChoice = Console.ReadLine().Trim().ToLower();
            if (AnimalChoice == "p")
            {
                Console.WriteLine("You try to pet the animals. However, they don't appreciate your kindness. As soon as you reach down, the rabbit sinks its mutated teeth into your hand, while the squirrel begins to run up your arm and gnaw on your neck. Both animals have mutated forms of rabies, so your death is instant.");
                End.GameEnd(PetDeath);
            }
            else if (AnimalChoice == "g")
            {
                Console.WriteLine("You look around and find some nuts nearby that fell from a tree. You bring them back and hand them to the animals. The squirrel tentatively takes one from you and runs off, while the rabbit takes three and skitters away. Now you can enter the hospital with no problem.");
            }
            else if (AnimalChoice == "t")
            {
                Console.WriteLine("You try to walk past the animals, but they have other plans. Both animals latch themselves onto your ankles and begin scratching aggressively. You scream in pain as they tear your ankles apart, then work their way up your body. They end at your head, while the rest of you lay bloodied on the ground.");
                End.GameEnd(ScratchDeath);
            }
            else if (AnimalChoice == "q")
            {
                End.GameEnd(QuitMessage);
            }
        }


    }
}
