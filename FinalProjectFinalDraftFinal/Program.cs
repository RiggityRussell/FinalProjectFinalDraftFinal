using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // **********************************************************************
            // *Title:              Final Project                                   *    
            // *Application Type:   Console                                         *
            // *Author:             Arlt, Russell                                   *
            // *Description:        A text based mystery game                       *
            // *Date Created:       3/31/2021                                       *
            // *Date Revised:       Constantly                                      *
            // **********************************************************************


            Entry();
            Story();

        }

        #region INTRO STORY
        private static void Story()
        {
            string userName;
            string userResponse;
            Console.Clear();
            NewLineTab("It is 1920, you a hardboiled detective since the War to End All Wars.");
            NewLineTab("What is your name Detective?\n");
            userName = Console.ReadLine();
            NewLineTab("The local police have shown up on your doorstep at 2am. There has been a murder at the Helmsberg Mansion.");
            NewLineTab("It seems they need your help to get to the bottom of it.");
            NewLineTab($"Do you accept the assignment {userName}? [yes | no]\n");
            userResponse = Console.ReadLine().ToLower();
            if (userResponse == "yes" || userResponse == "y" || userResponse == "ok" || userResponse == "yeah that sounds good" || userResponse == "i'm gonna solve this mystery so hard")
            {
                NewLineTab("Great! Lets get going.");
                DisplayContinuePromt();
                TheHouseDrive();
            }
            else
            {
                ByeByeTime();
            }

        }


        #endregion

        #region DRIVING TO THE HOUSE
        private static void TheHouseDrive()
        {
            Console.Clear();
            NewLineTab("The police drive you in a real automobile, you havent been in many since the war.");
            NewLineTab("Soon you approach a massive house at the top of a hill.");
            NewLineTab("The officers fill you in on the situation, the illustrious Vincent Helmsberg was found dead in his Mansion.");
            NewLineTab("There were many people there this evening.");
            SuspectMansionChoice();
        }
        #endregion

        #region SUSPECT OR MANSION CHOICE
        static void SuspectMansionChoice()
        {
            string menuChoice;

            NewLineTab("Enter a) to hear about suspects.");
            Console.WriteLine("\tEnter b) to go to the Mansion.");

            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    TheSuspects();
                    break;

                case "b":
                    TheHouseExterior();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Well that doesn't do anything...\n");
                    NewLineTab("Press any key");
                    Console.ReadKey();
                    SuspectMansionChoice();
                    break;
            }
        }
        #endregion

        #region SEEING THE HOUSE FIRST TIME
        private static void TheHouseExterior()
        {
            string menuChoice;
            DisplayHeader("The Driveway");
            NewLineTab("The police car pulls up the driveway, there are 2 other police cars here already.");
            NewLineTab("There are another 2 black cars there as well, and a horse drawn carriage");
            NewLineTab("Rain starts coming down in sheets as you pull up next to the carraige.");
            NewLineTab("Officer Dalson tells you 'most everyone is in their rooms right now.'");
            NewLineTab("He rolls another cigarette quickly and lights it up with a match.");
            NewLineTab("'You can interview them as you see fit, and investigate the Mansion as you please.'");
            NewLineTab("As you step out into the rain the massive scale of the Mansion hits you.");
            NewLineTab("Vincent certainly was eccentric and built a massive Baroque style Mansion to live in.");
            NewLineTab("You even spot some Gargoyles near the roof.");
            Console.WriteLine("\n\tEnter a) To go inside the front door of the Mansion.");
            Console.WriteLine("\tEnter b) To walk around the outside of the Mansion.");


            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    MansionLobby();
                    break;

                case "b":
                    MansionExterior();
                    break;

                case "Look inside the carraige":
                    NewLineTab("You pull the door to carraige open startling a young man napping inside it.");
                    NewLineTab("He jumps up quickly, 'I'm sorry officer! I know I'm not supposed to nap on duty!'");
                    NewLineTab("He looks quite worried as you brush him off.");
                    NewLineTab("Your eyes flit over the carraige. Looks like childs toys on the floor. Must be the carraige Vinny arrived in.");
                    DisplayContinuePromt();
                    TheHouseExterior();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    NewLineTab("Press any key");
                    Console.ReadKey();
                    TheHouseExterior();
                    break;
            }

        }
        #endregion

        #region OUTSIDE OF THE HOUSE

        #region MANSION EXTERIOR
        private static void MansionExterior()
        {
            string menuChoice;

            DisplayHeader("Mansion Exterior");
            NewLineTab("The rain pelts you seemingly from every direction. Thunder cracks overhead and lightning periodically lights up the night.");
            NewLineTab("As you walk around the exterior you can tell that lights are on in practically every room in the house.");
            NewLineTab("Some of the windows have the curtains drawn back");
            NewLineTab("There is a back entrance to the Mansion on the North side of the house.");
            NewLineTab("You notice in the Northwest corner of the yard is a small graveyard.");
            NewLineTab("You see the gardeners hut on the east side of the house, the front door swinging slightly in the wind and rain.");
            NewLineTab("The grounds, that you can barely see in the darkness and rain, seem to be maintained meticulously.");
            NewLineTab("At this point you are soaked. What would you like to do?");
            NewLineTab("Enter a) to go to the front door.");
            Console.WriteLine("\tEnter b) to go to the back door.");
            Console.WriteLine("\tEnter c) to investigate the gardeners hut");
            Console.WriteLine("\tEnter d) to investigate the graveyard.");
            Console.WriteLine("\tEnter any command you want. [you can try something like, shut the gardeners door, or do a cartwheel]");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You hunch over to get away from the wind and rain. A little inside time will do you good.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You hunch over to get away from the wind and rain. A little inside time will do you good.");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "c":
                    GardenersHut();
                    break;

                case "d":
                    Graveyard();
                    break;

                case "do a cartwheel":
                    Console.Clear();
                    NewLineTab("You take the time to look where your hands are going and take a deep breath.");
                    NewLineTab("You can't see your cartwheel, but you landed on your feet. Probably looked awesome.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "shut the gardeners door":
                    Console.Clear();
                    NewLineTab("You shut the door. It clicks satisfyingly. Another door closed!");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "look in the window":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "look in the windows":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "look inwindow":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "look in windows":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "climb mansion":
                    Console.Clear();
                    NewLineTab("You grab some of the craggy outcroppings on this wild old Mansion.");
                    NewLineTab("The rain pelts you as you get higher and higher. Soon you're 10 feet off the ground.");
                    NewLineTab("WHOOPS! You slip and fall back into the mud. Thankfully the rain has made the ground quite soft.");
                    NewLineTab("You pick yourself and your hat off the ground and sigh deeply. If only you had climbed more as a child.");
                    NewLineTab("But no, no, regrets are foolhardy. You decide to continue on.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "x":
                    MansionLobby();
                    break;


                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;
            }
        }

        private static void MansionExteriorWithGardenersDoorClosed()
        {
            string menuChoice;

            DisplayHeader("Mansion Exterior");
            NewLineTab("The rain pelts you seemingly from every direction. Thunder cracks overhead and lightning periodically lights up the night.");
            NewLineTab("As you walk around the exterior you can tell that lights are on in practically every room in the house.");
            NewLineTab("Some of the windows have the curtains drawn back");
            NewLineTab("There is a back entrance to the Mansion on the North side of the house.");
            NewLineTab("You notice in the Northwest corner of the yard is a small graveyard.");
            NewLineTab("The grounds, that you can barely see in the darkness and rain, seem to be maintained meticulously.");
            NewLineTab("At this point you are soaked. What would you like to do?");
            NewLineTab("Enter a) To go to the front door.");
            Console.WriteLine("\tEnter b) to go to the back door.");
            Console.WriteLine("\tEnter c) to investigate the gardeners hut");
            Console.WriteLine("\tEnter d) to investigate the graveyard.");
            Console.WriteLine("\tEnter any command you want. [you can try something like, do a cartwheel]");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You hunch over to get away from the wind and rain. A little inside time will do you good.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You hunch over to get away from the wind and rain. A little inside time will do you good.");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "c":
                    GardenersHutWithDoorClosed();
                    break;

                case "d":
                    Graveyard();
                    break;

                case "do a cartwheel":
                    Console.Clear();
                    NewLineTab("You take the time to look where your hands are going and take a deep breath.");
                    NewLineTab("You can't see your cartwheel, but you landed on your feet. Probably looked awesome.");
                    DisplayContinuePromt();
                    MansionExterior();
                    break;

                case "look in the window":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "look in the windows":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "look in window":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "look in windows":
                    Console.Clear();
                    NewLineTab("You look in a window with the curtains drawn back, no one ever gets in trouble for this right?");
                    NewLineTab("You see what looks like a library. There is a police officer sitting in a chair by the door.");
                    NewLineTab("He keeps nodding off. Sleepy little guy.");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "climb mansion":
                    Console.Clear();
                    NewLineTab("You grab some of the craggy outcroppings on this wild old Mansion.");
                    NewLineTab("The rain pelts you as you get higher and higher. Soon you're 10 feet off the ground.");
                    NewLineTab("WHOOPS! You slip and fall back into the mud. Thankfully the rain has made the ground quite soft.");
                    NewLineTab("You pick yourself and your hat off the ground and sigh deeply. If only you had climbed more as a child.");
                    NewLineTab("But no, no, regrets are foolhardy. You decide to continue on.");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "x":
                    MansionLobby();
                    break;


                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    DisplayContinuePromt();
                    MansionExteriorWithGardenersDoorClosed();
                    break;
            }
        }

        private static void GardenersHutWithDoorClosed()
        {
            string menuChoice;

            Console.Clear();
            NewLineTab("You pull the door open completely and enter the hut. You light a match to see and notice a lantern next to the door.");
            NewLineTab("As you light the lantern it fills you with warming relief. You take in your surroundings.");
            NewLineTab("This is an area that is well used. You can feel the meticulousness of the person by looking around.");
            NewLineTab("The tools hanging on the wall are cleaned and oiled, and are all in place. Shovels, rakes, buckets, hammers.");
            NewLineTab("You walk around the shed and turn over a few things on a workbench. Doesn't seem to be much here.");
            NewLineTab("You try to open the workbench but the drawers are locked.");
            NewLineTab("Enter a) to leave the hut.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    MansionExteriorWithGardenersDoorClosed();
                    break;

                case "break into workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHutWithDoorClosed();
                    break;

                case "open workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHutWithDoorClosed();
                    break;

                case "unlock workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHutWithDoorClosed();
                    break;

                case "open drawer":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHutWithDoorClosed();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    DisplayContinuePromt();
                    GardenersHutWithDoorClosed();
                    break;
            }
        }
        #endregion

        #region GRAVEYARD   
        private static void Graveyard()
        {
            string menuChoice;

            Console.Clear();
            NewLineTab("You walk up to the small metal fence surrounding the graveyard.");
            NewLineTab("You pull on the gate but find that it is rusted shut.");
            NewLineTab("You step over the fence and look around. There are 6 headstones here. Its hard to make them out in the rain.");
            NewLineTab("There is a small mausoleum in the corner.");
            NewLineTab("You walk around the graveyard, it seems kind of overgrown compared to the rest of the yard.");
            NewLineTab("Enter a) to leave the graveyard.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    MansionExterior();
                    break;

                case "look in mausoleum":
                    Console.Clear();
                    NewLineTab("You have to duck to get into the mausoleum. It is small, but dry.");
                    NewLineTab("There is an elaborate sarcophagus here with a woman carved out of marble on top.");
                    NewLineTab("The inscription above it reads, 'Here lies Annabelle Helmsberg, beloved wife of Vincent Helmsberg.'");
                    NewLineTab("The mausoleum looks to be incredibly clean and well kept up compared to the graveyard.");
                    NewLineTab("There are fresh flowers in a vase on a small table next to the sarcophagus, and a small wooden chair.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "search mausoleum":
                    Console.Clear();
                    NewLineTab("You have to duck to get into the mausoleum. It is small, but dry.");
                    NewLineTab("There is an elaborate sarcophagus here with a woman carved out of marble on top.");
                    NewLineTab("The inscription above it reads, 'Here lies Annabelle Helmsberg, beloved wife of Vincent Helmsberg.'");
                    NewLineTab("The mausoleum looks to be incredibly clean and well kept up compared to the graveyard.");
                    NewLineTab("There are fresh flowers in a vase on a small table next to the sarcophagus, and a small wooden chair.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "check mausoleum":
                    Console.Clear();
                    NewLineTab("You have to duck to get into the mausoleum. It is small, but dry.");
                    NewLineTab("There is an elaborate sarcophagus here with a woman carved out of marble on top.");
                    NewLineTab("The inscription above it reads, 'Here lies Annabelle Helmsberg, beloved wife of Vincent Helmsberg.'");
                    NewLineTab("The mausoleum looks to be incredibly clean and well kept up compared to the graveyard.");
                    NewLineTab("There are fresh flowers in a vase on a small table next to the sarcophagus, and a small wooden chair.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "investigate mausoleum":
                    Console.Clear();
                    NewLineTab("You have to duck to get into the mausoleum. It is small, but dry.");
                    NewLineTab("There is an elaborate sarcophagus here with a woman carved out of marble on top.");
                    NewLineTab("The inscription above it reads, 'Here lies Annabelle Helmsberg, beloved wife of Vincent Helmsberg.'");
                    NewLineTab("The mausoleum looks to be incredibly clean and well kept up compared to the graveyard.");
                    NewLineTab("There are fresh flowers in a vase on a small table next to the sarcophagus, and a small wooden chair.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "go in mausoleum":
                    Console.Clear();
                    NewLineTab("You have to duck to get into the mausoleum. It is small, but dry.");
                    NewLineTab("There is an elaborate sarcophagus here with a woman carved out of marble on top.");
                    NewLineTab("The inscription above it reads, 'Here lies Annabelle Helmsberg, beloved wife of Vincent Helmsberg.'");
                    NewLineTab("The mausoleum looks to be incredibly clean and well kept up compared to the graveyard.");
                    NewLineTab("There are fresh flowers in a vase on a small table next to the sarcophagus, and a small wooden chair.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "investigate gravestones":
                    Console.Clear();
                    NewLineTab("The headstones are quite old. It seems that they are all Helmsbergs.");
                    NewLineTab("It seems quite strange that the graveyard is in disrepair, while the rest of the yard is maintained.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "look at gravestones":
                    Console.Clear();
                    NewLineTab("The headstones are quite old. It seems that they are all Helmsbergs.");
                    NewLineTab("It seems quite strange that the graveyard is in disrepair, while the rest of the yard is maintained.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "look at graves":
                    Console.Clear();
                    NewLineTab("The headstones are quite old. It seems that they are all Helmsbergs.");
                    NewLineTab("It seems quite strange that the graveyard is in disrepair, while the rest of the yard is maintained.");
                    DisplayContinuePromt();
                    Graveyard();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    DisplayContinuePromt();
                    Graveyard();
                    break;
            }

        }
        #endregion

        #region GARDENERS HUT  
        private static void GardenersHut()
        {
            string menuChoice;

            Console.Clear();
            NewLineTab("You pull the door open completely and enter the hut. You light a match to see and notice a lantern next to the door.");
            NewLineTab("As you light the lantern it fills you with warming relief. You take in your surroundings.");
            NewLineTab("This is an area that is well used. You can feel the meticulousness of the person by looking around.");
            NewLineTab("The tools hanging on the wall are cleaned and oiled, and are all in place. Shovels, rakes, buckets, hammers.");
            NewLineTab("You walk around the shed and turn over a few things on a workbench. Doesn't seem to be much here.");
            NewLineTab("You try to open the workbench but the drawers are locked.");
            NewLineTab("Enter a) to leave the hut.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    MansionExterior();
                    break;

                case "break into workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHut();
                    break;

                case "open workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHut();
                    break;

                case "unlock workbench":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHut();
                    break;

                case "open drawer":
                    Console.Clear();
                    NewLineTab("You grab a flat tool off the wall and jam it into the workbench and jiggle it around until something breaks.");
                    NewLineTab("The drawer opens and you find bottles, lots of empty bottles. Looks like someone has a drinking problem and they are hiding it.");
                    NewLineTab("You sift through the bottles, listening to them clink satisfyingly. You find a small notebook with letters stuffed in it.");
                    NewLineTab("You look through the letters, and realize that they are love letters from Vincent's wife Kathleen.");
                    NewLineTab("As you skim through them you realize that Pete and Kathleen had an affair that went on for years, but Kathleen recently stopped it.");
                    NewLineTab("Sometimes breaking into other peoples property is helpful you think to yourself.");
                    DisplayContinuePromt();
                    GardenersHut();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    DisplayContinuePromt();
                    GardenersHut();
                    break;
            }
        }
        #endregion

        #endregion

        #region MANSION BACK ENTRANCE   
        private static void MansionBackEntrance()
        {
            string menuChoice;
            Console.Clear();
            DisplayHeader("The Mansion's Back Enterance");
            NewLineTab("The back enterance seems to be mostly used by the staff.");
            NewLineTab("There are some coats hanging on pegs, and cursory glances at them prove that they are staff coats.");
            NewLineTab("It is clean back here, as though whoever takes care of this area makes a point to keep it orderly.");
            NewLineTab("There is a painting of Vincent Helmsberg on the west wall.");
            NewLineTab("Enter a) to go to the Mansion Exterior.");
            Console.WriteLine("\tEnter b) to go to the Understairs.");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    MansionExterior();
                    break;

                case "b":
                    UnderStairs();
                    break;

                case "inspect painting":
                    Console.Clear();
                    NewLineTab("You look carefully at the front of the painting and the frame before you take it off the wall.");
                    NewLineTab("Doesn't seem to be too strange. As you turn the painting over to look at it there is writing on it.");
                    NewLineTab("'To my dearest Vincent. A portrait of the person you love to look at ALMOST as much as you love to look at me!'");
                    NewLineTab("It is signed, 'Annabelle'.");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "look at painting":
                    Console.Clear();
                    NewLineTab("You look carefully at the front of the painting and the frame before you take it off the wall.");
                    NewLineTab("Doesn't seem to be too strange. As you turn the painting over to look at it there is writing on it.");
                    NewLineTab("'To my dearest Vincent. A portrait of the person you love to look at ALMOST as much as you love to look at me!'");
                    NewLineTab("It is signed, 'Annabelle'.");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "search coats":
                    Console.Clear();
                    NewLineTab("You don't trust the servants, hell you don't trust ANYONE.");
                    NewLineTab("You search the pockets of coat after coat quickly and efficiently.");
                    NewLineTab("Not much in most of them, but wait...... a gun? Interesting. Why would a chef need a gun? Maybe confront Landen about that later....");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "investigate coats":
                    Console.Clear();
                    NewLineTab("You don't trust the servants, hell you don't trust ANYONE.");
                    NewLineTab("You search the pockets of coat after coat quickly and efficiently.");
                    NewLineTab("Not much in most of them, but wait...... a gun? Interesting. Why would a chef need a gun? Maybe confront Landen about that later....");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "look at coats":
                    Console.Clear();
                    NewLineTab("You don't trust the servants, hell you don't trust ANYONE.");
                    NewLineTab("You search the pockets of coat after coat quickly and efficiently.");
                    NewLineTab("Not much in most of them, but wait...... a gun? Interesting. Why would a chef need a gun? Maybe confront Landen about that later....");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Hmmmmmm. Looks like that doesn't do anything. Better try again.\n");
                    NewLineTab("Press any key");
                    DisplayContinuePromt();
                    MansionBackEntrance();
                    break;
            }
        }
        #endregion

        #region UNDERSTAIRS
        private static void UnderStairs()
        {
            string menuChoice;
            DisplayHeader("The Under Stairs");
            NewLineTab("You stand in a T shaped room with a well polished dark wooden door at each end.");
            NewLineTab("There are cupboards in the walls and cleaning supplies tucked into corners.");
            NewLineTab("This is obviously a staging area for the servants to ensure they, and the house, are presentable.");
            NewLineTab("It smells like pine needles and lemons in here, not unpleasant.");
            NewLineTab("Enter a) to go the Mansion Lobby.");
            Console.WriteLine("\tEnter b) to go to the Mansions back entrance");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    MansionLobby();
                    break;

                case "b":
                    MansionBackEntrance();
                    break;

                case "look in cupboards":
                    Console.Clear();
                    NewLineTab("You open the cupboard doors and find an eclectic array of items.");
                    NewLineTab("Scissors, wine, marbles, a neatly folded shirt, a ship in a bottle, a ham sandwich on a plate.");
                    NewLineTab("You search for a while and the only thing of note you turn up is a small hand painted portrait of Vincent.");
                    NewLineTab("Its impossible to tell who it belongs to, but it looks like it is hidden here for some reason.");
                    NewLineTab("Press any key to continue.");
                    Console.ReadKey();
                    UnderStairs();
                    break;

                case "inspect cupboards":
                    Console.Clear();
                    NewLineTab("You open the cupboard doors and find an eclectic array of items.");
                    NewLineTab("Scissors, wine, marbles, a neatly folded shirt, a ship in a bottle, a ham sandwich on a plate.");
                    NewLineTab("You search for a while and the only thing of note you turn up is a small hand painted portrait of Vincent.");
                    NewLineTab("Its impossible to tell who it belongs to, but it looks like it is hidden here for some reason.");
                    NewLineTab("Press any key to continue.");
                    Console.ReadKey();
                    UnderStairs();
                    break;

                case "investigate cupboards":
                    Console.Clear();
                    NewLineTab("You open the cupboard doors and find an eclectic array of items.");
                    NewLineTab("Scissors, wine, marbles, a neatly folded shirt, a ship in a bottle, a ham sandwich on a plate.");
                    NewLineTab("You search for a while and the only thing of note you turn up is a small hand painted portrait of Vincent.");
                    NewLineTab("Its impossible to tell who it belongs to, but it looks like it is hidden here for some reason.");
                    NewLineTab("Press any key to continue.");
                    Console.ReadKey();
                    UnderStairs();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("This doesn't seem to do anything. Maybe try something else?\n");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;
            }
        }
        #endregion

        #region MANSION LOBBY
        private static void MansionLobby()
        {
            string menuChoice;
            DisplayHeader("The Mansion Lobby");
            NewLineTab("You enter the Mansions Lobby. The front entry doors are wooden and elaborately carved with wild animals.");
            NewLineTab("You see a massive curved staircase in front of you in a large open room. A chandelier hangs from the ceiling sparkling from the dozens of candles in it.");
            NewLineTab("There are portraits and paintings hanging on the walls which look old enough to be expensive, even if some of them don't look that well done.");
            NewLineTab("There are benches lining the walls, except for where there are large multi glass paned doors to the East and West.");
            NewLineTab("An officer nods at you from a bench where he is lounging and smoking a cigarrete.");
            NewLineTab("You can see a hallway under the stairs as well. Looks as though its a servants hallway.");
            NewLineTab("Enter a) to go out the Front door.");
            Console.WriteLine("\tEnter b) to talk to the officer.");
            Console.WriteLine("\tEnter c) to go to the East door.");
            Console.WriteLine("\tEnter d) to go to the West door.");
            Console.WriteLine("\tEnter e) to go up the stairs.");
            Console.WriteLine("\tEnter f) to go to the understairs.");
            Console.WriteLine("\tEnter g) to call everyone here to SOLVE THE MYSTERY");
            Console.WriteLine("\tEnter any command you want. [you can try something like, inspect the paintings, or roll on the carpet to get dry.]");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    MansionExterior();
                    break;

                case "b":
                    LoungingOfficer();
                    break;

                case "c":
                    LibPartOne();
                    break;

                case "d":
                    DiningRoomPartOne();
                    break;

                case "e":
                    UpFancyStaircase();
                    break;

                case "f":
                    UnderStairs();
                    break;

                case "g":
                    SOLVETHEMYSTERY();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "inspect the paintings":
                    Console.Clear();
                    NewLineTab("You walk slowly through the Lobby looking at the paintings. Some are portraits of Elder Helmsbergs.");
                    NewLineTab("There is also a painting of a civil war battle, and a LOT of paintings of horses.");
                    NewLineTab("You determine conclusively that no painting killed Vincent. Just isn't possible. There's no blood on any of them. Plus they just don't seem the type.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                case "look at the paintings":
                    Console.Clear();
                    NewLineTab("You walk slowly through the Lobby looking at the paintings. Some are portraits of Elder Helmsbergs.");
                    NewLineTab("There is also a painting of a civil war battle, and a LOT of paintings of horses.");
                    NewLineTab("You determine conclusively that no painting killed Vincent. Just isn't possible. There's no blood on any of them. Plus they just don't seem the type.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                case "roll on the carpet to get dry":
                    Console.Clear();
                    NewLineTab("You flop on the floor like a fish and start rolling on your back to get dry.");
                    NewLineTab("The carpet here is soft and thick. 'Perfect for getting dry,' you think as you stick all your limbs up like a horse.");
                    NewLineTab("Officer Donaugh is looking at you from the bench. He doesn't seem that put out by all this. He must see weird stuff often.");
                    NewLineTab("Soon you feel more comfortable. Still damp but much better. You get to your feet and stretch. Lets find a killer.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                case "roll on the floor to get dry":
                    Console.Clear();
                    NewLineTab("You flop on the floor like a fish and start rolling on your back to get dry.");
                    NewLineTab("The carpet here is soft and thick. 'Perfect for getting dry,' you think as you stick all your limbs up like a horse.");
                    NewLineTab("Officer Donaugh is looking at you from the bench. He doesn't seem that put out by all this. He must see weird stuff often.");
                    NewLineTab("Soon you feel more comfortable. Still damp but much better. You get to your feet and stretch. Lets find a killer.");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;

                default:
                    NewLineTab("This doesn't seem to do anything. Maybe try something else?\n");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;
            }
        }


        #endregion

        #region FANCY STAIRS

        #region UP FANCY STAIRS
        private static void UpFancyStaircase()
        {
            string menuCHOOOOOOICE;
            DisplayHeader("Some fancy ol stairs!");
            NewLineTab("You approach the stairwell, the curved stairs give you a choice to go up either left or right.");
            NewLineTab("The wooden bannister looks expensive and shiny. The stairs are obviously expensive.");
            NewLineTab("Will you go up the right staircase, or the left?");

            menuCHOOOOOOICE = Console.ReadLine().ToLower();
            switch (menuCHOOOOOOICE)
            {
                case "left":
                    NewLineTab("You walk up the left staircase with the bannister running under your hand.");
                    NewLineTab("Glancing back you see Officer Donaugh with his eyes raised. Thats right, you think to yourself, I'll go up the down stairs if I want.");
                    NewLineTab("With a feeling that must be synonymous with what children have felt when running near pools you walk up the stairs.");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

                case "left staircase":
                    NewLineTab("You walk up the left staircase with the bannister running under your hand.");
                    NewLineTab("Glancing back you see Officer Donaugh with his eyebrows raised. Thats right, you think to yourself, I'll go up the down stairs if I want.");
                    NewLineTab("With a feeling that must be synonymous with what children have felt when running near pools you walk up the stairs.");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

                case "right":
                    NewLineTab("You walk up the right staircase with the bannister running under your hand.");
                    NewLineTab("Glancing back at Officer Donaugh you see him nod approvingly. Thats right, you think to yourself, I follow the rules when people are watching.");
                    NewLineTab("With a feeling that must be synonymous with those that always follow the rules you walk up the stairs.");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

                case "right staircase":
                    NewLineTab("You walk up the right staircase with the bannister running under your hand.");
                    NewLineTab("Glancing back at Officer Donaugh you see him nod approvingly. Thats right, you think to yourself, I follow the rules when people are watching.");
                    NewLineTab("With a feeling that must be synonymous with those that always follow the rules you walk up the stairs.");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    NewLineTab("This doesn't seem to do anything. Maybe try something else?\n");
                    DisplayContinuePromt();
                    MansionLobby();
                    break;
            }

        }
        #endregion

        #region MID STAIRS BALCONY
        private static void MidStairsBalcony()
        {
            string menuChoice;
            DisplayHeader("Stair Balcony");
            NewLineTab("You arrive at the stair balcony and find that its just a big flat spot with a door to the outside and 2 stairways going east and west.");
            NewLineTab("The door to the outside balcony is multipaned glass and is at least 10 feet tall.Beautiful.");
            NewLineTab("Would you like to...");
            NewLineTab("Enter a) to go to the outside balcony");
            Console.WriteLine("\tEnter b) to go up the stairs to the east wing.");
            Console.WriteLine("\tEnter c) to go up the stairs to the west wing.");
            Console.WriteLine("\tEnter d) to go down stairs.");
            menuChoice = Console.ReadLine();
            switch (menuChoice)
            {

                case "a":
                    OutsideStairBalcony();
                    break;

                case "b":
                    EastWing();
                    break;

                case "c":
                    WestWing();
                    break;

                case "d":
                    MansionLobby();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("What you trying to do eh? Better try something else.");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

            }
        }
        #endregion

        #region OUTSIDE STAIR BALCONY
        private static void OutsideStairBalcony()
        {
            string menuCHoice;
            DisplayHeader("Outside Balcony");
            NewLineTab("The double doors open to a huge balcony, there are 4 tables out here that can sit 6 people at them.");
            NewLineTab("The balcony is ringed with flower beds, and it must look beautiful in the daytime, but the rainy night time makes it look sad.");
            NewLineTab("You can see the windows along the East and West wing, at least the ones that face the balcony.");
            NewLineTab("There is the remnants of a party out here, wine glasses tipped over, along with a chair tipped over. Food left on plates now soaked.");
            NewLineTab("Enter a) to go back inside.");
            menuCHoice = Console.ReadLine().ToLower();

            switch (menuCHoice)
            {
                case "a":
                    MidStairsBalcony();
                    break;

                case "inspect flower beds":
                    Console.Clear();
                    NewLineTab("You walk along the flower beds running your hand just along the inside of the boxes.");
                    NewLineTab("About halfway through your hand touches something that shouldn't be there....");
                    NewLineTab("You pull it out revealing an empty wine bottle, as you continue along the beds you find several more bottles, all empty");
                    NewLineTab("Why would someone hide these bottles here? Also who would do that?");
                    DisplayContinuePromt();
                    OutsideStairBalcony();
                    break;

                case "look at flower beds":
                    Console.Clear();
                    NewLineTab("You walk along the flower beds running your hand just along the inside of the boxes.");
                    NewLineTab("About halfway through your hand touches something that shouldn't be there....");
                    NewLineTab("You pull it out revealing an empty wine bottle, as you continue along the beds you find several more bottles, all empty");
                    NewLineTab("Why would someone hide these bottles here? Also who would do that?");
                    DisplayContinuePromt();
                    OutsideStairBalcony();
                    break;

                case "look in flower beds":
                    Console.Clear();
                    NewLineTab("You walk along the flower beds running your hand just along the inside of the boxes.");
                    NewLineTab("About halfway through your hand touches something that shouldn't be there....");
                    NewLineTab("You pull it out revealing an empty wine bottle, as you continue along the beds you find several more bottles, all empty");
                    NewLineTab("Why would someone hide these bottles here? Also who would do that?");
                    DisplayContinuePromt();
                    MidStairsBalcony();
                    break;

                case "check flower beds":
                    Console.Clear();
                    NewLineTab("You walk along the flower beds running your hand just along the inside of the boxes.");
                    NewLineTab("About halfway through your hand touches something that shouldn't be there....");
                    NewLineTab("You pull it out revealing an empty wine bottle, as you continue along the beds you find several more bottles, all empty");
                    NewLineTab("Why would someone hide these bottles here? Also who would do that?");
                    DisplayContinuePromt();
                    OutsideStairBalcony();
                    break;

                case "check flower bed":
                    Console.Clear();
                    NewLineTab("You walk along the flower beds running your hand just along the inside of the boxes.");
                    NewLineTab("About halfway through your hand touches something that shouldn't be there....");
                    NewLineTab("You pull it out revealing an empty wine bottle, as you continue along the beds you find several more bottles, all empty");
                    NewLineTab("Why would someone hide these bottles here? Also who would do that?");
                    DisplayContinuePromt();
                    OutsideStairBalcony();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("That doesn't seem to do anything. Could be clues out here though.....");
                    DisplayContinuePromt();
                    OutsideStairBalcony();
                    break;
            }
        }
        #endregion

        #endregion

        #region EAST WING
        private static void EastWing()
        {
            string choiceMenu;
            DisplayHeader("East Wing Hallway");
            NewLineTab("You emerge into the east wing hallway and look around. There are doors lining the walls leading North. To the south the hall swoops in a horseshoe pattern.");
            NewLineTab("You can walk to the west wing hallway that way. There is a sitting area that overlooks the stairwell and the chandelier.");
            NewLineTab("There is a police officer keeping watch in the sitting area.");
            NewLineTab("Enter a) to go to the doors in the north hall.");
            Console.WriteLine("\tEnter b) to go to the sitting area.");
            Console.WriteLine("\tEnter c) to go past the sitting area to the west wing hallway.");
            choiceMenu = Console.ReadLine().ToLower();

            switch (choiceMenu)
            {
                case "a":
                    EWNorthHall();
                    break;

                case "b":
                    UpstairsSittingArea();
                    break;

                case "c":
                    WestWing();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Sadly this does nothing.");
                    DisplayContinuePromt();
                    EastWing();
                    break;
            }
        }
        #endregion

        #region UPSTAIRS SITTING AREA
        private static void UpstairsSittingArea()
        {
            string menuChoice;
            DisplayHeader("Upstairs Sitting Area");
            NewLineTab("You walk to the plush sitting area filled with chairs. You are just above the Chandelier here, and can see this must be where they light it.");
            NewLineTab("Catching the eye of the Officer causes him to nod to you silently. His badge says, Officer Carol.");
            NewLineTab("There are side tables next to the seats for drinks and some of them have drawers in them.");
            NewLineTab("There also seems to be a long drawer up against the bannister. It is latched shut but has no lock.");
            NewLineTab("Enter a) to talk with Officer Carol.");
            Console.WriteLine("\tEnter b) to open the long drawer.");
            Console.WriteLine("\tEnter c) to head to the west hall.");
            Console.WriteLine("\tEnter d) to head to the east hall.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    NewOfficerQuestions();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You unlatch the long drawer and open it to find...... A candle lighter. Its a long pole for changing and lighting the candles in the chandelier.");
                    NewLineTab("Well. At least it wasn't a full confession from the killer or something HELPFUL LIKE THAT.");
                    NewLineTab("Oh well. Back to work.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "c":
                    WestWing();
                    break;

                case "d":
                    EastWing();
                    break;

                case "check side tables":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "investigate side tables":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "look in side table":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "look in drawers":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "investigate drawers":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "look in drawer":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                case "investigate drawer":
                    NewLineTab("You open the drawers of some of the side tables and rustle around in them. The usual suspects are in here, matches, pencils, a lost pair of glasses.");
                    NewLineTab("As you keep looking through them something does stick out to you. A small portrait of Vincent and Annabelle that has been taken from it frame.");
                    NewLineTab("You found it by pulling the drawer almost all the way out, it was crumpled up in the back of the drawer. Someone must have hidden the crumpled portrait here.");
                    DisplayContinuePromt();
                    UpstairsSittingArea();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Huh. Nothing happens. Weird.");
                    DisplayContinuePromt();
                    EastWing();
                    break;
            }
        }


        #endregion

        #region EAST WING NORTH HALL
        private static void EWNorthHall()
        {
            string menuChoice;
            DisplayHeader("North Eastern Hall");
            NewLineTab("The North Eastern hall has 6 doors in it. There is no indication as to what lies behind any of them, but they are all shut.");
            NewLineTab("You being a person who lives in the year 1920 has no trepidation just walking up to a door and knocking on it.");
            NewLineTab("There are 3 doors on each the East and West walls and windows at the north end of the hall.");
            NewLineTab("Time to pick a door!");
            NewLineTab("Enter a) to open the closest door to the left.");
            Console.WriteLine("\tEnter b) to open the second door the left.");
            Console.WriteLine("\tEnter c) to open the third door on the left.");
            Console.WriteLine("\tEnter d) to open the first door on the right.");
            Console.WriteLine("\tEnter e) to open the second door on the right.");
            Console.WriteLine("\tEnter f) to open the third door on the right.");
            Console.WriteLine("\tEnter g) to go back to the East Wing.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    OpenPetesRoom();
                    break;

                case "b":
                    OpenJoffreysRoom();
                    break;

                case "c":
                    OpenLandensRoom();
                    break;

                case "d":
                    Bafroom();
                    break;

                case "e":
                    GuestRoom();
                    break;

                case "f":
                    OpenIvysRoom();
                    break;

                case "g":
                    EastWing();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Thats nuthin!\n");
                    DisplayContinuePromt();
                    EWNorthHall();
                    break;
            }
        }

        #region GUEST ROOM
        private static void GuestRoom()
        {
            string menuChoice;
            DisplayHeader("Guest Room");
            NewLineTab("The room is a standard room for this house it seems. A bathroom in the corner and a closet with a bed and side table.");
            NewLineTab("This room is for visiting guests. Though it looks like it has been used quite a bit recently. The closet door is open and clothes are hanging in it.");
            NewLineTab("On the bedside table is a book and reading glasses. A pair of slippers next to the bathroom door as well.");
            NewLineTab("Enter a) to search the room.");
            Console.WriteLine("\tEnter b) to look in the closet.");
            Console.WriteLine("\tEnter c) to look in the bathroom.");
            Console.WriteLine("\tEnter d) to leave the Guest Room.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You take in the rooms surroundings. The curtains are open, you walk over to the widnow and look out. Through the darkness and the rain you can't see much.");
                    NewLineTab("Just then lightening flashes and you can see something. The Gardeners shed. Off in the distance.");
                    NewLineTab("You walk over to the bedside table and pick up the book. It is a journal, the front of which is embossed with the letters JHE.");
                    NewLineTab("Cracking open the cover reveals it to be the personal journal of the great philosopher Jason E. Holtrey. It is filled with advice, musings and messages of hope.");
                    NewLineTab("BORING. Looks like you'll have to keep looking around. The reading glasses next to it are a mans, if that means anything to you.");
                    NewLineTab("Nothing under the bed. Thats something at least. The slippers by the bathroom are also mens slippers.");
                    DisplayContinuePromt();
                    GuestRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("The closet has a few suits and some mens leisure wear within it. Nothing too special, although searching the pockets of the suits reveals pocket squares.");
                    NewLineTab("This wouldn't be too out of place, except that the pocket squares have VH sewn into them. It seems as though Vincent was sleeping in here....");
                    DisplayContinuePromt();
                    GuestRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The bathroom is standard compared to the others. There is a toilet and a sink in here, but no shower. A toothbrush sits on the sink.");
                    NewLineTab("There is not much to see in here sadly. It is a bathroom, for disposal of waste.");
                    DisplayContinuePromt();
                    GuestRoom();
                    break;

                case "d":
                    EWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Sadly that does nothing.\n");
                    DisplayContinuePromt();
                    GuestRoom();
                    break;
            }

        }
        #endregion

        #region BATHROOM
        private static void Bafroom()
        {
            DisplayHeader("The Bathroom");
            NewLineTab("This room is the public bathing area for the staff it seems. There are a 2 tubs and showers, and 2 stalls with toilets in them and a long sink that covers the north wall.");
            NewLineTab("It is clean in here. Looks like Ivy takes her job seriously. You count 5 towels hanging on a drying rack as well. Hmmmmmmm, that is one more than the number of servants.");
            NewLineTab("Walking around the bathroom there isn't much out of place. Toothbrushes are on the sink, toilet paper on the rolls. Looks pretty normal.");
            DisplayContinuePromt();
            EWNorthHall();
        }
        #endregion

        #region IVYS ROOM
        private static void OpenIvysRoom()
        {
            Console.Clear();
            NewLineTab("You knock on the door and a women in her mid-thirties opens the door. 'Hello Detective,' she says. 'Come in please.'");
            DisplayContinuePromt();
            IvysRoom();
        }

        private static void IvysRoom()
        {
            string menuCHoice;
            DisplayHeader("Ivy's Room");
            NewLineTab("Ivy stands near the window and watches you. She doesn't seem to be upset that you are in her personal space. Her eyes do look like she was crying though.");
            NewLineTab("Ivy's room is well lived in. She is obviously a trinket collector, and has shelves filled with little trinkets everywhere. There are also an impressive number of books in here.");
            NewLineTab("It looks as though she was expecting you, the closet and bathroom door are both open. Even from here you can tell this bathroom is bigger than the others.");
            NewLineTab("You notice a pile of books near the bed that start at the floor and end near the ceiling. Looks like someone loves to read. (Hopefully its whoever is playing this game.)");
            NewLineTab("Enter a) to ask Ivy what she knows.");
            Console.WriteLine("\tEnter b) to look in the closet.");
            Console.WriteLine("\tEnter c) to look in the bathroom.");
            Console.WriteLine("\tEnter d) to leave Ivy's room.");
            menuCHoice = Console.ReadLine().ToLower();
            switch (menuCHoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'Well I know that Vinc... Mr. Helmsberg has been sleeping in the guest room for the past week. I don't know why though. I just cleaned it when I realized.'");
                    NewLineTab("'Landen is obsessed with knives, so maybe theres something there. I don't think Joffrey had anything to do with it. He cleans his own room even! I've seen it. It's nice.'");
                    NewLineTab("'Pete and Mr. Helmsberg were pretty close honestly. They talked alot. Pete was a bit of a mess before Mr. Helmsberg helped him out.'");
                    NewLineTab("'Someone in the family could have done it, but I'm not going to accuse anyone. That's your job.' She smiles widely at you.");
                    NewLineTab("'Go ahead and look around my room if you'd like. Nothing incriminating here. I am innocent. Mr. Helmsberg was like a father to me after my father passed. He was a good man.'");
                    DisplayContinuePromt();
                    IvysRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You step over to the closet. It has the usual suspects. Clothes, books, trinkets. Nothing untoward in here it seems.");
                    NewLineTab("Shifting some of the clothes you do find a knife in here, as you pull it out and show it to Ivy with your eyebrows raised she says,");
                    NewLineTab("'I live in a house with almost all men. In a wing of a house with ONLY men. I took a knife from Landen in case I ever need it.'");
                    NewLineTab("You place the knife back in the closet. Better safe than sorry as they say.");
                    DisplayContinuePromt();
                    IvysRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The bathroom has a toilet, sink, bathtub and shower in it. All of them look quite clean, and each one has an array of small trinkets with it.");
                    NewLineTab("The tub has some of those solid rubber ducks near it. A nice but childish affectation. The toilet has a solid statue of Buddha on the tank.");
                    NewLineTab("On the sink can be found many polished rocks, and in the shower a collection of skin exfoliators. Probably none of this was used to kill Vincent.");
                    DisplayContinuePromt();
                    IvysRoom();
                    break;

                case "d":
                    EWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Unfortunately that does nothing.\n");
                    DisplayContinuePromt();
                    IvysRoom();
                    break;
            }

        }
        #endregion

        #region LANDENS ROOM
        private static void OpenLandensRoom()
        {
            string menuChoice;
            DisplayHeader("Landens Room");
            NewLineTab("Looking around Landens room you are glad he is in the kitchen. Lots to look at here.");
            NewLineTab("It smells of oil and metal in here. There are scattered knives everywhere. It looks as though Landen makes and sharpens knives in his spare time.");
            NewLineTab("There is a box that just has knives spilling out of it. There are knives on the floor, hanging on the walls, on the bedside table. The room is basically knife city.");
            NewLineTab("The closet door is open and even from here you can tell its knives all the way down.");
            NewLineTab("The bathroom door is closed. Just a guess, but if you go in there you will probably find more knives.");
            NewLineTab("Well it is good to have hobbies.");
            NewLineTab("Enter a) to try and find a cool knife.");
            Console.WriteLine("\tEnter b) to search knife city.");
            Console.WriteLine("\tEnter c) to look in the bathroom.");
            Console.WriteLine("\tEnter d) to Leave Landens room.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You search around for a while and find a knife with a deer antler horn for a handle and a 7-8 inch blade. Looks wickedly sharp.");
                    NewLineTab("Landen probably won't miss this, you think as you pocket the knife.");
                    DisplayContinuePromt();
                    OpenLandensRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("Looking around the room proves to be relatively fruitless. It looks like Landen is obsessed with only 2 things. Cooking and knives.");
                    NewLineTab("You find some books that are knife sharpening skill challenges, and a handmade recipe book that is cobbled from handwritten recipes that Landen got from others.");
                    NewLineTab("If you weren't here for a murder done with a knife you might find this place charming.");
                    DisplayContinuePromt();
                    OpenLandensRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The bathroom is in fine order. Its a toilet and a sink, big surprise there. There is only one knife on the edge of the sink along with a sharpening stone.");
                    NewLineTab("Seems pretty dangerous to sharpen a knife with your pants down but I guess to each their own.");
                    NewLineTab("Pulling on the mirror reveals..... Nothing. Not a cabinet mirror. Shucks.");
                    DisplayContinuePromt();
                    OpenLandensRoom();
                    break;

                case "d":
                    EWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Nope. Thats nothing. Sad Face.\n");
                    DisplayContinuePromt();
                    OpenLandensRoom();
                    break;
            }
        }
        #endregion

        #region JOFFREYS ROOM
        private static void OpenJoffreysRoom()
        {
            Console.Clear();
            NewLineTab("Knowing that Joffrey is in the Library you walk right into his room.");
            NewLineTab("You shut the door behind you as you take in your surroundings. This room is clean. Like really really clean.");
            NewLineTab("Obsessively clean it could be said. The bed is made perfectly, there isn't even a stray sock on the floor. The book on the bedside table is perfectly placed.");
            NewLineTab("There is a closet and a bathroom, both with the doors closed. A dresser sits in the center of the wall between the bathroom and the closet.");
            NewLineTab("The curtains at the windows are closed currently. They have a deep red tone to them which is beautiful.");
            DisplayContinuePromt();
            JoffreysRoom();
        }

        private static void JoffreysRoom()
        {
            string menuChoice;
            DisplayHeader("Joffrey's Room");
            NewLineTab("Looking around the obsessively clean room again.. The bed is made perfectly, there isn't even a stray sock on the floor. The book on the bedside table is perfectly placed.");
            NewLineTab("There is a closet and a bathroom, both with the doors closed. A dresser sits in the center of the wall between the bathroom and the closet.");
            NewLineTab("The curtains at the windows are closed currently. They have a deep red tone to them which is beautiful.");
            NewLineTab("Enter a) to search the room thoroughly.");
            Console.WriteLine("\tEnter b) to search the closet.");
            Console.WriteLine("\tEnter c) to search the bathroom.");
            Console.WriteLine("\tEnter d) to leave Joffreys Room.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You walk over to the bed and look under the pillows, nothing. Get down on your hands and knees and search under the bed. Not even a dust bunny.");
                    NewLineTab("The curtains are thick and beautiful, you shift them side to side and life them up, nothing. Looking out the window you can see lights on in the West hall.");
                    NewLineTab("You pick up the book from the side table and open it. It was once a copy of 'The Mysterious Affair at Styles,' by Agatha Christie. The keyword being once.");
                    NewLineTab("Every page is covered in scribblings and words. Most of the words seem to just be NO NO NO over and over again. The drawings are some sort of aquatic monsters.");
                    NewLineTab("Oh well. Artists are strange sometimes.");
                    DisplayContinuePromt();
                    JoffreysRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You pull the door to Joffreys closet open. It takes a second for you to grasp what you are looking at. In stark contrast to the room the closet is a mess. Well.");
                    NewLineTab("Calling it a mess may be understated. Its clear looking at this that Joffrey sleeps in here. There are tangled blankets, sheets and pillows on the floor.");
                    NewLineTab("Joffreys clothes are placed inside the hangers so they don't hang down upon him it seems. It also looks as though Joffrey has been writing to someone.");
                    NewLineTab("There is a plethora of letters between Joffrey and someone who just signs HPL. The range of the letters is strange. From normal daily life to sci-fi wildness.");
                    NewLineTab("There are more scribbled drawings that hang on the walls of the closet here and they resemble humanoid squid men in various poses. What some people get up to in their free time eh?");
                    NewLineTab("Doesn't look like there is anything harmful amid the letters and drawings besides a few random letter openers.");
                    DisplayContinuePromt();
                    JoffreysRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The door to the bathroom opens easily and you see a small room with a toilet and a sink in it. Nothing special here it seems. Spotless like the Bedroom.");
                    NewLineTab("Looking around you notice the medicine cabinet behind the mirror is slightly ajar. You open it to find a diverse bunch of glass bottles. All of them have the labels scratched off.");
                    NewLineTab("Popping the top off one reveals a horrible smell. Definitely medicine. No clue what that is though. Oh well.");
                    DisplayContinuePromt();
                    JoffreysRoom();
                    break;

                case "d":
                    EWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("It seems that doesn't do what you want it to. Apologies.\n");
                    DisplayContinuePromt();
                    JoffreysRoom();
                    break;
            }
        }
        #endregion

        #region PETES ROOM
        private static void OpenPetesRoom()
        {
            Console.Clear();
            NewLineTab("You knock on the door and a man who must be Pete opens it. He lets you in and walks to a chair and sits down.");
            NewLineTab("'Come in detective,' Pete says. 'I can't sleep anyways so its nice to have people to talk to. Used to be Vincent. Used to.'");
            NewLineTab("Looking around the room it seems relatively clean. There are some ripe smelling clothes in a hamper in the corner, although that is to be expected.");
            NewLineTab("There are no curtains in Pete's room curiously. They have been removed for some reason. He has a desk in the corner with gardening tools laid out on it.");
            NewLineTab("Pete looks bedraggled. He is thin, very thin. Maybe 130 pounds and at least 5 foot 9 inches tall. His eyes look haunted.");
            NewLineTab("There is a bed, a closet (no door on the closet) and a bathroom in the corner, which thankfully does have a door.");
            NewLineTab("Pete watches you survey his room. 'I hate curtains, can't see whats coming if theres curtains.' He says.");
            DisplayContinuePromt();
            PetesRoom();
        }

        private static void PetesRoom()
        {
            string menuChoice;
            DisplayHeader("Pete the Gardeners Room.");
            NewLineTab("Looking around the room it seems relatively clean. There are some ripe smelling clothes in a hamper in the corner, although that is to be expected.");
            NewLineTab("There are no curtains in Pete's room curiously. They have been removed for some reason. He has a desk in the corner with gardening tools laid out on it.");
            NewLineTab("Pete looks bedraggled. He is thin, very thin. Maybe 130 pounds and at least 5 foot 9 inches tall. His eyes look haunted.");
            NewLineTab("There is a bed, a closet (no door on the closet) and a bathroom in the corner, which thankfully does have a door.");
            NewLineTab("Enter a) to ask Pete what he knows.");
            Console.WriteLine("\tEnter b) to look in the closet.");
            Console.WriteLine("\tEnter c) to look in the bathroom.");
            Console.WriteLine("\tEnter d) to leave the room.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'I don't know much, and I doubt you'll get much out of me.' Pete says before he continues talking.");
                    NewLineTab("'It was a pretty normal day for me. I was cleaning up the grounds and making sure it looked nice for the family. I knew they were coming today.'");
                    NewLineTab("'Once it hit about 4 o clock I came upstairs and came to my room. I don't care for a large number of people. And I'm not really friends with any of them.'");
                    NewLineTab("'Sat in my chair, cleaned my tools, read for a while. Had a smoke up on the balcony while everyone was at dinner.'");
                    NewLineTab("'Came back here and must have dozed off until all the commotion. I went up to check him, as I've seen dead bodies, but I knew the second I laid eyes on him.'");
                    NewLineTab("'Have you seen the body yet?' He doesn't wait for you to answer, 'It was a quick death at least I'm guessing. Bled out quickly.'");
                    NewLineTab("With this he seems to retreat into himself somewhat. He draws his legs up onto the chair and looks out the window.");
                    DisplayContinuePromt();
                    PetesRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You walk on your human legs over to the closet and stick your head inside. Looks like a pretty normal closet.");
                    NewLineTab("There are clothes hanging and some on the floor, there is a collection of weird shaped wood in there, and a hunting rifle in the corner.");
                    NewLineTab("Nothing seems too out of place in the closet.");
                    DisplayContinuePromt();
                    PetesRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("You head into Petes bathroom. Its a toilet and a sink with another hamper and a small dresser.");
                    NewLineTab("Poking around you open the dressers and find them to be full of empty whiskey bottles. They clink quietly together as you shut it.");
                    NewLineTab("The hamper has some dirty work clothes in it but nothing weird thankfully.");
                    DisplayContinuePromt();
                    PetesRoom();
                    break;

                case "d":
                    Console.Clear();
                    NewLineTab("You cast your gaze around the room a final time. Nodding to Pete as you leave.");
                    EWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Thats nuthin!\n");
                    DisplayContinuePromt();
                    PetesRoom();
                    break;
            }

        }
        #endregion

        #endregion

        #region ROOMS OR SUSPECTS 
        private static void NewOfficerQuestions()
        {
            string menuChoice;
            Console.Clear();
            NewLineTab("The Officer clears their throat.");
            NewLineTab("'Hello Detective, my name is Officer Carol. I've been tasked with making sure no one leaves their room. All quiet so far here.'");
            NewLineTab("'Do you want to hear about the suspects up here or which rooms are which?'");
            NewLineTab("Enter a) to hear about the suspects.");
            Console.WriteLine("\tEnter b) to hear about the rooms.");
            Console.WriteLine("\tEnter c) to stop talking with this person.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    NewOfficerSusppects();
                    break;

                case "b":
                    UpstairsRoomsDescriptions();
                    break;

                case "c":
                    UpstairsSittingArea();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Please enter a letter from the menu choices!\n");
                    DisplayContinuePromt();
                    break;
            }
        }
        #endregion

        #region UPSTAIRS ROOM DESCRIPTIONS
        private static void UpstairsRoomsDescriptions()
        {

            Console.Clear();
            NewLineTab("'Well on the East Wing is the servants rooms. Pete is in the first room on the left, Joffrey's room is next, then Landens.'");
            NewLineTab("'Across the hall on the right the first room is the shared bathing room, I hear it has 2 tubs and 2 showers!'");
            NewLineTab("'The next room is a guest room and the last room is Ivy's.'");
            DisplayContinuePromt();
            NewLineTab("'The West Wing is the family rooms. Even though only Vincent and Kathleen live here, the others have permanent rooms as well for when they stay.'");
            NewLineTab("'The first room on the right is Victors, the next room is Kathleen and Vincents, and the third room on the right leads to the smoking patio.'");
            NewLineTab("'On the left side of the West Wing, the first room is Vinny's, the second is Peg and Humphrey's and the last room is Barty's.'");
            DisplayContinuePromt();
            NewOfficerQuestions();
        }
        #endregion

        #region NEW OFFICER SUSPECTS
        private static void NewOfficerSusppects()
        {
            string menuChoice;
            Console.Clear();
            NewLineTab("'Which person do you want to hear about Chief?'");
            Console.WriteLine("\n\tEnter a) to hear about Vincent's Wife Kathleen");
            Console.WriteLine("\tEnter b) to hear about Vincent's oldest son Victor");
            Console.WriteLine("\tEnter c) to hear about Vincent's youngest son Barty");
            Console.WriteLine("\tEnter d) to hear about Vincent's daughter Peg");
            Console.WriteLine("\tEnter e) to hear about Vincent's son in law Humphrey");
            Console.WriteLine("\tEnter f) to hear about Vincent's grandson Vinny");
            Console.WriteLine("\tEnter g) to hear about Vincent's maid Ivy");
            Console.WriteLine("\tEnter h) to hear about Vincent's gardener Pete");
            Console.WriteLine("\tEnter i) to hear about Vincent's butler Joffrey");
            Console.WriteLine("\tEnter j) to hear about Vincent's chef Landen");
            Console.WriteLine("\tEnter k) to hear about Vincent himself");
            Console.WriteLine("\tEnter l) to stop talking to the Officer.");

            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    NOKathleenDescription();
                    break;

                case "b":
                    NOVictorDescription();
                    break;

                case "c":
                    NOBartyDescription();
                    break;

                case "d":
                    NOPegDescription();
                    break;

                case "e":
                    NOHumphreyDescription();
                    break;

                case "f":
                    NOVinnyDescription();
                    break;

                case "g":
                    NOIvyDescription();
                    break;

                case "h":
                    NOPeteDescription();
                    break;

                case "i":
                    NOJoffreyDescription();
                    break;

                case "j":
                    NOLandenDescription();
                    break;

                case "k":
                    NOVincentDescription();
                    break;

                case "l":
                    UpstairsSittingArea();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Please enter a letter from the menu choices!\n");
                    DisplayContinuePromt();
                    break;
            }

        }
        private static void NOVincentDescription()
        {

            DisplayHeader("Who was Vincent Helmsberg?");
            NewLineTab("Vincent was a railroad Baron who became rich beyond most peoples dreams.");
            NewLineTab("Vincent was 86 years old at the time of his death, and was in fine health.");
            NewLineTab("The evening Vincent was killed, he had his family over for dinner.");
            NewLineTab("This is not an unusual thing to have his family come for dinner and stay the night.");
            NewLineTab("Vincent has been known to give quite a bit of money to charity.");
            NewLineTab("Vincent enjoyed cigars and was found dead on his smoking patio.");
            NewLineTab("We know Vincent was killed with a knife to the side of his neck.");
            DisplayContinuePromt();
            NewOfficerSusppects();

        }

        private static void NOLandenDescription()
        {


            DisplayHeader("Who is Landen?");
            Console.WriteLine("\tLanden has been Vincent's live in chef for the last 52 years.");
            NewLineTab("Landen and Vincent have had a good relationship as far as people are aware.");
            NewLineTab("Although he is one of the few people who would argue with Vincent.");
            NewLineTab("Landen and Vincent are close in age, Landen is 81.");
            NewLineTab("There are many sharp knives in the kitchen. Landen kept them razer sharp.");
            DisplayContinuePromt();
            NewOfficerSusppects();

        }

        private static void NOJoffreyDescription()
        {
            DisplayHeader("Who is Joffrey?");
            NewLineTab("Joffrey is Vincents butler, and has only worked for him for the last 10 years.");
            NewLineTab("Joffrey replaced Ornathal after he passed away 10 years ago.");
            NewLineTab("It has been rumored that Joffrey and Vincent never got along as well as Vincent and Ornathal.");
            NewLineTab("That being said, it seems as though Joffrey was at least an adequate replacement to last 10 years.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOPeteDescription()
        {
            DisplayHeader("Who is Pete?");
            NewLineTab("Pete is Vincents Gardener. He was the caretaker of this land before Vincent bought it.");
            NewLineTab("Pete was living in a shack he had built himself out of scraps that he scavenged.");
            NewLineTab("Vincent was going to have Pete forcibly removed from the property, but when he met Pete he realized he was a veteran.");
            NewLineTab("Pete had fought in the White River War and it had repercussions upon his mental health.");
            NewLineTab("When the house was built in 1881 Pete stayed in the Gardeners hut, but eventually accepted a room inside the house.");
            NewLineTab("Pete meticulously cares for the grounds, and takes the landscaping very seriously.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOIvyDescription()
        {
            DisplayHeader("Who is Ivy?");
            NewLineTab("Ivy is Vincents maid, and has held this role for the past 20 years.");
            NewLineTab("Ivy was the daughter of an old friend of Vincents who died many years ago. Ivy was too young to marry and Vicent hired her to be his maid.");
            NewLineTab("She arrived at the house at the age of 15, and continued her studies under Vincents tutelage.");
            NewLineTab("She has not married as of yet, and seemingly has no suitors. She spends her time cleaning and taking care of the house, and her free time reading.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOVinnyDescription()
        {
            DisplayHeader("Who is Vinny?");
            NewLineTab("Vinny is Vincents only grandson, and his namesake.");
            NewLineTab("20 years old now, Vinny has not pursued higher education, or even a factory job.");
            NewLineTab("Vinny lives off of his families money, and spends quite a bit of time with Vincent at the Mansion.");
            NewLineTab("Vincent and Vinny have been known to have loud arguments that get quite heated, but Vincent loved Vinny unswervingly.");
            NewLineTab("Vincent made no effort to hide the fact that he thought Vinny needed to get an education and a job.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOHumphreyDescription()
        {
            DisplayHeader("Who is Humphrey?");
            NewLineTab("Humphrey is Peg's husband and the father of Vinny. He is in his early 50's and is a lawyer.");
            NewLineTab("Humphrey has never fit in well with Vincent or the other Helmsbergs as he came from a simple farming community.");
            NewLineTab("Despite this, he became a very powerful man and an intimidating lawyer.");
            NewLineTab("He does not like to be helped by the staff, and finds the Mansion to be a horrible waste of resources.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOPegDescription()
        {
            DisplayHeader("Who is Peg?");
            NewLineTab("Peg is Vincents only daughter and was the light of his life.");
            NewLineTab("She was doted upon by her father and was given an education, something that was not expected in the late 1800's.");
            NewLineTab("Peg has her fathers intellect and his fiery passion, but she also has her mothers strong resolve.");
            NewLineTab("She married Humphrey against her fathers wishes, and he was never happy about that.");
            NewLineTab("Peg doesn't let anyone tell her what to do, except Vinny. She turns a blind eye to anyhting that he does.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOBartyDescription()
        {
            DisplayHeader("Who is Barty?");
            NewLineTab("Barty is Vincents youngest son, and the recipient of his Railroad Empire.");
            NewLineTab("He took over operation from his older brother Victor soon after he left school.");
            NewLineTab("Many people thought that Victor, or Vincent would be upset about this, but Barty is smart and driven.");
            NewLineTab("He rarely comes around the Mansion anymore as he is busy running the business.");
            NewLineTab("It is rumored that he is working on buying and installing telegram services.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOVictorDescription()
        {
            DisplayHeader("Who is Victor?");
            NewLineTab("Victor is Vincents oldest son, and was groomed to take over the business before Barty took it over from him.");
            NewLineTab("Victor spends most of his time down river at the family stables where he cares for the horses.");
            NewLineTab("He can also be found at the offices when he is asked to be, but doesn't care to be there anymore.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }

        private static void NOKathleenDescription()
        {
            DisplayHeader("Who is Kathleen?");
            NewLineTab("Kathleen is Vicents second wife and is 30 years his younger. They have been married now for 10 years.");
            NewLineTab("She is a Baroness from France who after she became a widow sold everything and moved to America.");
            NewLineTab("Kathleen is a jealous person and likes to have Vincents attention whenever they were together.");
            NewLineTab("She is not the mother to any of the children, in fact she is younger than Victor.");
            NewLineTab("Kathleen enjoys socializing and will attend any high class function that she can be seen at.");
            DisplayContinuePromt();
            NewOfficerSusppects();
        }
        #endregion

        #region WEST WING NOT THE TV SHOW
        private static void WestWing()
        {
            string choiceMenu;
            DisplayHeader("West Wing Hallway");
            NewLineTab("You emerge into the west wing hallway and look around. There are doors lining the walls leading North. To the south the hall swoops in a horseshoe pattern.");
            NewLineTab("You can walk to the east wing hallway that way. There is a sitting area that overlooks the stairwell and the chandelier.");
            NewLineTab("There is a police officer keeping watch in the sitting area.");
            NewLineTab("Enter a) to go to the doors in the north hall.");
            Console.WriteLine("\tEnter b) to go to the sitting area.");
            Console.WriteLine("\tEnter c) to go past the sitting area to the east wing hallway.");
            choiceMenu = Console.ReadLine().ToLower();

            switch (choiceMenu)
            {
                case "a":
                    WWNorthHall();
                    break;

                case "b":
                    UpstairsSittingArea();
                    break;

                case "c":
                    EastWing();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Sadly this does nothing.");
                    DisplayContinuePromt();
                    WestWing();
                    break;
            }
        }
        #endregion

        #region WEST WING NORTH HALL
        private static void WWNorthHall()
        {
            string menuChoice;
            DisplayHeader("North Western Hall");
            NewLineTab("The North Western hall has 6 doors in it. There is no indication as to what lies behind any of them, but they are all shut.");
            NewLineTab("You being a person who lives in the year 1920 have no trepidation just walking up to a door and knocking on it.");
            NewLineTab("There are 3 doors on each the East and West walls and windows at the north end of the hall.");
            NewLineTab("Time to pick a door!");
            NewLineTab("Enter a) to open the closest door to the left.");
            Console.WriteLine("\tEnter b) to open the second door the left.");
            Console.WriteLine("\tEnter c) to open the third door on the left.");
            Console.WriteLine("\tEnter d) to open the first door on the right.");
            Console.WriteLine("\tEnter e) to open the second door on the right.");
            Console.WriteLine("\tEnter f) to open the third door on the right.");
            Console.WriteLine("\tEnter g) to go back to the West Wing proper.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    OpenVinnysRoom();
                    break;

                case "b":
                    HumphreyAndPeg();
                    break;

                case "c":
                    OpenBartyRoom();
                    break;

                case "d":
                    OpenVictorRoom();
                    break;

                case "e":
                    OpenKathleenVincentRoom();
                    break;

                case "f":
                    OpenSmokingPatio();
                    break;

                case "g":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Not a choice unfortunately.\n");
                    DisplayContinuePromt();
                    WWNorthHall();
                    break;
            }
        }

        #region SMOKING PATIO
        private static void OpenSmokingPatio()
        {
            string menuChoice;
            Console.Clear();
            NewLineTab("You open the door expecting a patio that you can walk out onto. Instead you see a very small room with a spiral staircase at the far end.");
            NewLineTab("Between you and the spiral staircase is a wall with many smoking jackets hanging on it, and a shelf with a selection of cigars.");
            NewLineTab("Looks like Vincents body is at the top of the staircase. Time to go look at a dead person.");
            NewLineTab("Enter a) to go up to the Smoking Patio.");
            Console.WriteLine("\tEnter b) to go back to the hallway.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You climb the spiral staircase. Every step bringing you closer to the final moments of someone elses life.");
                    NewLineTab("You emerge onto the patio...");
                    DisplayContinuePromt();
                    SmokingPatio();
                    break;

                case "b":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("DOES NOT COMPUTE\n");
                    DisplayContinuePromt();
                    OpenSmokingPatio();
                    break;
            }
        }

        private static void SmokingPatio()
        {
            string menuChoice;
            DisplayHeader("The Smoking Patio");
            NewLineTab("The smoking patio is a section of roof that has been put on a platform and has its own roof to keep the elements out.");
            NewLineTab("There is a full bar out here, and a small humidor for cigars. Vincents body lays motionless next to a chair. It looks like he stood up and was stabbed in the neck.");
            NewLineTab("Blood is covering the area around Vincent, and the knife is just out of reach of his outstreached hand. He must have pulled it out before he collapsed.");
            NewLineTab("You stand surveying the scene for a moment. Sure wish someone would clean up all this useless blood. GROSS.");
            NewLineTab("Now that you are standing in front of Vincents body he looks frail. So different from his many portraits.");
            NewLineTab("Enter a) to investigate Vincents body.");
            Console.WriteLine("\tEnter b) to investigate the bar.");
            Console.WriteLine("\tEnter c) to investigate the humidor.");
            Console.WriteLine("\tEnter d) to go back inside.");
            Console.WriteLine("\tEnter x) to go to the Lobby.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    VincentsBody();
                    break;

                case "b":
                    ThePatioBar();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("You open the humidor and the scent of tobacco comes out of it like a cloud. The scent is heavy, it makes the air around it seem empty without it.");
                    NewLineTab("There are 11 cigars sitting in the humidor still. It looks as though Vincent brought out some in case others wanted to join him.");
                    NewLineTab("Glancing over at Vincent you can see that there is a cigar on the ground covered in his blood. It looks as though it was barely smoked.");
                    NewLineTab("Best to leave the cigars be. They will probably take them into evidence and you can ask for one later if you want.");
                    DisplayContinuePromt();
                    SmokingPatio();
                    break;

                case "d":
                    NewLineTab("Looks like its time to go back inside!");
                    DisplayContinuePromt();
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("DOES NOT COMPUTE\n");
                    DisplayContinuePromt();
                    OpenSmokingPatio();
                    break;
            }

        }

        private static void ThePatioBar()
        {
            string menuChoice;
            DisplayHeader("The Patio Bar");
            NewLineTab("Amidst the luxury of the house the patio bar is simple by comparison. There is a large number of liquor bottles, and mixing ingredients, but it is simplistic in nature.");
            NewLineTab("Stepping behind the bar you see a small black book. It is simply labeled DRINKS.");
            NewLineTab("Its obvious by the gentle wear and tear that Vincent has spent a lot of time here. It must be a beautiful view when it isn't pouring rain.");
            NewLineTab("Enter a) to flip through the DRINKS book.");
            NewLineTab("Enter b) to go back to the Patio.");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    DrinksBook();
                    break;

                case "b":
                    SmokingPatio();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Not sure what that means.\n");
                    DisplayContinuePromt();
                    ThePatioBar();
                    break;
            }
        }

        private static void DrinksBook()
        {
            string menuChoice;
            DisplayHeader("DRINKS");
            NewLineTab("Cracking open the DRINKS book you see that it is handwritten by Vincent.");
            NewLineTab("Flipping through you see many drinks that are popular. The Highball, Dubonnet, Ward 8, Bees Knees, Southside Cocktail, Colony Cocktail, Clover Club, The Fallen Angel");
            NewLineTab("Mint Julep, and one just labeled,'The Absinthe Surprise.'");
            NewLineTab("Sadly no recipe to the solution of the murder. Could be a good idea to mix a drink for yourself anyways, to get into the mindset of Vincent of course.");
            NewLineTab("You wouldn't make a drink for yourself because its prohibition and no one is allowed alcohol now, except for the rich of course.");
            NewLineTab("Enter a) to go back to investigating the Patio.");
            Console.WriteLine("\tEnter b) to make The Highball.");
            Console.WriteLine("\tEnter c) to make a Dubonnet.");
            Console.WriteLine("\tEnter d) to make the Ward 8.");
            Console.WriteLine("\tEnter e) to make the Bees Knees.");
            Console.WriteLine("\tEnter f) to have yourself a Southside Cocktail.");
            Console.WriteLine("\tEnter g) to try out the Colony Cocktail.");
            Console.WriteLine("\tEnter h) to have a Clover Club.");
            Console.WriteLine("\tEnter i) to enjoy The Fallen Angel.");
            Console.WriteLine("\tenter j) to have a Mint Julep.");
            Console.WriteLine("\tenter k) for The Absinthe Surprise!");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    SmokingPatio();
                    break;

                case "b":
                    DisplayHeader("The Highball");
                    NewLineTab("Ingredients - Ice - 2 ounces whiskey - Soda");
                    NewLineTab("Fill a highball glass with ice. Add whiskey. Fill the glass to the top with soda.");
                    NewLineTab("This one is just watered down whiskey?");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "c":
                    DisplayHeader("Dubbonet");
                    NewLineTab("Ingredients - Ice - 2 ounces gin - 2 ounces Dubonnet - 1/2 ounce lemon juice - Twist of lemon");
                    NewLineTab("Fill a cocktail shaker with ice. Add gin, Dubonnet, and lemon juice. Shake and strain into a martini glass. Serve garnished with a twist of lemon.");
                    NewLineTab("Sounds like the name of a muddy lake in Northern Michigan or something. Tastes like one too.");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "d":
                    DisplayHeader("Ward 8");
                    NewLineTab("Ingredients - Ice - 2 ounces rye whiskey - 3/4 ounce fresh squeezed lemon juice - 3/4 ounce fresh squeezed orange juice - 3/4 teaspoon grenadine - Seltzer");
                    NewLineTab("In a shaker, combine whiskey, lemon juice, orange juice, and grenadine with ice. Strain into a chilled Collins glass half full of ice. Fill the glass with seltzer.");
                    NewLineTab("Ward 8 is not served garnished.");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "e":
                    DisplayHeader("The Bees Knees");
                    NewLineTab("Ingredients - Ice - 2 ounces gin - 3/4 ounce freshly squeezed lemon juice - 1 / 2 ounce honey simple syrup - Lemon wedge");
                    NewLineTab("In a shaker with ice, combine gin, lemon juice, and simple syrup. Strain into a chilled cocktail glass. Garnish with a lemon wedge.");
                    NewLineTab("This drink will make you have a bee in your bonnet over it!");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "f":
                    DisplayHeader("Southside Cocktail");
                    NewLineTab("Ingredients - Ice - 2 ounces gin - 1 ounce lime juice - 3/4 ounce simple syrup - 1 sprig mint, plus 1 leaf for garnish.");
                    NewLineTab("In a shaker filled with ice, combine gin, lime juice, simple syrup, and mint sprig. Shake and strain into a chilled cocktail glass. Garnish with the mint leaf.");
                    NewLineTab("Oh that one is a sweet one! Wait its all gone already?");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "g":
                    DisplayHeader("Colony Cocktail");
                    NewLineTab("Ingredients - Ice - 1 and 1/2 shots gin - 1/2 shot freshly squeezed pink grapefruit juice - 1/4 shot Luxardo Liqueur - Grapefruit slice");
                    NewLineTab("Fill a cocktail shaker with ice. Add gin, grapefruit juice, and Luxardo. Shake and strain into a chilled cocktail glass. Garnish with a grapefruit slice.");
                    NewLineTab("Grapefruit? WHO EVEN NAMED THIS FRUIT? Pretty nice drink though.");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "h":
                    DisplayHeader("Clover Club");
                    NewLineTab("Ingredients - Ice - 2 ounces gin - 1 egg white - 1/2 ounce raspberry syrup - 1/2 ounce freshly squeezed lemon juice - Twist of lemon.");
                    NewLineTab("In a shaker filled with ice, combine the gin, egg white, raspberry syrup, and lemon juice. Shake and strain into a chilled cocktail glass. Garnish with a twist of lemon.");
                    NewLineTab("Eggs in alcohol? Rich people sure are weird.");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "i":
                    DisplayHeader("The Fallen Angel");
                    NewLineTab("Ingredients - Ice - 2 ounces gin - 1/2 ounce freshly squeezed lime juice -2 dashes white creme de menthe - 1 dash Agnostura bitters - Sprig of mint");
                    NewLineTab("In a cocktail shaker filled with ice, combine the gin, lime juice, creme de menthe, and Agnostura bitters.Shake and strain into a chilled cocktail glass.");
                    NewLineTab("Garnish with a sprig of mint.");
                    NewLineTab("Taking a sip you think, 'Well thats just delightful!'");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "j":
                    DisplayHeader("The Mint Julep");
                    NewLineTab("Ingredients - 10 mint leaves - 1/4 ounce simple syrup - 2 ounces bourbon - Crushed ice - 1 mint sprig for garnish");
                    NewLineTab("In a julep cup, muddle the mint leaves and simple syrup together to release the mint flavors. Fill the cup with crushed ice.");
                    NewLineTab("Pour in the bourbon and stir vigorously until the cup frosts. Mound an additional amount of crushed ice over the top. Garnish with a mint sprig.");
                    NewLineTab("mmmmmmmmmmmm. Minty, refreshing.");
                    DisplayContinuePromt();
                    DrinksBook();
                    break;

                case "k":
                    AbsintheSurprise();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("I don't think that's a drink.\n");
                    DisplayContinuePromt();
                    SmokingPatio();
                    break;
            }

        }

        private static void AbsintheSurprise()
        {
            DisplayHeader("Absinthe Surprise!");
            NewLineTab("Ingredients - The secret bottle behind all others in the shelf. No label. Pour generous amount over ice to chill, drink without ice. Pre-mixed.");
            NewLineTab("You grab the small unlabeled bottle behind all the others and look at it. Doesn't look like much.");
            NewLineTab("Probably can't do that much to you!");
            NewLineTab("You take a swig and OOF that is just srtaight Absinthe. Oh man. That is rough stuff. No wonder he called it a surprise.");
            DisplayContinuePromt();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Green;
            DrinksBook();
        }

        private static void VincentsBody()
        {
            string menuChoice;
            DisplayHeader("Vincents Body");
            NewLineTab("Walking over to Vincents body you see a number of things, he is laying on his back staring up. His mouth is open and his eyes are wide. His neck has a massive wound.");
            NewLineTab("Even if you were not a detective you would know that this is what ended Vincents life. There is a knife that is covered in blood near Vincents hand.");
            NewLineTab("Vincent collapsed hard enough to trap his left arm under himself. He looks like a discarded cloth doll, a marionnette puppet with the string cut.");
            NewLineTab("His suit, even covered in his own blood looks pressed still. Whatever happened here happened quickly and without Vincent fighting back.");
            NewLineTab("On the table next to the chair he was presumably sitting in has a drink on it still.");
            NewLineTab("It is a martini with an olive in the bottom. The oily swirls from the olive create a sheen on the top of the drink. Could probably make your own drink......");
            NewLineTab("Standing over Vincents body you realize that even though he was rich beyond measure, he was only a human. Time to do some investigating.");
            NewLineTab("Enter a) to search Vincents body.");
            Console.WriteLine("\tEnter b) to look at the knife.");
            Console.WriteLine("\tEnter c) to look around the patio more.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("Leaning over you search Vincents body. Starting with his feet you run your hands up his legs. Nothing hidden down there. In his pockets are a number of things though.");
                    NewLineTab("He has a book of matches and a pen in one pocket. Alongside a folded up note. Unfolding the note shows that it was written to Vincent from Tyler L Hsu. It reads as follows.");
                    NewLineTab("'I applaud your business decisions as always Vincent. Our continued prosperity lies in branching out from just railroads. We must encompass all areas where we can make money.'");
                    NewLineTab("'For this reason I have sent you this new plastic pen. With it we can make untold profits by supplying the masses. As they say, the pen is mightier than the sword.'");
                    NewLineTab("'Respectfully yours, Tyler L Hsu.'");
                    NewLineTab("Looks like Vincent was about to branch into the pen business. Interesting? Maybe. Vincent has a billfold with $200 in it as well.");
                    NewLineTab("Searching his jacket reveals a pocketwatch and another pen. The pocketwatch is gold and silver with diamonds inlaid where numbers would be. Must be expensive.");
                    NewLineTab("The pen is another plastic pen. As your hands slide around Vincents chest you realize that he has a pistol hidden under his jacket. That is interesting.");
                    NewLineTab("Why would Vincent be armed with a gun at a dinner with his family? Very strange.");
                    NewLineTab("Looking at Vincents hands reveal that he did not scratch his attacker. There is nothing under the fingernails and no defensive wounds either.");
                    NewLineTab("The wound itself is deep. The knife plunged in hard and fast and did the damage it was intended to do.");
                    NewLineTab("Vincents face reveals little to you. He looks surprised, but that is to be expected when stabbed in the neck. Looking around it doesn't look like theres a ghost anywhere.");
                    DisplayContinuePromt();
                    VincentsBody();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("The knife is covered and surrounded by Vincents blood. The pattering of the rain on the roof lets you concentrate on what you are seeing.");
                    NewLineTab("This is a standard kitchen knife, much like the ones that chef Landed uses regularly. It still has a wicked edge on it, that sparkles in the lightning.");
                    NewLineTab("It looks as though the knife went most of the way through Vincents neck. Pretty brutal way to die. Too bad he wasn't imaginary.");
                    DisplayContinuePromt();
                    VincentsBody();
                    break;

                case "c":
                    DisplayContinuePromt();
                    SmokingPatio();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("The rain pours down outside the patio, whatever it is you're trying to do does nothing.\n");
                    DisplayContinuePromt();
                    SmokingPatio();
                    break;
            }
        }
        #endregion

        #region KATHLEEN VINCENT ROOM
        private static void OpenKathleenVincentRoom()
        {
            string userResponse;
            Console.Clear();
            NewLineTab("You knock on the door and get no response. You can hear snoring coming from inside the room.");
            NewLineTab("Do you want to open the door?");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes" || userResponse == "y" || userResponse == "ok" || userResponse == "yeah that sounds good" || userResponse == "i'm gonna solve this mystery so hard")
            {
                Console.Clear();
                NewLineTab("You open the door and enter.");
                DisplayContinuePromt();
                KathleenVincentRoom();
            }
            else
            {
                Console.Clear();
                NewLineTab("Good plan. Sounds like they really need that sleep.");
                NewLineTab("You turn away from the door.");
                DisplayContinuePromt();
                WWNorthHall();
            }
        }

        private static void KathleenVincentRoom()
        {
            string menuChoice;
            DisplayHeader("Kathleen and Vincents Room");
            NewLineTab("As you enter the room you notice a few things. It is by far the largest bedroom in the house that you have seen so far. It is furnished and decorated nicely.");
            NewLineTab("The thing that catches your eye though is the woman that is asleep in the bed. She is cradling a wine bottle and is snoring away. Tucked in under the blankets. Looks comfy!");
            NewLineTab("There is the obligatory closet and bathroom attached to the bedroom, and inside the room is a long lounging couch, 2 dressers, and a portrait painting of Vincent and Kathleen.");
            NewLineTab("There is also a large bookcase brimming with books, and a side table next to each side of the bed. The curtains are drawn back on the massive window that fills East wall.");
            NewLineTab("Looks like a lot to investigate here!");
            NewLineTab("Enter a) to try and wake up Kathleen");
            Console.WriteLine("\tEnter b) to investigate the bathroom.");
            Console.WriteLine("\tEnter c) to investigate the closet.");
            Console.WriteLine("\tEnter d) to look at the bookcase");
            Console.WriteLine("\tEnter e) to search the dressers.");
            Console.WriteLine("\tEnter f) to leave Vincent and Kathleens room.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You walk over to Kathleen and grab her shoulder and shake her gently. She continues to sleep soundly. You shake her harder. She opens her eyes and looks at you...");
                    NewLineTab("She promptly closes her bleary eyes and starts snoring softly again. Waking a drunk person. Always fun.");
                    NewLineTab("You decide to change tactics and start clapping loudly in front of her face. This causes her to open her eyes again. Even with her eyes open you can tell nothing is there.");
                    NewLineTab("Ope, yep. She closes them again. You give a big sigh. Looks like she isn't waking up.");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("Time to look in the bathroom! You open the cracked door and are absolutely floored by what you see here. Vincent must have made the last room in this hall much smaller.");
                    NewLineTab("This is like a full on roman bathhouse. There is a statue of a roman centurion in the center of the bathroom, standing tall on a pedestal. He is looking into the far distance.");
                    NewLineTab("There is a massive bath, at least 30ft. wide and 10ft. long that encompasses this room. The amount of time it must take to fill this bath is astounding. You count 8 taps.");
                    NewLineTab("Looking wildly out of place is a toilet in the corner that has a small partition curtain around it. Looks like the curtain was a recent addition.");
                    NewLineTab("Seems like a normal incredibly strange bathroom.");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("You open the door to the closet or maybe its a second room? No, its a closet. Just the largest closet you've ever seen. There are racks and racks of clothes here.");
                    NewLineTab("It truly is incredible what rich people spend their money on. It seems inconceivable that anyone could wear all the clothes in this room in just one lifetime.");
                    NewLineTab("Suits, dresses, gowns, slacks, there's even a rack with 20 pairs of overalls. Why does someone need so many overalls?");
                    NewLineTab("You rummage through some of the clothes that were nearby. There is a note in one suit pocket. It simply says, 'JV or MW.' Cryptic.");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

                case "d":
                    Console.Clear();
                    string userResponse;
                    NewLineTab("Ah books. A solid and reliable thing that never changes. Something beautiful and pure. If there is any magic in the world it is books.");
                    NewLineTab("You skim the titles. Mostly historical books, which makes sense. Vincent loved Roman history.");
                    NewLineTab("Nothing strange tucked in with books it looks like, they line up neatly with the back of the bookshelf.");
                    NewLineTab("Should probably get back to the investigation, or maybe just read a few titles? yes or no?");
                    userResponse = Console.ReadLine().ToLower();
                    if (userResponse == "yes")
                    {
                        DisplayContinuePromt();
                        bookTitles();
                    }
                    else
                    {
                        DisplayContinuePromt();
                        KathleenVincentRoom();
                    }
                    break;

                case "e":
                    Console.Clear();
                    NewLineTab("You walk over and open the drawers of the dresser searching through them for any clues. Kathleens dresser has a lot of jewelry inside it.");
                    NewLineTab("Some of it probably cost more than your house. There is some risqué lingerie in one of the drawers but nothing that seems suspicious.");
                    NewLineTab("You walk over and look through Vincents dresser and search through it for clues. There is a lot of pistols inside it. Someone loved guns!");
                    NewLineTab("As you keep searching in Vincents drawer you come across some risqué lingerie. Huh. Forward thinking man it seems.");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

                case "f":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Nope, that doesn't do anything here.\n");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;
            }
        }
        #endregion

        #region BOOKS
        private static void bookTitles()
        {
            string menuChoice;
            Console.Clear();
            DisplayHeader("Book Titles!");
            NewLineTab("You can take a few minutes to read some book titles right? Must be something interesting here.");
            NewLineTab("Your eyes start to skim over the titles, 'Twenty Years at Hull House,' by Jane Addams.");
            NewLineTab("'Peter and Wendy,' by J. M. Barrie.");
            NewLineTab("'Riders of the Purple Sage,' by Zane Grey.");
            NewLineTab("'Moulding the Mind,' by John Velis.");
            NewLineTab("'Tarzan of the Apes,' by Edgar Rice Burroughs.");
            NewLineTab("'O Pioneers!,' by Willa Cather");
            NewLineTab("'The Interpretation of Dreams,' by Sigmund Freud");
            NewLineTab("'Tender Buttons,' by Gertrude Stein");
            NewLineTab("'The Magnificent Ambersons,' by Booth Tarkington");
            NewLineTab("'The Wild Swans at Coole ,' by W. B. Yeats ");
            NewLineTab("'Electricity and You a Guide to Engineering,' by Micajah Worden");
            NewLineTab("'Winesburg, Ohio,' by Sherwood Anderson");
            NewLineTab("Well thats an interesting looking bunch of books!");
            NewLineTab("Enter a) to stop looking at the bookshelf.");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

                case "pull electricity and you a guide to engineering":
                    PulledTheCorrectBook();
                    break;

                case "grab electricity and you a guide to engineering":
                    PulledTheCorrectBook();
                    break;

                case "pick up electricity and you a guide to engineering":
                    PulledTheCorrectBook();
                    break;

                case "pick electricity and you a guide to engineering":
                    PulledTheCorrectBook();
                    break;

                case "pull moulding the mind":
                    PulledTheCorrectBook();
                    break;

                case "grab moulding the mind":
                    PulledTheCorrectBook();
                    break;

                case "pick moulding the mind":
                    PulledTheCorrectBook();
                    break;

                case "moulding the mind":
                    PulledTheCorrectBook();
                    break;

                case "electricity and you a guide to engineering":
                    PulledTheCorrectBook();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Huh nothing happens. Does seem strange that theres the ability to make choices instead of just being sent back to the room............\n");
                    DisplayContinuePromt();
                    KathleenVincentRoom();
                    break;

            }
        }

        private static void PulledTheCorrectBook()
        {
            string userResponse;
            Console.Clear();
            NewLineTab("You pull the book and the bookshelf slides into the wall silently, until it slides behind the wall next to where it was.");
            NewLineTab("There is a passageway in front of you now. You are able to walk directly into the wall. It is quite cramped by the look of it.");
            NewLineTab("Seems weird that theres a secret door here. Probably not linked to anything with the case though, you could put the book back and turn around.");
            NewLineTab("Put the book back? [y/n]");
            userResponse = Console.ReadLine().ToLower();

            if (userResponse == "y" || userResponse == "yes" || userResponse == "yeah")
            {
                Console.Clear();
                NewLineTab("Of course you put the book back. THAT WOULD BE CRAZY TO GO INTO A SECRET PASSAGE.");
                DisplayContinuePromt();
                KathleenVincentRoom();
            }
            else
            {
                Console.Clear();
                NewLineTab("Onward and inward it seems. To go where few have gone before.");
                DisplayContinuePromt();
                THESECRETPASSAGE();
            }
        }

        #endregion

        #region SECRET PASSAGE
        private static void THESECRETPASSAGE()
        {
            Console.Clear();
            NewLineTab("You walk behind the bookshelf into the secret passage. Excitement pounding in your ears. Now this is a clue!");
            NewLineTab("Continuing down the passage for about 10 feet it curves to the right, as you get there you look around the corner to see...............");
            NewLineTab("A brick wall. Looks like the secret passage was never finished. In fact theres a note on the floor in front of the wall. Picking it up you see it says...");
            NewLineTab("Ran out of secret passage bricks, be back soon. -Russell A. 4/15/1910");
            NewLineTab("Well you don't know who this Russell guy is but looks like he needs to manage his time better.");
            DisplayContinuePromt();
            KathleenVincentRoom();

        }
        #endregion

        #region VICTORS ROOM
        private static void OpenVictorRoom()
        {
            Console.Clear();
            NewLineTab("You knock on the first door on the right and a man in his mid fifties opens it. He looks exhausted. His shirt is untucked and his hair is a mess.");
            NewLineTab("You get the impression that he looks like this most of the time. He sighs and lets you in his room.");
            DisplayContinuePromt();
            VictorsRoom();
        }

        private static void VictorsRoom()
        {
            string menuChoice;
            DisplayHeader("Victors Room");
            NewLineTab("Victors room is sparse. It looks as though he had it redecorated. The walls are painted white and there is only a twin sized bed and a dresser in the room.");
            NewLineTab("The closet door is ajar, and the bathroom door is closed. Victor is sitting on the corner of the bed and watching you intently.");
            NewLineTab("He gestures at the room, 'Behold, my Kingdom.' He says to you.");
            NewLineTab("Enter a) to ask Victor what he knows.");
            Console.WriteLine("\tEnter b) to check the closet.");
            Console.WriteLine("\tEnter c) to check the bathroom.");
            Console.WriteLine("\tEnter d) to return to the hall.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'What do I know? Why don't you ask my brother Barty? The leader of my fathers legacy? Or Peg his favorite child?' He shakes his head as he looks down.");
                    NewLineTab("'You're wasting your time asking me anything. Just like my father did when he tried to make me his protege.' He looks directly at you.");
                    NewLineTab("'Do you know what it feels like to be a FAILURE your entire life? I could never do anything right. Now I can't even help you solve his murder. I know nothing.'");
                    NewLineTab("'You might be able to find a will though?' He says thoughtfully. 'Maybe it will name Ivy the sole beneficiary and we will know that she killed him for his money.'");
                    NewLineTab("He smirks at you, 'Wouldn't that be something if I guessed the murderer? Well. I don't have anything else for you. Can you leave me be please?'");
                    DisplayContinuePromt();
                    VictorsRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("The closet is mostly empty. A few suits hang limply on hangers. A quick cursory search of them turns nothing up either.");
                    NewLineTab("There is one interesting thing. A baseball bat is leaning in the corner of the closet. It looks like someone has been routinely hitting rocks with this bat.");
                    NewLineTab("The bat is so damaged its a wonder that it even still holds it form. What a strange thing to keep.");
                    DisplayContinuePromt();
                    VictorsRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("Scanning the bathroom quickly you see the usual, the toilet, shower, tub and sink.");
                    NewLineTab("The bathroom is tidy, the shower curtain is pulled back to reveal a plethora of shampoos and hair tonics. It looks like someone is afraid of going bald.");
                    NewLineTab("The mirror cabinet has more hair tonics and something called 'Dr. VirileMan's Liquid for MEN.' Whatever that is.");
                    NewLineTab("No smoking gun in here, or smoking knife as the case would be.");
                    DisplayContinuePromt();
                    VictorsRoom();
                    break;

                case "d":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("'HA!' Says Victor. Looks like that doesn't do anything.\n");
                    DisplayContinuePromt();
                    WWNorthHall();
                    break;

            }
        }
        #endregion

        #region BARTYS ROOM
        private static void OpenBartyRoom()
        {
            Console.Clear();
            NewLineTab("You go to knock on the door when it opens. A man is standing in the doorway and sticks his hand out to you. 'Barty Helmsberg. Come in Detective.'");
            NewLineTab("He turns and goes into his room and you follow.");
            NewLineTab("'He points around the room. Bathroom, closet, bed, room itself. Theres not much difference in the rooms in this house. Don't want to bore you too much.'");
            NewLineTab("'Go ahead and look around and lets talk.'");
            DisplayContinuePromt();
            BartyRoom();

        }


        private static void BartyRoom()
        {
            string menuChoice;
            DisplayHeader("Barty's Room");
            NewLineTab("Looking around the room you can tell immediately that Barty doesn't spend much time here. The bed has been used but everything else is basically brand new.");
            NewLineTab("There is only one suit in the closet and the bathroom has nothing but toilet paper, a towel, and a toothbrush in it besides the usual appliances.");
            NewLineTab("Its almost as if some benevolent god didn't want you to go insane inspecting the same things over and over again.");
            NewLineTab("Enter a) to ask Barty what he knows.");
            Console.WriteLine("\tEnter b) to return to the hallway.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'What I know is that my father is dead. What I don't know is who did it. So if you want to tell me that, I would appreciate it.' He turns away from you.");
                    NewLineTab("'Business will take a hit for a little while, but most everyone knows I've been in charge for years now. Dad was just a figurehead for the investors.'");
                    NewLineTab("He turns back, 'Whoever killed my father stuck a knife into the side of his neck. It killed him quickly. He bled out in seconds is what the paramedic said.'");
                    NewLineTab("'Now if you'll excuse me I need to finish these memo's, write a piece for the paper and ensure that my fathers legacy doesn't die with him.'");
                    NewLineTab("He waves his arm at you dismissively.");
                    DisplayContinuePromt();
                    BartyRoom();
                    break;

                case "b":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Not gonna do anything with that.\n");
                    DisplayContinuePromt();
                    WWNorthHall();
                    break;
            }
        }
        #endregion

        #region HUMPHREY AND PEG
        private static void HumphreyAndPeg()
        {
            DisplayHeader("Humphrey and Peg");
            NewLineTab("You knock on the second door and it is opened slightly by a large man in a nice suit. He steps out into the hall and towers over you. He shuts the door behind him.");
            NewLineTab("'Hello Detective. I know who you are, and you obviously know that I am Humphrey. Before we get started you should know that I know the laws around here.'");
            NewLineTab("'As a lawyer I can state what I want to and then if you want to follow up with me you can get a warrant.'");
            NewLineTab("'My wife and I had nothing to do with the murder of her father. You may not search our room as it is a private residence. I have no information for you beyond this.'");
            NewLineTab("Humphrey retreats back into his room and shuts the door. 'If you try to get anything else out of me you'll hear the same thing!' He shouts through the door.");
            DisplayContinuePromt();
            WWNorthHall();
        }
        #endregion

        #region VINNYS ROOM
        private static void OpenVinnysRoom()
        {
            Console.Clear();
            NewLineTab("You knock on the door and hear someone get up from their bed. Vinny opens the door bleary eyed and looks at you. 'Ah it's you. Come in.' He says to you and opens the door.");
            NewLineTab("He climbs back onto the bed and sits on it cross legged while he watches you. 'Can we do this quickly? I was sleeping.' He tells you.");
            DisplayContinuePromt();
            VinnysRoom();
        }

        private static void VinnysRoom()
        {
            string menuChoice;
            DisplayHeader("Vinny's Room");
            NewLineTab("Vinny is sitting on his bed watching you. His room is clean enough for a young man. He has a closet and a bathroom in this room.");
            NewLineTab("You can see that Vinny has a lot of memorabilia from the War to End All Wars. He was too young to be in the War but must have an interest in it.");
            NewLineTab("The curtains are pulled back and the crackling lightning sometimes flashes light into the room.");
            NewLineTab("'I like the rain,' Vinny says without taking his eyes off you as you look around his room.");
            NewLineTab("Enter a) to ask Vinny what he knows.");
            Console.WriteLine("\tEnter b) to look in the closet.");
            Console.WriteLine("\tEnter c) to look in the bathroom.");
            Console.WriteLine("\tEnter d) to leave Vinny's room.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'What do you expect to hear from me? A full confession? I didn't kill my grandfather. I loved him and loved being here. This place is my home.'");
                    NewLineTab("'Talk with my step mother Kathleen. She spends the most time with him. Never liked her anyways.'");
                    NewLineTab("'Some people may say we fight alot, but you put two smart people in a room and that will happen. He always wanted me to,' he makes air quotes, 'be something.'");
                    NewLineTab("'Isn't existence enough though? Why do I have to be more than I am? I didn't ask to be born, and I want to do what makes me happy.'");
                    DisplayContinuePromt();
                    VinnysRoom();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("You open the closet door to reveal...... Clothes. Very nice clothes. Looks like Vinny likes to dress up fancy for whatever it is he does in his free time.");
                    NewLineTab("Vinny has a collection of hats in his closet, fedora's, newsboy caps, and boater hats. Very fashionable.");
                    NewLineTab("Honestly there doesn't seem to be much to look at in here unless you like expensive clothes.");
                    DisplayContinuePromt();
                    VinnysRoom();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The bathroom is very clean for a young man. Hardly any pee on the floor at all. Maybe Vinny sits to pee.");
                    NewLineTab("There is a toilet, sink, tub, and shower in this bathroom, and the wallpaper is covered in Curtiss 18 fighter planes, more commonly known as Wasps.");
                    NewLineTab("Poking around the bathroom you find that there is a few empty wine bottles behind the tub, not too unusual. Although there is a knife from the dining room there too.");
                    DisplayContinuePromt();
                    VinnysRoom();
                    break;

                case "d":
                    WWNorthHall();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Vinny looks at you like you're CRAZY!\n");
                    DisplayContinuePromt();
                    WWNorthHall();
                    break;
            }
        }
        #endregion

        #endregion

        #region OFFICER MIKE DONAUGH
        private static void LoungingOfficer()
        {
            string menuChoice;

            DisplayHeader("Officer Mike Donaugh");
            Console.WriteLine("\tThe man stands up and says 'Officer Mike Donaugh. How can I help?'");
            NewLineTab("Officer Donaugh looks tired, judging by the cigarette butts around him he has been sitting and smoking for hours.");
            NewLineTab("'I can tell you about the house if you'd like, or would you rather hear about the suspects?'");
            NewLineTab("Enter a) to hear about the house.");
            Console.WriteLine("\tEnter b) to hear about the suspects.");
            Console.WriteLine("\tEnter c) to return to the Lobby.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    HouseDescription();
                    break;

                case "b":
                    DonaughSuspects();
                    break;

                case "c":
                    MansionLobby();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Mike looks at you strangely. 'I have no idea what that means.'");
                    DisplayContinuePromt();
                    LoungingOfficer();
                    break;
            }

        }
        #endregion

        #region HOUSE DESCRIPTION
        private static void HouseDescription()
        {
            string menuChoice;
            DisplayHeader("Description of the Mansion");
            Console.WriteLine("\tOfficer Donaugh resumes sitting, 'well lets see...'");
            NewLineTab("'Theres a lot of places in this Mansion. Why don't I give you a list and you pick?'");
            NewLineTab("He hands you a list, it looks shockingly similar to the list below.");
            NewLineTab("Enter a) to hear about the outside of the house.");
            Console.WriteLine("\tEnter b) to hear about the Lobby.");
            Console.WriteLine("\tEnter c) to hear about the Understairs.");
            Console.WriteLine("\tEnter d) to hear about the Library.");
            Console.WriteLine("\tEnter e) to hear about the Dining Room.");
            Console.WriteLine("\tEnter f) to hear about the Fancy Staircase.");
            Console.WriteLine("\tEnter g) to hear about the Upstairs.");
            Console.WriteLine("\tEnter h) to be done with Officer Donaugh...... for now.");

            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'Well outside the house isn't much. There's an old graveyard in the Northwest corner of the yard.'");
                    NewLineTab("'There is also a Gardeners hut at the Northeast corner of the yard.'");
                    NewLineTab("'You could probably look in the windows from outside but it is wet out there!'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("'The lobby is where we will call everyone once you have solved the murder!'");
                    NewLineTab("'The paintings are interesting at least, and don't seem haunted AT ALL.'");
                    NewLineTab("'You can leave out the front door, or go to the Library located on the east wall.'");
                    NewLineTab("'You can go to the Dining Room on the west wall, or the Servants Understairs.'");
                    NewLineTab("'You could go up those fancy stairs to the bedrooms and servants rooms.'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("'The Understairs are used for staging areas for the servants to travel quickly and out of the way downstairs.'");
                    NewLineTab("'It leads to the backdoor to the Mansion as well. Generally it is not used by anyone but staff.'");
                    NewLineTab("'Once the body was discovered the servants were shut in their quarters.'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "d":
                    Console.Clear();
                    NewLineTab("'The Library looks really nice! A fireplace, bookshelves on all the walls, it's like someone made it up!'");
                    NewLineTab("'We left Officer Ed Richards in there. He loves books.'");
                    NewLineTab("'He is watching Joffrey the Butler who is also in the Library.'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "e":
                    Console.Clear();
                    NewLineTab("'Oh the dining room! That connects to the kitchen area. I think the chef Landen is in there right now.'");
                    NewLineTab("'We tried to keep most of the staff where they were when we arrived so as not to let anyone out of our sights.'");
                    NewLineTab("'He could probably make some snacks or something for us. What do rich people eat?'");
                    NewLineTab("'Anyways the dining room is HUGE and beautiful. Really something to see. Words could never describe it properly.'");
                    NewLineTab("'Good thing you're a flesh and blood human that can interact with the world.'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "f":
                    Console.Clear();
                    NewLineTab("'The fancy stairs! Those are very nice, and very fancy.'");
                    NewLineTab("'The stairs are actually two sets of stairs. They curve gently down from a staging area that also leads to a balcony.'");
                    NewLineTab("'The right set is for going up, and the left set is for going down. Not that theres a sign or anything.'");
                    NewLineTab("'Also its not against the law to go up the left stairs so you live your life the way you want!'");
                    NewLineTab("'From the staging area there are two more sets of stairs that follow the wall on either side of the balcony doors to the upper floor.'");
                    NewLineTab("'I haven't been upstairs yet but thats where the deceased is.'");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

                case "g":
                    UpstairsDescription();
                    break;

                case "h":
                    MansionLobby();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Not familiar with that boss!");
                    DisplayContinuePromt();
                    HouseDescription();
                    break;

            }

        }

        private static void UpstairsDescription()
        {
            Console.Clear();
            NewLineTab("'Oh uhhhh the upstairs? I haven't been up there yet. I know theres multiple rooms, and most of the people are up there.'");
            NewLineTab("'Lets see, there's all the bedrooms up there, and the smoking balcony, which is where the deceased is.'");
            NewLineTab("'Probably lots of cool stuff up there!'");
            NewLineTab("Officer Donaugh smiles brightly at you.");
            DisplayContinuePromt();
            HouseDescription();
        }
        #endregion

        #region DONAUGH SUSPECTS LIST
        private static void DonaughSuspects()
        {
            string menuChoice;
            Console.Clear();
            NewLineTab("Officer Donaugh puts out a cigarette on the bottom of his shoe.");
            NewLineTab("'Which person do you want to hear about Chief?'");
            Console.WriteLine("\n\tEnter a) to hear about Vincent's Wife Kathleen");
            Console.WriteLine("\tEnter b) to hear about Vincent's oldest son Victor");
            Console.WriteLine("\tEnter c) to hear about Vincent's youngest son Barty");
            Console.WriteLine("\tEnter d) to hear about Vincent's daughter Peg");
            Console.WriteLine("\tEnter e) to hear about Vincent's son in law Humphrey");
            Console.WriteLine("\tEnter f) to hear about Vincent's grandson Vinny");
            Console.WriteLine("\tEnter g) to hear about Vincent's maid Ivy");
            Console.WriteLine("\tEnter h) to hear about Vincent's gardener Pete");
            Console.WriteLine("\tEnter i) to hear about Vincent's butler Joffrey");
            Console.WriteLine("\tEnter j) to hear about Vincent's chef Landen");
            Console.WriteLine("\tEnter k) to hear about Vincent himself");
            Console.WriteLine("\tEnter l) to stop talking with Officer Donaugh.");

            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    DSKathleenDescription();
                    break;

                case "b":
                    DSVictorDescription();
                    break;

                case "c":
                    DSBartyDescription();
                    break;

                case "d":
                    DSPegDescription();
                    break;

                case "e":
                    DSHumphreyDescription();
                    break;

                case "f":
                    DSVinnyDescription();
                    break;

                case "g":
                    DSIvyDescription();
                    break;

                case "h":
                    DSPeteDescription();
                    break;

                case "i":
                    DSJoffreyDescription();
                    break;

                case "j":
                    DSLandenDescription();
                    break;

                case "k":
                    DSVincentDescription();
                    break;

                case "l":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Please enter a letter from the menu choices!\n");
                    DisplayContinuePromt();
                    break;
            }
        }
        private static void DSVincentDescription()
        {

            DisplayHeader("Who was Vincent Helmsberg?");
            NewLineTab("Vincent was a railroad Baron who became rich beyond most peoples dreams.");
            NewLineTab("Vincent was 86 years old at the time of his death, and was in fine health.");
            NewLineTab("The evening Vincent was killed, he had his family over for dinner.");
            NewLineTab("This is not an unusual thing to have his family come for dinner and stay the night.");
            NewLineTab("Vincent has been known to give quite a bit of money to charity.");
            NewLineTab("Vincent enjoyed cigars and was found dead on his smoking patio.");
            NewLineTab("We know Vincent was killed with a knife to the side of his neck.");
            DonaughSuspects();

        }

        private static void DSLandenDescription()
        {


            DisplayHeader("Who is Landen?");
            Console.WriteLine("\tLanden has been Vincent's live in chef for the last 52 years.");
            NewLineTab("Landen and Vincent have had a good relationship as far as people are aware.");
            NewLineTab("Although he is one of the few people who would argue with Vincent.");
            NewLineTab("Landen and Vincent are close in age, Landen is 81.");
            NewLineTab("There are many sharp knives in the kitchen. Landen kept them razer sharp.");
            DonaughSuspects();

        }

        private static void DSJoffreyDescription()
        {
            DisplayHeader("Who is Joffrey?");
            NewLineTab("Joffrey is Vincents butler, and has only worked for him for the last 10 years.");
            NewLineTab("Joffrey replaced Ornathal after he passed away 10 years ago.");
            NewLineTab("It has been rumored that Joffrey and Vincent never got along as well as Vincent and Ornathal.");
            NewLineTab("That being said, it seems as though Joffrey was at least an adequate replacement to last 10 years.");
            DonaughSuspects();
        }

        private static void DSPeteDescription()
        {
            DisplayHeader("Who is Pete?");
            NewLineTab("Pete is Vincents Gardener. He was the caretaker of this land before Vincent bought it.");
            NewLineTab("Pete was living in a shack he had built himself out of scraps that he scavenged.");
            NewLineTab("Vincent was going to have Pete forcibly removed from the property, but when he met Pete he realized he was a veteran.");
            NewLineTab("Pete had fought in the White River War and it had repercussions upon his mental health.");
            NewLineTab("When the house was built in 1881 Pete stayed in the Gardeners hut, but eventually accepted a room inside the house.");
            NewLineTab("Pete meticulously cares for the grounds, and takes the landscaping very seriously.");
            DonaughSuspects();
        }

        private static void DSIvyDescription()
        {
            DisplayHeader("Who is Ivy?");
            NewLineTab("Ivy is Vincents maid, and has held this role for the past 20 years.");
            NewLineTab("Ivy was the daughter of an old friend of Vincents who died many years ago. Ivy was too young to marry and Vicent hired her to be his maid.");
            NewLineTab("She arrived at the house at the age of 15, and continued her studies under Vincents tutelage.");
            NewLineTab("She has not married as of yet, and seemingly has no suitors. She spends her time cleaning and taking care of the house, and her free time reading.");
            DonaughSuspects();
        }

        private static void DSVinnyDescription()
        {
            DisplayHeader("Who is Vinny?");
            NewLineTab("Vinny is Vincents only grandson, and his namesake.");
            NewLineTab("20 years old now, Vinny has not pursued higher education, or even a factory job.");
            NewLineTab("Vinny lives off of his families money, and spends quite a bit of time with Vincent at the Mansion.");
            NewLineTab("Vincent and Vinny have been known to have loud arguments that get quite heated, but Vincent loved Vinny unswervingly.");
            NewLineTab("Vincent made no effort to hide the fact that he thought Vinny needed to get an education and a job.");
            DonaughSuspects();
        }

        private static void DSHumphreyDescription()
        {
            DisplayHeader("Who is Humphrey?");
            NewLineTab("Humphrey is Peg's husband and the father of Vinny. He is in his early 50's and is a lawyer.");
            NewLineTab("Humphrey has never fit in well with Vincent or the other Helmsbergs as he came from a simple farming community.");
            NewLineTab("Despite this, he became a very powerful man and an intimidating lawyer.");
            NewLineTab("He does not like to be helped by the staff, and finds the Mansion to be a horrible waste of resources.");
            DonaughSuspects();
        }

        private static void DSPegDescription()
        {
            DisplayHeader("Who is Peg?");
            NewLineTab("Peg is Vincents only daughter and was the light of his life.");
            NewLineTab("She was doted upon by her father and was given an education, something that was not expected in the late 1800's.");
            NewLineTab("Peg has her fathers intellect and his fiery passion, but she also has her mothers strong resolve.");
            NewLineTab("She married Humphrey against her fathers wishes, and he was never happy about that.");
            NewLineTab("Peg doesn't let anyone tell her what to do, except Vinny. She turns a blind eye to anyhting that he does.");
            DonaughSuspects();
        }

        private static void DSBartyDescription()
        {
            DisplayHeader("Who is Barty?");
            NewLineTab("Barty is Vincents youngest son, and the recipient of his Railroad Empire.");
            NewLineTab("He took over operation from his older brother Victor soon after he left school.");
            NewLineTab("Many people thought that Victor, or Vincent would be upset about this, but Barty is smart and driven.");
            NewLineTab("He rarely comes around the Mansion anymore as he is busy running the business.");
            NewLineTab("It is rumored that he is working on buying and installing telegram services.");
            DonaughSuspects();
        }

        private static void DSVictorDescription()
        {
            DisplayHeader("Who is Victor?");
            NewLineTab("Victor is Vincents oldest son, and was groomed to take over the business before Barty took it over from him.");
            NewLineTab("Victor spends most of his time down river at the family stables where he cares for the horses.");
            NewLineTab("He can also be found at the offices when he is asked to be, but doesn't care to be there anymore.");
            DonaughSuspects();
        }

        private static void DSKathleenDescription()
        {
            DisplayHeader("Who is Kathleen?");
            NewLineTab("Kathleen is Vicents second wife and is 30 years his younger. They have been married now for 10 years.");
            NewLineTab("She is a Baroness from France who after she became a widow sold everything and moved to America.");
            NewLineTab("Kathleen is a jealous person and likes to have Vincents attention whenever they were together.");
            NewLineTab("She is not the mother to any of the children, in fact she is younger than Victor.");
            NewLineTab("Kathleen enjoys socializing and will attend any high class function that she can be seen at.");
            DonaughSuspects();
        }
        #endregion

        #region DINING ROOM
        private static void DiningRoomPartOne()
        {
            NewLineTab("You open the West doors to a magnificent dining area. As you walk in the door clicks quietly behind you.");
            DisplayContinuePromt();
            DiningRoom();
        }

        private static void DiningRoom()
        {
            string menuChoice;
            DisplayHeader("The Dining Room");
            NewLineTab("As you glance around the dining room you realize its less of a dining area and more of an event area. Of course there is a dining table.");
            NewLineTab("This is only one of the eye catching fixtures in this room though. A stage on the west wall has string instruments and a piano waiting.");
            NewLineTab("In front and around this stage is a dance floor with an absolutely gorgeous wooden floor. On the ceiling are two matching chandeliers to the one in the lobby.");
            NewLineTab("In the corners of the south wall are marble statues of Roman Emperors, which flank a floor to ceiling window.");
            NewLineTab("The table itself is at least 30 feet long and draped with a shockingly white table cloth from end to end. An unbroken 30 foot table cloth.");
            NewLineTab("On the north wall is 2 doors that presumably lead to the Kitchen. You can hear faint noises eminating from within.");
            NewLineTab("Enter a) to inspect the table.");
            Console.WriteLine("\tEnter b) to head to the kitchen.");
            Console.WriteLine("\tEnter c) to return to the Lobby");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You walk over to the table, and notice a few things right away. There is a huge red wine stain in front of one of the plates.");
                    NewLineTab("Getting this out would be improbable. What a waste of such nice cloth. There are still remnants of dinner on the table as well.");
                    NewLineTab("Dessert is scattered around on a few plates still. You count the place settings, 7. Everyone accounted for at dinner time it seems.");
                    NewLineTab("Looks like there was quite a bit of wine drank tonight, you count 5, no 6 bottles of wine empty. Plus some cocktail glasses. Looks like a party.");
                    NewLineTab("As you look over the table you notice something. A knife is missing from one of the placings. Interesting....");
                    DisplayContinuePromt();
                    DiningRoom();
                    break;

                case "b":
                    TheKitchen();
                    break;

                case "c":
                    MansionLobby();
                    break;

                case "inspect statues":
                    NewLineTab("The statues call to you. They are beautiful, marvelous things. Each one has a small plaque on the wall next to it.");
                    NewLineTab("The statue in the South East corner is a marble replica of the Orator, according to the plaque. An ancient and well known statue.");
                    NewLineTab("The statue in the South West corner is 'Augustus of Prima Porta,' according to its plaque. ");
                    NewLineTab("According to its plaque, this is a full-length portrait statue of Augustus Caesar, the first emperor of the Roman Empire.");
                    NewLineTab("The marble statue stands 2.08 meters tall and weighs 1,000 kg. The statue was discovered on April 20, 1863. It is currently on loan from Pope Pious the XI");
                    NewLineTab("The amount of money one would have to spend to get a real Roman statue on loan from the Pope is incalculable.");
                    DisplayContinuePromt();
                    DiningRoom();
                    break;

                case "look at statues":
                    NewLineTab("The statues call to you. They are beautiful, marvelous things. Each one has a small plaque on the wall next to it.");
                    NewLineTab("The statue in the South East corner is a marble replica of the Orator, according to the plaque. An ancient and well known statue.");
                    NewLineTab("The statue in the South West corner is 'Augustus of Prima Porta,' according to its plaque. ");
                    NewLineTab("According to its plaque, this is a full-length portrait statue of Augustus Caesar, the first emperor of the Roman Empire.");
                    NewLineTab("The marble statue stands 2.08 meters tall and weighs 1,000 kg. The statue was discovered on April 20, 1863. It is currently on loan from Pope Pious the XI");
                    NewLineTab("The amount of money one would have to spend to get a real Roman statue on loan from the Pope is incalculable.");
                    DisplayContinuePromt();
                    DiningRoom();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Sorry pal, that doesn't compute.");
                    DisplayContinuePromt();
                    DiningRoom();
                    break;
            }
        }
        #endregion

        #region THE KITCHEN
        private static void TheKitchen()
        {
            string menuChoice;
            DisplayHeader("The Kitchen");
            NewLineTab("The kitchen is empty save for one person. An elderly man is cleaning some pots out and looks up at you.");
            NewLineTab("'I didn't kill the man I've known for almost 60 years so you can go interrogate someone else. I don't need it.'");
            NewLineTab("Your eyes wander around the Kitchen catching an incredible array of knives. Landen must be some sort of collector.");
            NewLineTab("Knowing that Vincent was killed with a knife makes this look bad. These knives are obviously sharp enough to kill someone easily.");
            NewLineTab("Enter a) to ask Landen what he knows.");
            Console.WriteLine("\tEnter b) to leave the kitchen.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'Didn't I make it clear that I didn't do it? Vincent and I have known each other since before you were even a thought!' He turns away from you for a moment.");
                    NewLineTab("He turns back to you, 'Fine, here's what I know. Vincent and Vinny had a fight earlier in the night. A big one. Vinny smashed some glasses and stormed away.'");
                    NewLineTab("'I'm not saying he did it but you might as well know that.' He turns away from you, making it clear by putting most of his upper body in a pot that he is done with teh conversation.");
                    DisplayContinuePromt();
                    TheKitchen();
                    break;

                case "b":
                    DiningRoom();
                    break;

                case "inspect knives":
                    Console.Clear();
                    NewLineTab("You look around at the knives and notice that Landen takes meticulous care of them. They are razor sharp and all seem to be in order. They hang from a magnet on the wall.");
                    NewLineTab("Just looking at them makes you think it would be easy to kill someone with one of these knives.");
                    DisplayContinuePromt();
                    TheKitchen();
                    break;

                case "inspect the knives":
                    Console.Clear();
                    NewLineTab("You look around at the knives and notice that Landen takes meticulous care of them. They are razor sharp and all seem to be in order. They hang from a magnet on the wall.");
                    NewLineTab("Just looking at them makes you think it would be easy to kill someone with one of these knives.");
                    DisplayContinuePromt();
                    TheKitchen();
                    break;

                case "look at knives":
                    Console.Clear();
                    NewLineTab("You look around at the knives and notice that Landen takes meticulous care of them. They are razor sharp and all seem to be in order. They hang from a magnet on the wall.");
                    NewLineTab("Just looking at them makes you think it would be easy to kill someone with one of these knives.");
                    DisplayContinuePromt();
                    TheKitchen();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Please enter a letter from the menu choices!\n");
                    DisplayContinuePromt();
                    break;
            }
        }
        #endregion

        #region THE LIBRARY
        private static void LibPartOne()
        {
            NewLineTab("You open the doors into the Library and see an Officer stand up from a chair very quickly. He clears his throat and nods at you.");
            NewLineTab("His body posture says, 'I wasn't sleeping!'");
            DisplayContinuePromt();
            Library();
        }


        private static void Library()
        {
            string menuChoice;
            DisplayHeader("The Library");
            NewLineTab("The library is incredible. It goes on for the length of the Mansion. It is truly a work of art. The walls are covered in bookshelves that reach the ceiling.");
            NewLineTab("They are only broken by the windows that would let in an impressive amount of light. The library has seating scattered around it everywhere.");
            NewLineTab("Desks, lounging chairs and couches, rocking chair in one corner. Just like a whole bunch of chairs!");
            NewLineTab("There is a main desk that is more impressive than its counterparts at the far end of the Library. It was obviously Vincents workspace.");
            NewLineTab("You see a man sitting with his back to you in front of the desk. He seems to be staring at the desk unmoving.");
            NewLineTab("Time to be a detective!");
            NewLineTab("Enter a) to talk with the officer.");
            Console.WriteLine("\tEnter b) to talk with the man by the desk.");
            Console.WriteLine("\tEnter c) to inspect the bookshelves.");
            Console.WriteLine("\tEnter d) to inspect Vincents desk.");
            Console.WriteLine("\tEnter e) to return to the Lobby.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You approach the Officer and he says, 'Not much to report boss. Thats Joffrey the butler over there, he was sitting in here when we arrived so we left him there.'");
                    NewLineTab("'No one else has been in or out and I haven't really seen him move much.'");
                    NewLineTab("He leans in conspiratorially, 'Who needs so many books anyways? Gives me the creeps knowing someone is just reading all the time.' He shakes his head.");
                    DisplayContinuePromt();
                    Library();
                    break;

                case "b":
                    JoffreyInterrogation();
                    break;

                case "c":
                    Console.Clear();
                    NewLineTab("The number of books is staggering. Your eyes begin to glaze over as you walk along looking at the titles.");
                    NewLineTab("It looks as though Vincent was obsessed with Shakespeare, there is a whole bookshelf dedicated to volumes of his work.");
                    NewLineTab("He was also very interested in American and Roman history, and you see a book titled, 'Parallels between America and Rome by Vincent Helmsberg.'");
                    NewLineTab("Philosophy, art, architecture, culture, and books on trains. SO MANY books on trains. That makes sense though as his fortune was founded on the rail systems.");
                    NewLineTab("There are more books here than could be read in a single lifetime. All under one roof. A treasure trove of knowledge.");
                    DisplayContinuePromt();
                    Library();
                    break;

                case "d":
                    VincentsDesk();
                    break;

                case "e":
                    MansionLobby();
                    break;

                case "x":
                    MansionLobby();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("UNABLE TO UNDERSTAND WHAT YOU MEAN.");
                    DisplayContinuePromt();
                    Library();
                    break;

            }
        }

        #region VINCENTS DESK
        private static void VincentsDesk()
        {
            string menuChoice;
            DisplayHeader("Vincents Desk");
            NewLineTab("You slide into the hard wooden chair behind Vincents desk, this causes Joffrey to look up at you, but then he returns his gaze to his blood soaked gloves.");
            NewLineTab("On top of his desk is a plethora of work papers, bills, and correspondance. Skimming through it, it all seems normal enough.");
            NewLineTab("There is a combination lock on the drawers to the desk. It seems as though Vincent spent a lot of money to keep this shut.");
            NewLineTab("Maybe there are clues as to what the combination is. It is only 3 dials, but they go up to the number 20. Something on the desk must be helpful.");
            NewLineTab("Enter a) to search the work papers.");
            Console.WriteLine("\tEnter b) to search the correspondance.");
            Console.WriteLine("\tEnter c) to try entering combinations into the lock.");
            Console.WriteLine("\tEnter d) to get up from the desk.");
            menuChoice = Console.ReadLine().ToLower();
            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("You pick up and start reading through the papers. There is a lot of information about payrolls, and cost efficiency.");
                    NewLineTab("There are 3 names that keep getting popping up on the work papers. Abraham F. Parcell, Tyler L. Hsu, and Robert G. Zemidas.");
                    NewLineTab("After looking at the cost between different railroad spikes for 15 minutes your eyes start to cross. You set the papers down.");
                    DisplayContinuePromt();
                    VincentsDesk();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("The correspondance pile is much smaller. There are mostly letters from widows of people that had died building the railways. It must be dangerous.");
                    NewLineTab("Vincent seems to have been sending money to a few of the widows, this doesn't seem to be a secret though as he kept the papers on the desk.");
                    NewLineTab("There is a letter from Abraham P. that is in the correspondance pile asking why Vincent favored Mr. Hsu over him.");
                    DisplayContinuePromt();
                    VincentsDesk();
                    break;

                case "c":
                    TheLock();
                    break;

                case "d":
                    Library();
                    break;
            }
        }
        #endregion

        #region THE LOCK
        private static void TheLock()
        {
            Console.Clear();
            NewLineTab("You lean over the lock and enter the numbers.");
            GetLockCombo();

        }

        private static (int numberOne, int numberTwo, int numberThree) GetLockCombo()
        {
            (int numberOne, int numberTwo, int numberThree) LockCombo;

            Console.WriteLine("\n\tPlease enter the first number between 01-20");
            LockCombo.numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\tPlease enter the second number between 01-20");
            LockCombo.numberTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\tPlease enter the third number between 01-20");
            LockCombo.numberThree = Int32.Parse(Console.ReadLine());
            NewMethod(LockCombo);

            return LockCombo;
        }

        private static void NewMethod((int numberOne, int numberTwo, int numberThree) LockCombo)
        {
            Console.WriteLine($"You put in the numbers {LockCombo.numberOne}, {LockCombo.numberTwo}, and {LockCombo.numberThree}. ");
            DisplayContinuePromt();

            if (LockCombo.numberOne == 20 && LockCombo.numberTwo == 12 && LockCombo.numberThree == 08)
            {
                Console.Clear();
                NewLineTab("You hear a satisfying CLICK as the drawer pops open.");
                NewLineTab("You pull it open to reveal a small wooden box inside and an envelope of papers.");
                NewLineTab("Pulling the box out you open it to reveal a few things. A mans wedding ring, and a very grainy picture of a couple on their wedding day.");
                NewLineTab("The box itself is well worn. This has been taken out and looked at many times before. You place it back in the drawer carefully.");
                NewLineTab("The envelope is full of papers, papers transfering the company to one Tyler L. Hsu. It is stated, and signed by Vincent himself.");
                NewLineTab("It looks like it was notarized and is an original copy, but hasn't been turned in to a lawyer yet. Interesting....");
                NewLineTab("Stated reasons that Tyler L Hsu will take over my business.");
                NewLineTab("I have suspected for some time now that Kathleen has been having an affair. I have no solid proof, but I know my felings.");
                NewLineTab("Victor, my oldest son, letting his brother oust him from his rightful place.");
                NewLineTab("Barty, my youngest son, for being too ruthless and aggressive of a businessman.");
                NewLineTab("Peg, sadly for the reason that you were born a woman, and your brothers would steal it from you.");
                NewLineTab("Vinny, my greatest disappointment. Growing up wealthy has caused you to be too soft to be a leader of men.");
                NewLineTab(".....It is impossible to say if the family knew of this, but it could be clues to the killer.");
                DisplayContinuePromt();
                VincentsDesk();
            }

            else
            {
                string menuchoice;
                NewLineTab("The combination lock is still shut. Ratfinskies!");
                NewLineTab("Enter a) to try again.");
                NewLineTab("Enter b) to go back to the desk.");
                menuchoice = Console.ReadLine();
                switch (menuchoice)
                {
                    case "a":
                        TheLock();
                        break;

                    case "b":
                        VincentsDesk();
                        break;

                    case "x":
                        MansionLobby();
                        break;

                    case "q":
                        ByeByeTime();
                        break;

                    default:
                        NewLineTab("No idea what that means. Try the lock again I guess.");
                        DisplayContinuePromt();
                        TheLock();
                        break;
                }
            }
        }
        #endregion

        #endregion

        #region JOFFREY INTERROGATION
        private static void JoffreyInterrogation()
        {
            string menuChoice;
            DisplayHeader("Joffrey");
            NewLineTab("In front of you sits a man in his mid fifties. He is wearing a black suit and tie over a white button up shirt. He has white gloves on still. They are stained with blood.");
            NewLineTab("'You are Joffrey the butler correct?' He nods at you. 'I have some questions for you Joffrey,' you say to him.");
            NewLineTab("He starts talking before you even get to ask him anything.");
            NewLineTab("He looks up at you, 'I didn't kill Mr. Helmsberg,' he says. 'I found his body though. He was still warm. I tried to stop the blood.'");
            NewLineTab("He looks down at his blood soaked gloves. 'Mr. Helmsberg didn't like me to take the gloves off. Although I probably should, they're ruined.' He doesn't take the gloves off.");
            NewLineTab("Joffrey continues to look at his gloves.");
            NewLineTab("Enter a) to ask him if he saw anything suspicious.");
            Console.WriteLine("\tEnter b) to ask him if he thinks he knows who killed Vincent.");
            Console.WriteLine("\tEnter c) to look around the Library more.");
            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    Console.Clear();
                    NewLineTab("'Suspicious? Not overly. This family is strange. Being so fantastically rich will change people.'");
                    NewLineTab("'Mr. Helmsberg and I had a fine relationship, but he never cared for me like he did his last Butler.'");
                    NewLineTab("'I always felt that he never cared for Kathleen like he did his first wife Annabelle. I don't have any proof of that though.'");
                    NewLineTab("'She was always good to me though. I liked her.");
                    DisplayContinuePromt();
                    JoffreyInterrogation();
                    break;

                case "b":
                    Console.Clear();
                    NewLineTab("'Do I think I know who killed Mr. Helmsberg? Well...... Vinny and Mr. Helmsberg argued a lot. Mr. Helmsberg seemed very frustrated at him often.'");
                    NewLineTab("'That doesn't mean that he killed him though. I just know they argued.'");
                    DisplayContinuePromt();
                    JoffreyInterrogation();
                    break;

                case "c":
                    Library();
                    break;

                default:
                    NewLineTab("That does nothing.");
                    break;
            }
        }
        #endregion

        #region THE SUSPECTS
        private static void TheSuspects()
        {
            string menuChoice;
            Console.Clear();
            NewLineTab("Officer Greg Dalson takes a drag from his handrolled cigarette.");
            NewLineTab("'We know that one of the people at the house now is the killer,'");
            Console.WriteLine("\n\tEnter a) to hear about Vincent's Wife Kathleen");
            Console.WriteLine("\tEnter b) to hear about Vincent's oldest son Victor");
            Console.WriteLine("\tEnter c) to hear about Vincent's youngest son Barty");
            Console.WriteLine("\tEnter d) to hear about Vincent's daughter Peg");
            Console.WriteLine("\tEnter e) to hear about Vincent's son in law Humphrey");
            Console.WriteLine("\tEnter f) to hear about Vincent's grandson Vinny");
            Console.WriteLine("\tEnter g) to hear about Vincent's maid Ivy");
            Console.WriteLine("\tEnter h) to hear about Vincent's gardener Pete");
            Console.WriteLine("\tEnter i) to hear about Vincent's butler Joffrey");
            Console.WriteLine("\tEnter j) to hear about Vincent's chef Landen");
            Console.WriteLine("\tEnter k) to hear about Vincent himself");
            Console.WriteLine("\tEnter l) to go to the Exterior of the House.");

            menuChoice = Console.ReadLine().ToLower();

            switch (menuChoice)
            {
                case "a":
                    KathleenDescription();
                    break;

                case "b":
                    VictorDescription();
                    break;

                case "c":
                    BartyDescription();
                    break;

                case "d":
                    PegDescription();
                    break;

                case "e":
                    HumphreyDescription();
                    break;

                case "f":
                    VinnyDescription();
                    break;

                case "g":
                    IvyDescription();
                    break;

                case "h":
                    PeteDescription();
                    break;

                case "i":
                    JoffreyDescription();
                    break;

                case "j":
                    LandenDescription();
                    break;

                case "k":
                    VincentDescription();
                    break;

                case "l":
                    TheHouseExterior();
                    break;

                case "q":
                    ByeByeTime();
                    break;

                case "x":
                    MansionLobby();
                    break;

                default:
                    NewLineTab("Please enter a letter from the menu choices!\n");
                    DisplayContinuePromt();
                    break;
            }
        }

        private static void VincentDescription()
        {

            DisplayHeader("Who was Vincent Helmsberg?");
            NewLineTab("Vincent was a railroad Baron who became rich beyond most peoples dreams.");
            NewLineTab("Vincent was 86 years old at the time of his death, and was in fine health.");
            NewLineTab("The evening Vincent was killed, he had his family over for dinner.");
            NewLineTab("This is not an unusual thing to have his family come for dinner and stay the night.");
            NewLineTab("Vincent has been known to give quite a bit of money to charity.");
            NewLineTab("Vincent enjoyed cigars and was found dead on his smoking patio.");
            NewLineTab("We know Vincent was killed with a knife to the side of his neck.");
            NewLineTab("Did you want to hear about others or head to the Mansion?");
            SuspectMansionChoice();

        }

        private static void LandenDescription()
        {


            DisplayHeader("Who is Landen?");
            Console.WriteLine("\tLanden has been Vincent's live in chef for the last 52 years.");
            NewLineTab("Landen and Vincent have had a good relationship as far as people are aware.");
            NewLineTab("Although he is one of the few people who would argue with Vincent.");
            NewLineTab("Landen and Vincent are close in age, Landen is 81.");
            NewLineTab("There are many sharp knives in the kitchen. Landen kept them razer sharp.");
            SuspectMansionChoice();

        }

        private static void JoffreyDescription()
        {
            DisplayHeader("Who is Joffrey?");
            NewLineTab("Joffrey is Vincents butler, and has only worked for him for the last 10 years.");
            NewLineTab("Joffrey replaced Ornathal after he passed away 10 years ago.");
            NewLineTab("It has been rumored that Joffrey and Vincent never got along as well as Vincent and Ornathal.");
            NewLineTab("That being said, it seems as though Joffrey was at least an adequate replacement to last 10 years.");
            SuspectMansionChoice();
        }

        private static void PeteDescription()
        {
            DisplayHeader("Who is Pete?");
            NewLineTab("Pete is Vincents Gardener. He was the caretaker of this land before Vincent bought it.");
            NewLineTab("Pete was living in a shack he had built himself out of scraps that he scavenged.");
            NewLineTab("Vincent was going to have Pete forcibly removed from the property, but when he met Pete he realized he was a veteran.");
            NewLineTab("Pete had fought in the White River War and it had repercussions upon his mental health.");
            NewLineTab("When the house was built in 1881 Pete stayed in the Gardeners hut, but eventually accepted a room inside the house.");
            NewLineTab("Pete meticulously cares for the grounds, and takes the landscaping very seriously.");
            SuspectMansionChoice();
        }

        private static void IvyDescription()
        {
            DisplayHeader("Who is Ivy?");
            NewLineTab("Ivy is Vincents maid, and has held this role for the past 20 years.");
            NewLineTab("Ivy was the daughter of an old friend of Vincents who died many years ago. Ivy was too young to marry and Vicent hired her to be his maid.");
            NewLineTab("She arrived at the house at the age of 15, and continued her studies under Vincents tutelage.");
            NewLineTab("She has not married as of yet, and seemingly has no suitors. She spends her time cleaning and taking care of the house, and her free time reading.");
            SuspectMansionChoice();
        }

        private static void VinnyDescription()
        {
            DisplayHeader("Who is Vinny?");
            NewLineTab("Vinny is Vincents only grandson, and his namesake.");
            NewLineTab("20 years old now, Vinny has not pursued higher education, or even a factory job.");
            NewLineTab("Vinny lives off of his families money, and spends quite a bit of time with Vincent at the Mansion.");
            NewLineTab("Vincent and Vinny have been known to have loud arguments that get quite heated, but Vincent loved Vinny unswervingly.");
            NewLineTab("Vincent made no effort to hide the fact that he thought Vinny needed to get an education and a job.");
            SuspectMansionChoice();
        }

        private static void HumphreyDescription()
        {
            DisplayHeader("Who is Humphrey?");
            NewLineTab("Humphrey is Peg's husband and the father of Vinny. He is in his early 50's and is a lawyer.");
            NewLineTab("Humphrey has never fit in well with Vincent or the other Helmsbergs as he came from a simple farming community.");
            NewLineTab("Despite this, he became a very powerful man and an intimidating lawyer.");
            NewLineTab("He does not like to be helped by the staff, and finds the Mansion to be a horrible waste of resources.");
            SuspectMansionChoice();
        }

        private static void PegDescription()
        {
            DisplayHeader("Who is Peg?");
            NewLineTab("Peg is Vincents only daughter and was the light of his life.");
            NewLineTab("She was doted upon by her father and was given an education, something that was not expected in the late 1800's.");
            NewLineTab("Peg has her fathers intellect and his fiery passion, but she also has her mothers strong resolve.");
            NewLineTab("She married Humphrey against her fathers wishes, and he was never happy about that.");
            NewLineTab("Peg doesn't let anyone tell her what to do, except Vinny. She turns a blind eye to anyhting that he does.");
            SuspectMansionChoice();
        }

        private static void BartyDescription()
        {
            DisplayHeader("Who is Barty?");
            NewLineTab("Barty is Vincents youngest son, and the recipient of his Railroad Empire.");
            NewLineTab("He took over operation from his older brother Victor soon after he left school.");
            NewLineTab("Many people thought that Victor, or Vincent would be upset about this, but Barty is smart and driven.");
            NewLineTab("He rarely comes around the Mansion anymore as he is busy running the business.");
            NewLineTab("It is rumored that he is working on buying and installing telegram services.");
            SuspectMansionChoice();
        }

        private static void VictorDescription()
        {
            DisplayHeader("Who is Victor?");
            NewLineTab("Victor is Vincents oldest son, and was groomed to take over the business before Barty took it over from him.");
            NewLineTab("Victor spends most of his time down river at the family stables where he cares for the horses.");
            NewLineTab("He can also be found at the offices when he is asked to be, but doesn't care to be there anymore.");
            SuspectMansionChoice();
        }

        private static void KathleenDescription()
        {
            DisplayHeader("Who is Kathleen?");
            NewLineTab("Kathleen is Vicents second wife and is 30 years his younger. They have been married now for 10 years.");
            NewLineTab("She is a Baroness from France who after she became a widow sold everything and moved to America.");
            NewLineTab("Kathleen is a jealous person and likes to have Vincents attention whenever they were together.");
            NewLineTab("She is not the mother to any of the children, in fact she is younger than Victor.");
            NewLineTab("Kathleen enjoys socializing and will attend any high class function that she can be seen at.");
            SuspectMansionChoice();
        }
        #endregion

        #region OPENING SCREEN
        static void Entry()
        {

            DisplayHeader("Welcome to The Murder in the Mansion!\n");
            Console.WriteLine("\tThis is a text based murder mystery game.");
            NewLineTab("A REAL WHODUNNIT!");
            NewLineTab("Please have the game in full screen for the best experience.");
            NewLineTab("In this game you will be tasked with solving a murder. You may explore the area of the murder as long as you like.");
            NewLineTab("You may ask the game many questions, and sometimes being creative will lead you to new things.");
            NewLineTab("I want to be clear that there is no definitive answer to who the murderer is. You must make your choice based on the information.");
            NewLineTab("You may press x at any time you are faced with a string of choices to go straight to the Lobby, where you may solve the murder.");
            NewLineTab("You may press q to quit the game anytime you are faced with a string of choices.");
            DisplayContinuePromt();
        }
        #endregion

        #region DISPLAY CONTINUE PROMPT
        /// <summary>
        /// A readkey method
        /// </summary>
        static void DisplayContinuePromt()
        {   //
            // pause for user
            //
            NewLineTab("Press any key to continue!\n");
            Console.ReadKey();
        }
        #endregion

        #region DISPLAY HEADER
        /// <summary>
        /// Method called to display a header
        /// </summary>
        /// <param name="headerText"></param>
        static void DisplayHeader(string headerText)
        {

            // DisplayHeader will return whatever is in the writeline in the app above.
            Console.Clear();
            Console.WriteLine($"\n\t\t{headerText}\n");

        }
        #endregion

        #region NEW TAB AND LINE
        /// <summary>
        /// Method called so I dont have to do a new tab and line every time. Just need to type in words.
        /// </summary>
        /// <param name="LineTab"></param>
        static void NewLineTab(string LineTab)
        {

            // NewLineTab will return whatever is in the writeline in the app above.
            Console.WriteLine($"\n\t{LineTab}");

        }
        #endregion

        #region SOLVE THE MYSTERY!
        private static void SOLVETHEMYSTERY()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            string userResponse;
            DisplayHeader("Solving the Murder!");
            NewLineTab("Are you sure you want to solve the murder? There will be no turning back from here. [yes | no]");
            userResponse = Console.ReadLine().ToLower();
            if (userResponse == "yes" || userResponse == "y" || userResponse == "yeah")
            {
                Console.Clear();
                NewLineTab("You call the Officers and the Suspects together in the Lobby. The crowd doesn't even fill the Lobby.");
                DisplayContinuePromt();
                Accusations();
            }

            else
            {
                Console.Clear();
                NewLineTab("Ok lets go back to the lobby then.");
                DisplayContinuePromt();
                MansionLobby();
            }
        }

        private static void Accusations()
        {
            string killerChoice;
            DisplayHeader("Finale");
            NewLineTab("After hours of difficult investigations, the sun is beginning to rise. The Lobby is being flooded with light from the morning sun as everyone shuffles around waiting.");
            NewLineTab("As you look around you see everyone is here. Someone even managed to get Kathleen out of bed. Although it doesn't look as though she comprehends whats happening here.");
            NewLineTab("Time to state your case!");
            NewLineTab("Please enter the name of the person who killed Vincent.");
            NewLineTab("[Kathleen | Victor | Barty | Peg | Humphrey | Vinny | Ivy | Pete | Joffrey | Landen]");
            killerChoice = Console.ReadLine().ToLower();
            switch (killerChoice)
            {
                case "kathleen":
                    string kathleen;
                    Console.Clear();
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'KATHLEEN!' You point your hand at the barely conscious woman in front of you.");
                    NewLineTab("please enter the reason that you know Kathleen killed Vincent below.");
                    kathleen = Console.ReadLine();
                    NewLineTab($"'{kathleen}.' You state decisively.");
                    NewLineTab("'There is no doubt in my mind that she killed her husband. She won't get away with it though. Not on my watch!'");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The police drag Kathleen kicking and screaming to a police car and insist that she be quiet, but you can hear her cries of innocence from here.");
                    NewLineTab("The rest of the family looks shocked at this development and there is a lot of talk as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Kathleen killed her husband because, {kathleen}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "victor":
                    string victor;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Victor! Vincents oldest son!' Victor looks shocked as you make the announcement.");
                    NewLineTab("please enter the reason that you know Victor killed Vincent below.");
                    victor = Console.ReadLine();
                    NewLineTab($"'{victor}.' You announce to the crowd.");
                    NewLineTab("Patricide? A horrible crime!");
                    NewLineTab("Victor looks around at his family in horror and shock as they shy away from him. He puts up no resistance as the police take him away.");
                    NewLineTab("As he is being taken out the front door he looks at you with tears in his eyes and says, 'You know I didn't do it don't you!?'");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The rest of the family looks shocked at this development and there is a lot of talk as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Victor killed his father because, {victor}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "barty":
                    string barty;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Barty. Vincents youngest son!' Barty looks surprised and angry.");
                    NewLineTab("Barty looks at you and shouts 'LIAR!' He pulls out a gun and aims it at you, his finger on the trigger.");
                    NewLineTab("Officer Donaugh steps in front of you and fires off a single shot. Its over before it even began. The family is screaming as Barty lies motionless on the floor.");
                    NewLineTab("Donaugh pulls you out of the house and takes you to a car and says, 'Come on lets get you home. The others can take care of it from here.'");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("As you drive along in silence Officer Donaugh looks back at you and says, 'So how did you know it was Barty anyways?'");
                    NewLineTab("please enter the reason that you know Barty killed Vincent below.");
                    barty = Console.ReadLine();
                    NewLineTab($"'{barty}.' You tell Officer Donaugh. He just nods sagely.");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "peg":
                    string peg;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Peg! Vincents only daughter!'");
                    NewLineTab("The color drains from Pegs face as her son and husband turn to look at her while taking a step back. 'Ww ..ww..ait.' She stutters.");
                    NewLineTab("please enter the reason that you know Peg killed Vincent below.");
                    peg = Console.ReadLine();
                    NewLineTab($"'{peg}.' You inform the crowd.");
                    NewLineTab("A fathers only daughter killing him. DESPICABLE.");
                    NewLineTab("Peg begins to cry quietly as she is handcuffed and escorted out of the house. Humphrey is shouting at the officers to unhand his wife as he follows them out quickly.");
                    NewLineTab("The rest of the family stares at you.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The rest of the family looks shocked at this development and there is a lot of talk as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Peg killed her father because, {peg}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "humphrey":
                    string humphrey;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Vincents only Son-in-law! Humphrey!' The news rocks Peg to the core apparently as she has to sit down with shock. Humphrey looks you in the eyes as they put handcuff on him.");
                    NewLineTab("please enter the reason that you know Humphrey killed Vincent below.");
                    humphrey = Console.ReadLine();
                    NewLineTab($"'{humphrey}.' You tell everyone.");
                    NewLineTab("A loved child's spouse murdering her father. Unthinkable.");
                    NewLineTab("'I'll see you in court you Scurf!' He shouts at you. Vinny consoles his mother as they watch Humphrey be taken away.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The rest of the family looks shocked at this development and there is a lot of talk as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Humphrey killed Vincent because, {humphrey}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "vinny":
                    string vinny;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Vinny! Vincents own grandson and namesake!!'");
                    NewLineTab("Vinny immediatly starts running for the door and is tackled by an officer while his mother screams, and his father yells incoherently.");
                    NewLineTab("please enter the reason that you know Vinny killed Vincent below.");
                    vinny = Console.ReadLine();
                    NewLineTab($"'{vinny}.' You shout over the noise of the family.");
                    NewLineTab("To think a grandson would be capable of killing his own grandfather, awful.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The rest of the family looks shocked at this development and there is a lot of talk as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Vinny killed his own grandfather because, {vinny}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "ivy":
                    string ivy;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'IVY! Vincents maid, and the woman he took in years ago when her father died!'");
                    NewLineTab("please enter the reason that you know Ivy killed Vincent below.");
                    ivy = Console.ReadLine();
                    NewLineTab($"'{ivy}!' You shout as the family yells and gasps. 'I KNEW IT!' Yells Kathleen. It doesn't sound like she actually knew it though.");
                    NewLineTab("Ivy stands stoically as they put handcuffs on her and put her in a police car. She stares you down as she goes.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The family looks on as they take her out and an officer takes Kathleen back upstairs. Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Ivy killed Vincent because, {ivy}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "pete":
                    string pete;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Pete! The gardener!'");
                    NewLineTab("please enter the reason that you know Pete killed Vincent below.");
                    pete = Console.ReadLine();
                    NewLineTab($"'{pete}.' You tell the family as Pete watches you from his seat on the stairs. As you finish up your explanation and the cuffs are being put on him he looks at you,");
                    NewLineTab("'I knew you'd say it was me the moment I heard Vincent was dead. Its always the outcast to you people isn't it?'");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("Everyone looks on as they walk Pete out. Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Pete killed Vincent because, {pete}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "joffrey":
                    string joffrey;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Joffrey! The butler!'");
                    NewLineTab("please enter the reason that you know Joffrey killed Vincent below.");
                    joffrey = Console.ReadLine();
                    NewLineTab($"'{joffrey}.' Joffrey looks horrified at this announcement. He is backing away from the officers with his bloody gloves raised. They handcuff him push him out the door.");
                    NewLineTab("'NOOOOOOOOOOOOOO IT WASN'T ME! THE DEEP HORRORS MUST BE FRAMING ME! PLEASE!' He yells. Wow. What a strange person.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("It is silent in the Lobby as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Joffrey killed Vincent because, {joffrey}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                case "landen":
                    string landen;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Landen! Vincents chef!'");
                    NewLineTab("please enter the reason that you know Landen killed Vincent below.");
                    landen = Console.ReadLine();
                    NewLineTab("As soon as the words are out of your mouth a razer sharp knife whips by your face. It misses you by inches.");
                    NewLineTab("Officers tackle Landen to the ground and he is spitting mad. They wrestle more knives out of his grip and cuff him quickly.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("The family applauds the quick actions of the officers as Officer Donaugh walks you out in the rain to a police car to take you home.");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Landen killed Vincent because, {landen}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();

                    break;

                case "vincent":
                    string vincent;
                    NewLineTab("You look around dramatically and say the person that killed Vincent was....");
                    NewLineTab("'Vincent himself!'");
                    NewLineTab("please enter the reason that you know Vincent killed himself.");
                    vincent = Console.ReadLine();
                    NewLineTab($"'{vincent}.' You tell everyone. Many of the family gasp as you tell them this information.");
                    NewLineTab("Shocked talking and exclamations abound in the Lobby. Officer Donaugh grabs you by the arm and pulls you outside.");
                    DisplayContinuePromt();
                    Console.Clear();
                    NewLineTab("Officer Donaugh says, 'Come on lets get you home. It's been a long night.'");
                    NewLineTab($"As you drive along in silence he looks back and says, 'I would never have guessed that Vincent killed because, {vincent}!'");
                    NewLineTab("The camera pans out of the car and overhead into the stormy morning air. Another case solved. Or was it.........");
                    DisplayContinuePromt();
                    Credits();
                    break;

                default:
                    Console.Clear();
                    NewLineTab("Whoops must have misspoke. Meant to say....");
                    DisplayContinuePromt();
                    Accusations();
                    break;
            }
        }

        private static void Credits()
        {
            DisplayHeader("Credits");
            NewLineTab("Hey my name is Russell and I made this! It's a mostly finished mystery game! I really enjoyed making it, and if I had more time it would be a lot bigger!");
            NewLineTab("This is my final project for CIT 110 and I learned a LOT in this class. I had no prior experience before starting this class and at times it was a HUGE challenge.");
            NewLineTab("I have some people to say thanks to. Tyler and Jason, my rocks, who basically walked me through the beginning (and other parts) of this class. I couldn't have done it without you.");
            NewLineTab("Thank you to my classmates as well. Mel for being my sounding board and listening to me rant, and JP for setting up the Discord for all of us to work together.");
            NewLineTab("Thanks to all the classmates that participated in the discussions and working together as well. It was a strange but awesome class. Thanks everyone!");
            NewLineTab("Thanks John Velis for being our Professor and running the class!");
            NewLineTab("Bye!");
            DisplayContinuePromt();
        }
        #endregion

        #region QUIT APPLICATION
        static void ByeByeTime()
        {
            Console.WriteLine("Well I hope you had a nice time!");
            DisplayContinuePromt();
        }
        #endregion

    }
}

