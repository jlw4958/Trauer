/*
Program Name: Trauer
Date: 09/03/2020
Creator: Jabrecia Washington
Updated By: Jabrecia Washington
Description: creation of a text based suspense/mystery game modeled after Zork :)
Updated 09/04/2020: walkthrough of game; code created for intro and first steps through game
Updated 09/16/2020: Finally fixed the header :'); made TOTAL_STEPS constant
Updated 09/25/2020: put rolling dice code in its own method; created all methods
Updated 10/01/2020: fix building walkthrough; add search for basement; fixed search for basement
Updated 10/02/2020: fixing basement method + challenges; finished basement search, boss battle, and end game
                    + started HW3; working on loops; completed loop for steps to door
Updated 10/15/2020: moved code to classes; fixed main to run properly
Updated 10/25/2020: removed static keyword from all methods; made object references for all classes + passed in as parameters as necessary
Updated 10/30/2020: removed unnecessary comments
*/

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace WashingtonJ_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object references
            //player chosen food list
            config Important = new config();
            hospital_yard Yard = new hospital_yard();
            hospital_building Building = new hospital_building();
            basement_dungeon Dungeon = new basement_dungeon();


            //attributes
            // - getting player name + checking for valid input
            string PlayerName;
            string YorN;
            bool check;
            bool NameFull = false;
            bool AnswerCheck = false;

            //array for player number input
            int[] ChosenNumbers;

            //- steps to the door
            const int TOTAL_STEPS = 50;
            string NumOfSteps;
            int StepsTaken = 0;
            bool isNumeric;
            int i = 0;

            // - seeing if player advances past the door
            bool TorF;

            //- death after front door die roll
            string KeyDeath = "You were dragged into the darkness";


            // - looking through building
            string ChosenRoom;
            string PlayerChoose;

            // - moving through basement/dungeon + end of game
            bool BaseVar = false;
            string FightChoice;
            string EndChoice;
            

            //welcome message
            Console.WriteLine("Welcome to Trauer");
            Console.WriteLine("\n* * * * * *");


            //Prompting player for name
            do
            {
                Console.Write("\nHello, user, welcome to the game. Please enter your name: ");
                PlayerName = Console.ReadLine().Trim().ToLower().Substring(0);
                if (check = string.IsNullOrEmpty(PlayerName))
                {
                    NameFull = false;
                    Console.WriteLine("Please enter a name: ");
                }
                else
                {
                    NameFull = true;
                    continue;
                }
                //check = string.IsNullOrEmpty(PlayerName);

            }
            while (NameFull == false);

            //fill in user info (name, eye color, height, etc)
            Console.WriteLine("Nice to meet you " + PlayerName + ". Enjoy the game.");

            Console.WriteLine("\n_________________________________________________");


            //changing color for gettig user input
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;

            //calling GetInfo method from config class
            ChosenNumbers = config.GetInfo();

            //calling UserFoodInput to put into 
            List<string> UserFoods = Important.UserFoodInput();

            //pretty things to make it spicy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;


            //set up story
            Console.WriteLine("\nTrauer is an interactive text-based mystery thriller.\nThroughout the game, you will be asked to make " +
                "decisions that will determine your progress in the game.\nWhat happens to and because of you is entirely your decision." +
                "\nAll you need to play is your keyboard.");
            

            //checking user input (yes or no)

            do
            {
                Console.Write("Are you ready? (Y/N) ");
                YorN = Console.ReadLine().Trim().ToLower().Substring(0);

                if (check = string.IsNullOrEmpty(YorN))
                {
                    AnswerCheck = false;
                    Console.WriteLine("Please enter a valid answer.\n");
                }
                else if (YorN == "y")
                {
                    AnswerCheck = true;
                    continue;
                }
                else if (YorN == "n")
                {
                    AnswerCheck = true;
                    Console.WriteLine("See you next time, " + PlayerName);
                    System.Environment.Exit(0);
                }
            }
            while (AnswerCheck == false);

            //changing colors again for font + bg
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("\n* * * * * *\n");


            //commentary to start the game
            Console.WriteLine("It's the day before your new job at a new hospital.");
            Console.WriteLine("\nThe hospital is very small and located in what feels like the middle of nowhere, but you feel like any start is good\nenough for you. As you bike up" +
                " the dirt path, you can't help but feel the ominous vibe\nfrom the thick forest that surrounds you. You bike a bit further and" +
                " finally see the front of the \nhospital. It's small slightly rundown, and almost entirely made of wood.");
            Console.WriteLine("\n\nThe gray sky only further accentuates it's dreary exterior.");
            Console.ReadLine();
            Console.WriteLine("\n\n'I knew it was kind of old,' you think to yourself. 'But I never expected to see a glorified shed.'");
            Console.ReadLine();
            Console.WriteLine("\n\nYou continue to bike up the path towards the hospital.");
            Console.ReadLine();
                 
            
            //loop for steps to door
            do
            {
                Console.Write("\n\nHow many steps forward do you want to take? (please insert a number): ");
                NumOfSteps = Console.ReadLine();
                isNumeric = int.TryParse(NumOfSteps, out i);

                if (isNumeric == false)
                {
                    Console.WriteLine("\n\nYou entered an invalid value.");
                }
                else
                {
                    StepsTaken = StepsTaken + i;

                    Console.WriteLine("You moved: " + i + " steps.");
                    Console.WriteLine("You've moved " + StepsTaken + " total steps.");
                }
                
                if (StepsTaken < TOTAL_STEPS)
                {
                    Console.WriteLine("You didn't get all of the way to the door, so you keep walking.");
                }
                else if (StepsTaken >= TOTAL_STEPS)
                {
                    Console.WriteLine("You walked the rest of the way up the path, and now you're right in front of the door.");
                }

            }
            while (StepsTaken < TOTAL_STEPS);

            //calling DoorNote method from hospital_yard class
            Yard.DoorNote(PlayerName);

            //calling FrontDoor method and FrontDoorChallenge
            TorF = Yard.FrontDoor();

            if (TorF == false)
            {
                Important.GameEnd(KeyDeath);

            }
            else if (TorF == true)
            {
                Yard.FrontDoorChallenge(ChosenNumbers, Important);
            }

            //story introducing hospital
            Console.WriteLine("Now that you're inside the hospital, you feel like you should look around. You have no clue where to start though, despite the fact that the hospital is barely larger than a cottage.\n\nYou see six different rooms, three on each side of you. Guess it's time to start exploring.\n\nYou try to ignore the putrid smell.");
            Console.ReadLine();


            //asking user what room they want to go to
            Console.WriteLine("\n\nWhich room would you like to explore?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2\nPress Q to quit");


            
            //exploring the hospital
            ChosenRoom = Console.ReadLine().ToLower().Trim();
            if (ChosenRoom == "b")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();


            }
            else if (ChosenRoom == "p")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();
            }
            else if (ChosenRoom == "r")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();
            }
            else if (ChosenRoom == "c")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();
            }
            else if (ChosenRoom == "o")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();
            }
            else if (ChosenRoom == "e")
            {
                //calling method for each room
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();

                Building.BldgRooms(ChosenRoom, UserFoods, Important);
                Console.WriteLine("Which room would you like to explore first?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2");
                ChosenRoom = Console.ReadLine();
            }
            else if (ChosenRoom == "q")
            {
                Building.BldgRooms(ChosenRoom, UserFoods, Important);
            }

            //prompt to go through the rooms again to find the basement
            Console.WriteLine("\n\nYou've visited every room in the building now, but you feel like there's something more hidden here, so you decide to search through them all again.");
            Console.ReadLine();

            //prompting user to choose rooms again (in order to find basement)
            Console.WriteLine("\n\nWhich room would you like to explore?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2\nPress Q to quit");
            ChosenRoom = Console.ReadLine().ToLower().Trim();

            //loop for going through rooms 2nd time and finding basement
            do
            {
                if (ChosenRoom == "p")
                {
                    Building.FindTheBasement(ChosenRoom, Important);
                    BaseVar = true;
                }
                else
                {
                    Building.FindTheBasement(ChosenRoom, Important);
                    Console.WriteLine("\n\nWhich room would you like to explore?" +
                "\n(B)reak Room, (P)resident's Office, First Checkup (R)oom, Second (C)heckup Room, (O)perating Room 1, Op(E)rating Room 2\nPress Q to quit");
                    ChosenRoom = Console.ReadLine().ToLower().Trim();
                }
            }
            while (BaseVar == false);

            //entering the basement
            Console.WriteLine("\n\nWhen you enter the basement, the first thing you notice is how large it is. It feels almost bigger than the hospital itself. The room itself is one straight shot towards the back, where you see a dark and rusted door. However, as you look around, you can see the various 'sections' of the room, where there are two large monitors, massive bookshelves, tables covered in all kinds of medical equipment, and rows of hospital beds.");


            //calling method for the basement + challenges
            Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
            PlayerChoose = Console.ReadLine().ToLower().Trim();
            if (PlayerChoose == "b")
            {
                //calling method for each room
                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);

            }
            else if (PlayerChoose == "s")
            {
                //calling method for each room
                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
            }
            else if (PlayerChoose == "c")
            {
                //calling method for each room
                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
            }
            else if (PlayerChoose == "t")
            {
                //calling method for each room
                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
                Console.WriteLine("\n\nWhat part of the basement do you want to explore?" +
                "\n (B)eds, (S)helves, (C)omputers, (T)ables\n\nPress Q to quit");
                PlayerChoose = Console.ReadLine().ToLower().Trim();

                Dungeon.BasementRooms(PlayerChoose, Important);
            }
            else if (PlayerChoose == "q")
            {
                //quit game
                Dungeon.BasementRooms(PlayerChoose, Important);
            }

            //leading up to the boss battle
            Console.WriteLine("\n\nYou've collected the key card and the passcode that you need to enter the back door. Hesitantly you swipe the card and " +
                "enter the code. You noticed that the code looks a lot like one of the dates in the articles you saw. It was the first recorded patient death" +
                " at the hands of the head doctor. Your hands shake as you open the door and see a narrow but long room. It's dark save for a single dim lamp," +
                " and it smells ten times worse here than it does in the rest of the hospital. You try to peer into the light and you can make out a hospital" +
                " bed and a dark figure shuffling around. You move closer and realize the dark figure is none other than the head doctor, though he has aged " +
                "considerable since the picture in the articles were taken. He slowly turns to face you and his face visibly pales. You look towards the hospital bed and see a small girl laying there. The heart monitor says she's alive, but you aren't sure for how much longer. You're determined to save her somehow, but first you need to get her away from the doctor." +
                "\n\n'WHAT ARE YOU DOING HERE? YOU AREN'T SUPPOSED TO BE HERE!' he bellows. You shake with fear, but you find your resolve and face him head" +
                " on. 'What are YOU doing here? Why are you killing all of your patients?' He laughs dryly and stares you down. 'Killing them? No, I'm " +
                "//saving// them.' He grabs a large picture of a woman's mangled body and waves it aggressively. 'This woman is my mother! I've been" +
                " trying to save her since August of '97! If I can save all of these people, I can save her too! It was all an accident! I have to atone by " +
                "bringing her back! A few casualties should be expected! AND I WON'T LET YOU STOP ME!");

            Console.ReadLine();
            Console.WriteLine("He grabs a mysterious black jar. You aren't sure what's inside of it, but you sure are afraid of what it may be.");
            FightChoice = "b";
            Dungeon.FinalBoss(FightChoice, Important);

            Console.WriteLine("He brandishes a very large knife that's covered in blood and goes to lunge at you." +
                "\nWhich way do you dodge? (L)eft, (R)ight\n\nPress Q to quit");
            FightChoice = Console.ReadLine().ToLower().Trim();

            //calling final boss method
            Dungeon.FinalBoss(FightChoice, Important);

            //leading up to very end
            Console.WriteLine("\n\nYou take the girl and look for a way out in the dark. You hold the girl on your back as you feel around for a door, until you find a lock. You fish the key out of your pocket frantically and try to force it into the lock. Your hands are shaking, but you manage to get the key into the lock and you see a large staircase. You steel yourself and ascend." +
                "\nWhen you reach the top, you see a small door above your head. You open it and find yourself outside, exiting the same door you found the key next to. It's hard, but you manage to lift yourself out with the unconcious girl on your back. You grab the other key that was under the rock and lock the door. Heaving, you contemplate what to do next.");
            Console.WriteLine("\n\nWill you call the (A)uthorities or set the hospital on (F)ire?\n\nPress Q to quit");
            EndChoice = Console.ReadLine().Trim().ToLower();

            //call end game method
            Dungeon.EndGame(EndChoice, Important);
            
        }
        
    }
}

        
    
