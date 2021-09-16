using System;
using System.Collections.Generic;
using System.Text;


/*
 * Program Name: Trauer
 * Date: 10 / 15 / 2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 * Updated 10 / 15 / 2020: added all building related code
 * Updated 10/25/2020: removed static keyword from all methods;
 */

namespace WashingtonJ_HW1
{
    class hospital_building
    {
        //method for the first run through the hospital building
        public void BldgRooms(string userChoice, List<string>userfood, config End)
        {
            //Your switch statements and code go here describing the rooms.
            //ask for user input to choose which room in main (the rest of these happen in main too)
            //trim and make lower
            //make sure it's a valid input
            //set a default in case they enter something invalid

            //these go here lolol
            //make a switch statement to go through each room (6)
            //brief descriptions, they can't touch anything in there yet
            //give them the option to switch through each one by calling the method five times per room in main
            string QuitMessage = "You quit the game";
            Random RandomChoice = new Random();
            int ListLength = userfood.Count;
            int RandomFood = RandomChoice.Next(0, ListLength);

            switch (userChoice)
            {
                case "b":
                    //describe the break room
                    Console.WriteLine("You walk into the break room." +
                        "\n As expected, it's very small and very old. " +
                        "\nYou see a beat up folding table, an old refrigerator " +
                        "\n(that you'll definitely make sure not to use), and a couple of old cabinets. " +
                        "\nYou know you must be imagining it, but you feel like the fog from outside is " +
                        "\nsitting in this room, as well. The single window on the wall is very small and " +
                        "\nshows only the dark bodies of the trees in the near distance." +
                        "\nYou turn and see old and moldy " + userfood[RandomFood] + " sitting on the table." +
                        "\nAnother shiver runs down your spine.");
                    break;
                case "p":
                    //describe the president's office
                    Console.WriteLine("Upon entering the president's office, the first thing you notice is the " +
                        "\ngigantic desk that seems awfully big for the small room it's in. " +
                        "\nThis room has only one small window, but some small candles on the " +
                        "\ndesk keep the room relatively well lit. There are massive bookshelves that " +
                        "\nseem to make the room seem even smaller than it already is. When you take a " +
                        "\ncloser look, you notice that instead of medical journals, which you expected, " +
                        "\nthere are tons and tons of photo albums. You open one and see gruesome images of what" +
                        "\n looks like skin graft surgery. You clos the album and keep looking around the room. " +
                        "\nAll that's left is a coat rack holding a single hat. The hospital is supposed to be closed." +
                        "\n A feeling of fear seeps deep into your bones.");
                    break;
                case "r":
                    //describe the first checkup room
                    Console.WriteLine("When you walk into the checkup room, you see a single " +
                        "\nbed and various types of medical equipment on the walls. An IV drips next to the bed, " +
                        "\nbut it isn't hooked to anything. A small puddle has formed on the floor. There are no windows, " +
                        "\nonly pasty white walls and obvious signs of water damage. The IV continues to drip. Something feels off.");
                    break;
                case "c":
                    //describe the second checkup room
                    Console.WriteLine("You walk into the other checkup room. As expected, " +
                        "\nyou see a bed and various kinds of medical equipment. There is a small table next" +
                        "\n to the bed with equipment for sutures. Bloody bandages sit next to the needle. " +
                        "\nYou scan the walls and notice a small dirty window that shows a small sliver of the still foggy sky. " +
                        "\nThe dirt on the window only seems to increase. You look back at the bloody bandages. You wonder whose blood it may be.");
                    break;
                case "o":
                    //describe the operating room
                    Console.WriteLine("The operating room looks about as you expected it to. " +
                        "\nA small operating table in the center, with two lamps casting dim light onto it. " +
                        "\nThe table looks as if there has been someone in it recently. You remember that the " +
                        "\nhospital has been closed for a few weeks. Dismissing the thought, you continue to look around. " +
                        "\nSmall tables covered in scalpels and suture equipment line the sides of the bed, and a small " +
                        "\nwashing area lies behind a thin plastic sheet hung from the ceiling. You turn to walk out and notice " +
                        "\nthat there is a bit of blood on the scalpels. You feel a slight chill.");
                    break;
                case "e":
                    //describe the second operating room
                    Console.WriteLine("The other operating room is missing the operating table, " +
                        "\n the lamps have nothing to cast their light onto. One of the lamps has a " +
                        "\nbroken lightbulb, so it flickers uncomfortably. Tons of medical equipment fills the room. " +
                        "\nYou look closely at some of the scalpels and notice some old blood. Has no one cleaned it " +
                        "\nsince they had to close? You notice a lone hospital gown lying in the corner. " +
                        "\nSomething doesn't feel right about this.");
                    break;
                case "q":
                    End.GameEnd(QuitMessage);
                    break;

            }
        }

        //method for searching for the basement
        public void FindTheBasement(string chooseRoom, config End)
        {
            string QuitMessage = "You quit the game";

            switch (chooseRoom)
            {
                case "b":
                    //describe the break room
                    Console.WriteLine("\n\nYou reenter the breakroom. You decide to open the refrigerator despite the fact that its disgusting appearance makes your stomach churn. You tentatively grasp the slightly sticky handle and pull the door open, sending a putrid smell your way. Jars of various organs and body parts fill the small fridge, ranging from eyeballs to chunks of brain and fingers. You close the fridge in disgust, unable to control the shivers running through your body.");
                    break;
                case "p":
                    //describe the president's office
                    Console.WriteLine("\n\nYou reenter the president's office. There's got to be some way to get to the basement from here. You search behind the bookshelves, freeing hidden spiders and dust bunnies. You move the various photo albums, dropping some and exposing the gruesome images inside of them. You poke and prod through the dim room until you think to look under the desk. It's dark, of course, but you can see enough to spot the massive cobwebs beneath. Under all of the cobwebs, you spot a small door handle. You give it a light tug and it gives way to a dark corridor.");
                    break;
                case "r":
                    //describe the first checkup room
                    Console.WriteLine("\n\nYou reenter the first checkup room. You decide to open the large medical cabinet and are horrified when a corpse falls towards you. You scream and jump out of the way of the falling body. That's enough to deter you, so you quickly leave the room.");
                    break;
                case "c":
                    //describe the second checkup room
                    Console.WriteLine("\n\nYou reenter the second checkup room. Bugs have begun to crawl and squirm over the bloodied bandages. You spot a few maggots, as well. You hold back the gag rising in your throat and decide to search for a way to reach a basement. You peek under the bed for a potential hidden door, but instead you're met with a rotting corpse and a few bones covered in maggots. You quickly jump up and run from the room.");
                    break;
                case "o":
                    //describe the operating room
                    Console.WriteLine("You reenter the first operating room. You head straight for the bed behind the plastic sheet. There, on the bed, you find a body. You assume it's dead, but then you notice a slight tremble. You see that its vital signs are being displayed on a screen, but you can see there's no pulse. How is this body moving, you think to yourself. You feel another chill, so you quickly leave the room.");
                    break;
                case "e":
                    //describe the second operating room
                    Console.WriteLine("You reenter the second operating room. You head straight for the hospital gown in the corner. It may be there to cover a secret entrance, you think. You grab it, then stop as soon as your hand reaches the material. There's something solid underneath, and you're afraid of what it might be. Slowly, you lift the gown, only to see the small silhouette of a woman's dead body. It must have been there for a while, you think, since it's mostly bone at this point. You replace the gown and walk out of the room. This hospital doesn't seem like a place you want to be.");
                    break;
                case "q":
                    End.GameEnd(QuitMessage);
                    break;

            }
        }

    }
}
