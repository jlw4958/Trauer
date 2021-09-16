using System;
using System.Collections.Generic;
using System.Text;

/*
 * Program Name: Trauer
 * Date: 10 / 05 / 2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 * Updated 10 / 15 / 2020: addition of diceroll methods
 * Updated 10/25/2020: removed static keyword from all methods;
 */

namespace WashingtonJ_HW1
{
    class config
    {
        //the two dice methods
        public static int DiceRoll(int sideone, int sidetwo)
        {
            Random randomNum = new Random();
            int Die1 = randomNum.Next(1,7);
          

            return Die1;
        }

        public static int DiceRoll(int sideone, int sidetwo, int sidethree)
        {
            Random randomNum = new Random();
            int Die1 = randomNum.Next(1,7);
            Die1 = Die1 * 2 / 2;

            return Die1;
        }

        //getting player information (numbers)
        public static int[] GetInfo()
        {
            //variable for player input
            string PlayerChoice;
            //bool for verifying player input
            bool isNumeric;
            //int for converted player input
            int PlayerNum;
            //int for assigning player input to the array indexes
            int j = 0; //starts at index 0, will increase to 9

            //informing user of need for input
            Console.WriteLine("Before we start the game, we're going to need some information from you in order to personalize the experience.");
            Console.ReadLine();

            //make number array
            int[] PlayerNumbers = new int[10];
            //variable for number count
            int i = 1;//will increase to 10, only increases if player enters valid input

            //ask for user input
            //readline + trim
            /* do while loop
             *      while length of array != 10
             *      check if input is a number
             *      if not, prompt again
             *      is yes, add to array and add 1 to i
             *          - i is the choice that they are on
             */

            do
            {
                Console.WriteLine("\nPlease enter a number between 10 & 100 (" + i + " of 10): ");
                PlayerChoice = Console.ReadLine().Trim();
                isNumeric = int.TryParse(PlayerChoice, out PlayerNum);

                if (isNumeric == false)
                {
                    Console.WriteLine("Please enter a valid integer\n");
                }
                else if((PlayerNum < 10) || (PlayerNum > 100))
                {
                    Console.WriteLine("Your entry is out of range, please enter a valid number\n");
                }
                else
                {
                    PlayerNumbers[j] = PlayerNum;
                    j += 1;
                    i += 1;
                }
                
            }
            while (i < (PlayerNumbers.Length + 1));

            Console.WriteLine("You entered the following numbers: \n");
            foreach(int num in PlayerNumbers)
            {
                Console.WriteLine(num);
            }

            //Console.WriteLine(chosenfood);

            return PlayerNumbers;
        }

        //getting player information (foods)
        public List<string> UserFoodInput()
        {
            //number for counting food names added
            int k = 1;
            //string with player input
            string FoodName;
            string FoodName2;
            //list to add values to
            List<string> PlayerChosenFoods = new List<string>();
            //string for player yes or no to add more food to list
            string PlayerYorN;

            //informing user of need for input
            Console.WriteLine("We'll need some more information from you. This time, we'll ask you to list some foods you enjoy.");
            Console.ReadLine();

            //ask for food names + add to list
            do
            {
                Console.WriteLine("Please enter a food name (" + k + " of 3): ");
                FoodName = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrEmpty(FoodName))
                {
                    Console.WriteLine("Please enter a food name\n");
                }
                else
                {
                    PlayerChosenFoods.Add(FoodName);
                    k += 1;
                }
            }
            while (k < 4);

            //loop three times
            //add food names to list
            //exit loop
            /*while answer != n, 
             *      ask if they want to add more foods
             *      ask for another food
             *      repeat
            */
            //asking if user wants to add another food
            do
            {
                Console.WriteLine("Do you want to add another food (Y or N)? ");
                PlayerYorN = Console.ReadLine().Trim().ToLower();
                if ((PlayerYorN != "y") && (PlayerYorN != "n"))
                {
                    Console.WriteLine("Please answer y or n");
                }
            }
            while ((PlayerYorN != "y") && (PlayerYorN != "n"));
            
            //adding more foods to list
            while (PlayerYorN != "n")
            {

                Console.WriteLine("Please enter a food name : ");
                FoodName2 = Console.ReadLine().Trim().ToLower();
                if (string.IsNullOrEmpty(FoodName2))
                {
                    Console.WriteLine("Please enter a valid food name\n");
                }
                else
                {
                    PlayerChosenFoods.Add(FoodName2);
                    Console.WriteLine("\nDo you want to add another food (Y or N)? ");
                    PlayerYorN = Console.ReadLine().Trim().ToLower();
                }
            }
            

            Console.WriteLine("You chose the following foods: \n");
            foreach (string food in PlayerChosenFoods)
            {
                Console.WriteLine(food);
            }

            return PlayerChosenFoods;
        }

        //method for ending the game
        public void GameEnd(string reason)
        {
            Console.WriteLine(reason);
            System.Environment.Exit(0);
        }

    }
}
