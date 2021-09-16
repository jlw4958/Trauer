using System;
using System.Collections.Generic;
using System.Text;

/*
 * Program Name: Trauer
 * Date: 10 / 25 / 2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 * Updated 10/25/2020: added animal attributes to the class; created gets and sets for animal attributes
 */

namespace WashingtonJ_HW1
{
    class Animals
    {
        //animal arrays
        string[] RabbitSize = new string[10] { "tiny", "massive", "average", "miniature", "tall", "stout", "large", "long", "short", "puny" };
        int[] AnimalEyes = new int[10] { 0, 18, 2, 6, 9, 3, 23, 4, 7, 5 };
        int[] RabbitTeeth = new int[10] { 3, 8, 5, 4, 37, 96, 15, 12, 0, 43 };
        string[] SquirrelStitches = new string[10] { "very clean", "very gross", "very bloody", "black", "bright red", "sparse", "numerous", "torn", "sickly green", "smelly" };
        int[] SquirrelArms = new int[10] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int[] AnimalLegs = new int[10];

        //gets for animal arrays
        public string[] rabbitSize
        {
            get
            {
                return RabbitSize;
            }
        }
        
        public int[] animalEyes
        {
            get
            {
                return AnimalEyes;
            }

        }

        public int[] rabbitTeeth
        {
            get
            {
                return RabbitTeeth;
            }
        }

        public string[] squirrelStitches
        {
            get
            {
                return SquirrelStitches;
            }
        }

        public int[] squirrelArms
        {
            get
            {
                return SquirrelArms;
            }
        }

        public int[] animalLegs
        {
            get
            {
                return AnimalLegs;
            }
        }

        //rabbit greeting method

        public void AnimalGreeting(int[] nums, int RandomChoice1) 
        {
            //encounter with the animals

            Console.WriteLine("You go to open the door and are stopped by the sudden arrival of some very strange animals.");
            Console.ReadLine();
            Console.WriteLine("One of them is a " + rabbitSize[RandomChoice1] + " rabbit with " + animalEyes[RandomChoice1] + " eyes and " + rabbitTeeth[RandomChoice1] + " teeth." +
                "\nIt also has " + nums[RandomChoice1] + " legs (isn't this a number you chose earlier?)");
            Console.ReadLine();
            Console.WriteLine("The other is a frankenstein-esque squirrel with " + squirrelStitches[RandomChoice1] + " stitches, " + animalEyes[RandomChoice1] + " eyes, and " + squirrelArms[RandomChoice1] + " arms." +
                "\nIt also has " + nums[RandomChoice1] + " legs (this looks like a number from earlier, too)");
            Console.ReadLine();
            Console.WriteLine("Their appearances send chills down your spine. You're not really sure of what to do about them, they're right in front of the doorway.");
        } 

    }
}
