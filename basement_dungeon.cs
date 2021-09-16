using System;
using System.Collections.Generic;
using System.Text;


/*
 * Program Name: Trauer
 * Date: 10 / 15 / 2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 * Updated 10 / 15 / 2020: added all baesment/dungeon related code
 * Updated 10/25/2020: removed static keyword from all methods;
 */

namespace WashingtonJ_HW1
{
    class basement_dungeon
    {
        //method for the basement
        public void BasementRooms(string roomChoice, config End)
        {            
            string RowChoice;
            string BookChoice;
            string TableChoice;
            string CompChoice;
            string QuitMessage = "You quit the game";
            string ChemicalDeath = "You died from chemical exposure";
            string RicinDeath = "You died from Ricin poisoning";
            string DartDeath = "You died by a poison dart";
            string GasDeath = "You died by exposure to poisonous gas";
            string DeadDeath = "You died by high-speed necrosis";
            //make switch statements that describe each area in the basement

            switch (roomChoice)
            {
                case "b":
                    Console.WriteLine("There are three rows of hospital beds, each containing six beds. Some of them look flat and empty, while others have human sized mounds hidden under white sheets. You walk over to the beds and scan them over. Your curiosity turns your head to the door at the back of the large room. 'If only I could get in there' you think to yourself. You look down and notice a small scrap of paper sitting under one of the beds. You reach down and read the messy handwriting:\n\nTHE KEY, IT'S UNDER ONE OF THESE BEDS, REMEMBER TO FIND THE KEY\n\nYou make it your mission to find the key, since it must be the key to the door in the back.\n\nWhich row should you start searching?");
                    Console.WriteLine("\nRow (1), Row (2), Row (3)\nPress Q to quit");
                    RowChoice = Console.ReadLine().ToLower().Trim();
                    if (RowChoice == "1")
                    {
                        //ends in player death
                        //death by exposure to weird chemical + necrosis
                        Console.WriteLine("You head to first row of beds. Some of the beds have mounds under the sheets that you presume are human bodies. Given what you've seen here thus far, it wouldn't be very surprising. However, the note said there would be a key around here, so you suspect it's under some of these sheets. 'Maybe it's hidden with one of the bodies?' you think to yourself. You head to the nearest mound and lift up the sheet, only to be exposed to the most foul smelling pile of //something// that you've ever seen. Youo can't tell if it's human or not, but what you can tell is that it's getting harder to breathe. Your mind is going foggy and your vision is blurring? What happened? Is there some dangerous chemical lacing these bodies? You can't stick around to figure out, because your mind goes dark soon after.");
                        End.GameEnd(ChemicalDeath);
                    }
                    else if (RowChoice == "2")
                    {
                        //advances to next section of the room
                        //finds key in a dead hand
                        Console.WriteLine("You head to the second row of beds. Most of them are flat and seemingly empty, but the bed directly in the center catches your attention. The sheet is slightly raised in several different places, so you assume there's no body there, at least not a whole one. You head to the bed and cautiously lift the sheet. There, you see several severely decayed hands, one of which is holding a small key. You gag but remove the key from the hand's grasp, then quickly replace the sheet.");

                    }
                    else if (RowChoice == "3")
                    {
                        //ends in player death
                        //death by inhaling gas from bodies (lifts up sheets)
                        Console.WriteLine("You head to third row of beds. Some of the beds have mounds under the sheets that you presume are human bodies. Given what you've seen here thus far, it wouldn't be very surprising. However, the note said there would be a key around here, so you suspect it's under some of these sheets. 'Maybe it's hidden with one of the bodies?' you think to yourself. You head to the nearest mound and lift up the sheet, only to be exposed to the most foul smelling pile of //something// that you've ever seen. Youo can't tell if it's human or not, but what you can tell is that it's getting harder to breathe. Your mind is going foggy and your vision is blurring? What happened? Is there some dangerous chemical lacing these bodies? You can't stick around to figure out, because your mind goes dark soon after.");
                        End.GameEnd(ChemicalDeath);

                    }
                    else if (RowChoice == "q")
                    {
                        //end game
                        End.GameEnd(QuitMessage);
                    }
                    break;
                case "s":
                    Console.WriteLine("You head to the large bookshelves that cover the entire left wall of the basement. You think there may be a way to get into the back door hidden in these shelves, so you decide to take a look. As you scan the large shelves, three bright red books capture your attention. They sit right next to each other and are the only differently colored books in the sea of black. You think there may be some secret hidden here, but which book should you open?");
                    Console.WriteLine("\nWhich book do you choose? (L)eft book, (M)iddle book, (R)ight book\n\nPress Q to quit");
                    BookChoice = Console.ReadLine().Trim().ToLower();
                    if (BookChoice == "l")
                    {
                        //advances to next section of the room
                        //finds a sticky note/slip of paper in book with door passcode
                        Console.WriteLine("You grab the book on the left. It's very heavy, and extremely large, so large it barely fits in your hands. It looks like an annotated medical journal, one that hasn't been touched in years. You begin to flip through the pages and are shocked when a small slip of paper falls out and lands on your left foot. You replace the book and stoop down to grab the paper. It has the numbers 081297 written on it. This may be important later, so you pocket it for now.");
                    }
                    else if (BookChoice == "m")
                    {
                        //ends in player death
                        //inhales that poison dust stuff? (look it up) update: ricin
                        Console.WriteLine("You open the middle book. It feels extremely heavy, but you begin to flip through its pages anyway. It looks dustier than the other two, but you ignore that, until you notice that it's hard to breathe. Your chest tightens and tightens until you're on the floor, the book landing on your now still body.");
                        End.GameEnd(RicinDeath);
                    }
                    else if (BookChoice == "r")
                    {
                        //ends in player death
                        //shoots out poison dart
                        Console.WriteLine("You grab the book on the right. It's extremely heavy, so you sit down to open it. You begin flipping through its pages in search of a clue, but then you are stopped shot when a hole appears in between a few pages. You peer into the hole, but you aren't prepared for the arrow that shoots itself out and lands directly between your eyes. You also aren't prepared for the deadly poison the arrow is coated in.");
                        End.GameEnd(DartDeath);
                    }
                    else if (BookChoice == "q")
                    {
                        //end game
                        End.GameEnd(QuitMessage);
                    }
                    break;
                case "c":
                    //shows history of the hospital
                    Console.WriteLine("You face the direction you entered from and look at the two large monitors flanking either side of the dark staircase. Both screens practically swallow the wall beneath them. One screen displays various pictures of body diagrams and other anatomical images. The other displays large walls of text, along with a few pages of scanned in notes. You feel like these computers may have some important information about the hospital on them, but you aren't sure which one to choose.");
                    Console.WriteLine("\nWhich computer do you want to test out? (F)irst computer, (S)econd computer\n\nPress Q to quit");
                    CompChoice = Console.ReadLine().ToLower().Trim();
                    if (CompChoice == "f")
                    {
                        //ends in player death
                        //sets off alarm and fills room with poison gas
                        Console.WriteLine("You walk to the first monitor. The diagrams and images seem larger than life and are almost too high quality to be displayed in such a rundown and dirty place. You look at the monitor then look to the keyboard. You don't know which key to hit, so you hit enter. Suddenly an alarm blares and the screen flashes red. A thick green fog fills the room, and you find it hard to breathe. You fall to the floor, clutching your throat as a dark figure looms over you. Your world goes dark.");
                        End.GameEnd(GasDeath);
                    }
                    else if (CompChoice == "s")
                    {
                        //advances to next section of the room
                        //discovers history of pres/head doctor
                        Console.WriteLine("You walk to the second monitor. The massive walls of text on the screen make your eyes cross, along with the very messily written notes you can see. You wonder if there's any information here that you may need, so you grab the mouse and begin clicking around. After a couple minutes of digging, you've discovered the biggest secret of the hospital: the head doctor has been killing his patients. There are numerous articles on the computer, and each one explains in gruesome detail how the doctor massacred each of his patients then performed gruesome experiments on them in hopes of bringing them back to life. There are images of mangled and burned bodies, dismembered brains, severed arms, and much more. You click out of it all and shiver aggressively, then walk away from the computer.");
                    }
                    else if (CompChoice == "q")
                    {
                        //end game
                        End.GameEnd(QuitMessage);
                    }
                    break;
                case "t":
                    Console.WriteLine("You turn your direction towards the door at the back of the room and notice two tables on either side of it. You walk towards the tables and notice that both are covered in rusted and bloody medical equipment. However, something in you tells you to look through all of the equipment to find a way to get into the door. But which table should you investigate?");
                    Console.WriteLine("\nWhich table do you want to investigate? (L)eft table, (R)ight table\n\nPress Q to quit");
                    TableChoice = Console.ReadLine().Trim().ToLower();
                    if (TableChoice == "l")
                    {
                        //advances to next room
                        //finds a key card for door
                        Console.WriteLine("You head towards the table on the left. The equipment looks dangerous enough to warrant several tetanus shots, but you try to push that thought aside. You grab the safest looking scalpel on the table and use it to sift through the equipment, trying not to cut yourself on any sharp edges. After a few minutes, you're ready to give up, but then you see a slight bit of pastic peek through the pile of rusted metal. You move the equipment aside and see a hospital key card. You carefully grab it and sip it into your pocket. This'll be useful, you think to yourself.");
                    }
                    else if (TableChoice == "r")
                    {
                        //ends in player death
                        //cuts themselves on a scalpel or something and gets poisoned + other gross stuff
                        Console.WriteLine("You head towards the table on the right. All of the equipment is covered in enough blood and rust that one cut could be extremely deadly. Who knows how much dangerous bacteria could be living on all of this. You opt to sift through using your hands since there's nothing else here that you could use, but you findut soon that this was a terrible mistake. You slice your hand open on a scalpel and see an aggressive amount of gangrene take over your hand. What's worse, you're bleeding profusely. There's nothing you can do to stop it, so the infection spreads up your arms and soon across your entire body.");
                        End.GameEnd(DeadDeath);
                    }
                    else if (TableChoice == "q")
                    {
                        //end game
                        End.GameEnd(QuitMessage);
                    }
                    break;
                case "q":
                    End.GameEnd(QuitMessage);
                    break;


            }
        }

        //method for fighting the doctor
        public void FinalBoss(string FightChoice, config End)
        {
            //dieroll object
            int diceroll = config.DiceRoll(1,3);

            //fighting the bugs
            if (FightChoice == "b")
            {
                bigfire_bug createBug;
                //this is where the player encounters the bugs
                if (diceroll == 1)
                {
                    Console.WriteLine("You see a rather large orange bug fly towards you. Do you touch it as it nears you? Y/N: ");
                    string YorN = Console.ReadLine().ToLower().Trim();
                    bool getanswer = false;
                    //int attack = 3;

                    do
                    {
                        if (YorN == "y")
                        {
                            getanswer = true;
                        }
                        else if (YorN == "n")
                        {
                            getanswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter yes or no");
                            getanswer = false;
                        }
                    }
                    while (getanswer == false);

                    if (YorN == "y")
                    {
                        Console.WriteLine("You decide to touch the strange bug, but then it moves as if it is ready to attack you.");
                        createBug = new orangefire_bug();
                        createBug.Attack();
                    }
                    else if (YorN == "n")
                    {
                        Console.WriteLine("You decide not to touch the bug, and it flies right past you into the darkness.");
                    }
                }
                else if (diceroll == 2)
                {
                    Console.WriteLine("You see a rather large blue bug fly towards you. Do you touch it as it nears you? Y/N: ");
                    string YorN = Console.ReadLine().ToLower().Trim();
                    bool getanswer = false;

                    do
                    {
                        if (YorN == "y")
                        {
                            getanswer = true;
                        }
                        else if (YorN == "n")
                        {
                            getanswer = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter yes or no");
                            getanswer = false;
                        }
                    }
                    while (getanswer == false);

                    if (YorN == "y")
                    {
                        Console.WriteLine("You decide to touch the strange bug, but then it moves as if it is ready to attack you.");
                        createBug = new bluefire_bug();
                        createBug.Attack();
                    }
                    else if (YorN == "n")
                    {
                        Console.WriteLine("You decide not to touch the bug, and it flies right past you into the darkness.");
                    }
                }

            }

            //final boss battle
            //confront doctor about past, fight doctor (doc has syringe, either grab IV thingy or heart monitor (heart monitor wins),
            //throw at doctor
            //free girl strapped to table, leave hospital, final choice of setting it on fire or
            //calling authorities
            string QuitMessage = "You quit the game";
            string StabDeath = "You died from a stab wound";
            string SyringeDeath = "You died by poison injection";

            if (FightChoice == "l")
            {
                //player dies
                Console.WriteLine("You dodge to the left. That was a terrible decision, though, since the doctor happens to be right handed. You jump directly into his strike and hit the eall with a thud as he sends the bloody knife into your stomach. You cough up a ton of blood and you can feel your senses dimming. The last thing you hear before everything fades to black is the doctor's low chuckle as he says 'You'll be the next body on this bed.'");
                End.GameEnd(StabDeath);

            }
            else if (FightChoice == "r")
            {
                //end up next to heart monitor
                Console.WriteLine("You dodge to the right, away from the doctor's strike. You end up right next the the girl in the bed. The doctor pulls out a syringe of a strangely colored poison. 'This will keep you out o fmy way permanently' he growls. You look around you and all you see are an IV drip and the heart monitor." +
                    "\n\nWhich one do you grab? (I)V drip, (H)eart monitor\n\nPress Q to quit");
                string SwingChoice = Console.ReadLine().Trim().ToLower();
                if (SwingChoice == "i")
                {
                    //player dies
                    Console.WriteLine("You grab the IV drip and move to swing it at the doctor. Instead, you tear the line out of the unconcious girl's arm. The sound it makes terrifies you and forces you to turn your head towards her small body, giving the doctor enough time to lunge at you with the syringe. He sticks it into your neck and forces all of the poison into your blood stream. You fall to the floor and your eyes roll back into your head. All you can hear before you go is the low chuckle of the doctor beside you.");
                    End.GameEnd(SyringeDeath);
                }
                else if (SwingChoice == "h")
                {
                    //knock out doctor
                    Console.WriteLine("You grab the heart monitor and swing it at the doctor with all your might. The small clip connecting it to the girl flies off and leaves her unharmed. The large monitor connects with the doctor's temple as he runs at you, knocking him out cold. As a precaution, you take the syringe from his hand and inject a bit of the poison into his system. You then work the girl onto your back and look for a way to escape.");
                }
            }
            else if (FightChoice == "q")
            {
                //end game
                End.GameEnd(QuitMessage);
            }

        }

        //method for final decision at the end of the game
        public void EndGame(string EndChoice, config End)
        {
            string QuitMessage = "You quit the game";

            if (EndChoice == "a")
            {
                //call cops, give them the girl
                Console.WriteLine("You set the girl down next to your bike and run inside to find a phone. You run into the president's office and pray the old dusty phone works. When you dial 911 and hear the operator pick up, you almost cry out of relief. You quickly explain everything that happened and run back outside to the girl. She's breathing and doesn't seem very injured, much to your relief. Within minutes, an ambulance arrives followed by police cars and fire trucks. You hand over the girl as the police interrogate you. Finally, you're taken to the hospital to be checked on. The girl's safety is ensured, and you're just glad it's all over.");
            }
            else if (EndChoice == "f")
            {
                //set building on fire, including cellar (find stuff in checkup room) and take the girl with you
                Console.WriteLine("You place the girl next to your bike and run into the hospital. You find as many flammable chemicals and towels as possible and start a fire with a lighter you found in the checkup rooms. You hesitate for a moment, thinking about the doctor and all of the grief he must have felt after killing all of his patients. It all must have driven him insane. You light the chemicals and allow the flames to take up the entire hospital, making sure you send some flames down into the basement. You go back outside to the girl and work your way onto your bike. You'll take her to another hospital, you think, as you bike away from the hospital.");
            }
            else if (EndChoice == "q")
            {
                //end game
                End.GameEnd(QuitMessage);
            }
        }

    }
}
