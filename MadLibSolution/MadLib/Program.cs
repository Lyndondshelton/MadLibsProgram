using System;

namespace MadLib
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            mainMenu();
            start();

        }
        public static void mainMenu()
        {
            Console.WriteLine("Hello, Welcome to my Mad Libs Program.\nTo begin, select a Mad Lib to read by typing a number 1 - 3 and pressing enter...\nTo end program enter 0...");

        }
        public static void start()
        {
            int madLibPointer = -1;

            madLibPointer = Convert.ToInt16(Console.ReadLine());

            switch (madLibPointer)
            {
                case 0:
                    end();
                    break;
                case 1:
                    madLib1();
                    break;
                case 2:
                    madLib2();
                    break;
                case 3:
                    madLib3();
                    break;
                default:
                    Console.WriteLine("Please Enter Number 1-3");
                    start();
                    break;
            }
        }
        public static void end()
        {
            Console.Clear();
        }

        public static void madLib1()
        {
            Console.Clear();
            Console.WriteLine("Title: BOOKish");
            Console.Write("______________________________________\n\n");
            String adj1, adj2, adj3, adj4, adj5, adj6;
            String noun1, noun2;
            String plrNoun1, plrNoun2, plrNoun3, plrNoun4;
            String femaleName;
            String artCloth;
            String city;
            String pOB1, pOB2;
            Char alpha;
            String celebrity;
            String place;
            String verb;
            double num;

            Console.Write("Enter Six(6) adjectives:");
            adj1 = Console.ReadLine();
            adj2 = Console.ReadLine();
            adj3 = Console.ReadLine();
            adj4 = Console.ReadLine();
            adj5 = Console.ReadLine();
            adj6 = Console.ReadLine();

            Console.Write("Enter Two(2) nouns: ");
            noun1 = Console.ReadLine();
            noun2 = Console.ReadLine();

            Console.Write("Enter Four(4) ploural nouns: ");
            plrNoun1 = Console.ReadLine();
            plrNoun2 = Console.ReadLine();
            plrNoun3 = Console.ReadLine();
            plrNoun4 = Console.ReadLine();

            Console.Write("Enter a name: ");
            femaleName = Console.ReadLine();

            Console.Write("Enter an article of clothing: ");
            artCloth = Console.ReadLine();

            Console.Write("Enter a City: ");
            city = Console.ReadLine();

            Console.Write("Enter Two(2) parts of the body: ");
            pOB1 = Console.ReadLine();
            pOB2 = Console.ReadLine();
           
            Console.Write("Enter a letter of the Alphabet: ");
            alpha = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the name of a place: ");
            place = Console.ReadLine();

            Console.Write("Enter the name of a celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();


            Console.Write("Please enter a number 1-1000000: ");
            num = Convert.ToDouble(Console.ReadLine());

            
            while(num <= 0 || num > 1000000)
            {
                Console.WriteLine(num + " is not a number from 1 - 1000000.");
                Console.Write("Please enter a number 1 - 1000000: ");
                num = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("There are many " + adj1 + " ways to choose a/an " + noun1 + " to read. First, you could ask for recommendations " +
                "from your friends and " + plrNoun1 + ". Just don't ask Aunt " + femaleName + " " +
                "--she only reads " + adj2 + " books with " + artCloth + "-ripping goddesses on the cover. " +
                "If your friends and family are no help, try checking out the " + noun2 + " Review in 'The " + city + " Times'." +
                "If the " + plrNoun2 + " featured there are too " + adj3 + " for your taste, try something a little more low-" + pOB1 + ", like " + alpha + ":" +
                " The " + celebrity + " magazine, or " + plrNoun3 + " Magazine. You could also choose a book the " + adj4 + "-fashioned way. " +
                "Head to your local library or " + place + " and browse the shelves until something catches your " + pOB2 + ". " +
                "Or, you could save yourself a whole lot of " + adj5 + " troubel and log on to www.bookish.com, the " + adj6 + " new" +
                " website to " + verb + " for books! With all the time you'll save not having to search for " + plrNoun4 + ", you can read " +
                "" + num + " more books!");

            Console.Write("Press any key to restart...");
            String cont = Console.ReadLine();
            if (cont != null)
            {
                Console.WriteLine("____________________________________");
                mainMenu();
                start();
            }


        }

        /* private static void checkIfZero(double number)
        {
            if(number <= 0 || number > 1000000)
            {
                getNum();
            }
        }

       private static double getNum()
        {
            Console.Write("Enter a number 1-1000000: ");
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }*/

        public static void madLib2()
        {
            Console.Clear();
            Console.WriteLine("Title: Fifty Shades of MAD LIBS");
            Console.Write("______________________________________\n\n");
            String bodyPart1, bodyPart2, bodyPart3;
            int number;
            String adj1, adj2;
            String color;
            String plrNoun1, plrNoun2;
            String verb1, verb2, verb3, verb4;
            String noun1, noun2;

            Console.Write("Please enter three(3) parts of the body: ");
            bodyPart1 = Console.ReadLine();
            bodyPart2 = Console.ReadLine();
            bodyPart3 = Console.ReadLine();

            Console.Write("Please enter a number, 1-1,000,000: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter two(2) adjectives: ");
            adj1 = Console.ReadLine();
            adj2 = Console.ReadLine();

            Console.Write("Please enter one(1) color: ");
            color = Console.ReadLine();

            Console.Write("Please enter two(2) plural nouns: ");
            plrNoun1 = Console.ReadLine();
            plrNoun2 = Console.ReadLine();

            Console.Write("Please enter four(4) verbs: ");
            verb1 = Console.ReadLine();
            verb2 = Console.ReadLine();
            verb3 = Console.ReadLine();
            verb4 = Console.ReadLine();

            Console.Write("Please enter two(2) nouns: ");
            noun1 = Console.ReadLine();
            noun2 = Console.ReadLine();

            Console.WriteLine("He holds out his "+bodyPart1+", and in his "+bodyPart2+" are "
                +number+" "+adj1+" "+color+" "+plrNoun1+" linked with a thick black thread... " +
            	"Inside me! I "+verb1+", and all the "+plrNoun2+" deep in my "+bodyPart3+" clench. My inner "+noun1+" is doing the "+verb2+
            	" of the seven veils. It's a "+adj2+" feeling. Once they're inside me, I can't really "+verb3+" them " +
            	"-- but then again I know they're there. I may have to "+verb4+" these. They make me needy, needy, for "+noun2+".");

            Console.Write("Press any key to restart...");
            String cont = Console.ReadLine();
            if(cont != null)
            {
                Console.WriteLine("____________________________________");
                mainMenu();
                start();
            }


        }
        public static void madLib3()
        {
            Console.Clear();
            Console.WriteLine("Title: If I was President!");
            Console.Write("______________________________________\n\n");
            String adj1, adj2, adj3, adj4, adj5, adj6, adj7, adj8;
            String noun1, noun2, noun3, noun4, noun5;
            String verb1, verb2;
            String plrNoun1, plrNoun2, plrNoun3;
            String date;
            String holiday;
            String celebrity;
            String color;
            String shape;

            Console.Write("Please enter eight(8) adjectives: ");
            adj1 = Console.ReadLine();
            adj2 = Console.ReadLine();
            adj3 = Console.ReadLine();
            adj4 = Console.ReadLine();
            adj5 = Console.ReadLine();
            adj6 = Console.ReadLine();
            adj7 = Console.ReadLine();
            adj8 = Console.ReadLine();

            Console.Write("Please enter five(5) nouns: ");
            noun1 = Console.ReadLine();
            noun2 = Console.ReadLine();
            noun3 = Console.ReadLine();
            noun4 = Console.ReadLine();
            noun5 = Console.ReadLine();

            Console.Write("Please enter two(2) verbs: ");
            verb1 = Console.ReadLine();
            verb2 = Console.ReadLine();

            Console.Write("Please enter three(3) ploural nouns: ");
            plrNoun1 = Console.ReadLine();
            plrNoun2 = Console.ReadLine();
            plrNoun3 = Console.ReadLine();

            Console.Write("Please enter a date(Month, Day): ");
            date = Console.ReadLine();

            Console.Write("Please enter a holiday(Real or Fantasy): ");
            holiday = Console.ReadLine();

            Console.Write("Please enter the name of a Celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write("Please enter a the name of a color: ");
            color = Console.ReadLine();

            Console.Write("Please enter a the name of a shape:");
            shape = Console.ReadLine();

            Console.WriteLine("If I were president I would be so "+adj1+". All of the citizens of the United States would be "+adj2+"," +
                " that I was the "+noun1+". I would be a great president because I want to make a "+noun2+". First, I would make a law to let " +
                " "+noun3+" go "+verb1+". Then I would let everyone have a party on "+date+" to celebrate "+holiday+". I would also make "+celebrity+" " +
                "my vice president. Living in the "+color+" house would be so amazing! Every day I would run through all the "+plrNoun1+" and " +
                ""+verb2+" down the staircase. My "+noun4+" would get to live at the White House with me. Working in the "+shape+" "+
                "office would be "+adj3+" I would have to meet lots of "+adj4+" people from other "+plrNoun2+". I hope I would know what to do. " +
                "I wouldn't want to be rude! I think I would make a/an "+adj5+" president! I would be "+adj6+", "+adj7+", and "+adj8+". I would make sure " +
                "all of my "+plrNoun3+" were best for everyone in the country. Being the president is a very difficult "+noun5+" but I would be " +
                "great at it!");

            Console.Write("Press any key to restart...");
            string cont = Console.ReadLine();
            if (cont != null)
            {
                Console.WriteLine("____________________________________");
                mainMenu();
                start();
            }
        }
    }
}
