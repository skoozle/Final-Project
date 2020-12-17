using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    

    
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            
            
        }

        public static void gameTitle()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to my game.");
            Console.WriteLine("Press enter to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
            Console.BackgroundColor = ConsoleColor.Black;


        }

        public static void first()
        {
            string choice;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You wake up in class with an angry teachher standing over you.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What do you do?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. punch him");
            Console.WriteLine("2. Cry");
            Console.WriteLine("3. pee a little");
            Console.Write("Choice");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Your fist slams ole' teach in the face");
                        Console.WriteLine("the class cheers your name!");
                        Console.WriteLine("The priciple hears the noise from the hall and bustts through the door!");
                        Console.WriteLine("When realizes what happened he throws his boomerang directly at ya melon");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }
                case "2":
                case "cry":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Your teacher laughs and tells you to take your sobbing to the hall!");
                        Console.WriteLine("HAHAHAHAHA WEAKLING!");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "pee":
                case "pee a little":
                    {
                        Console.WriteLine("Your teacher sniffs the air, the students notice too and start plugging their noses");
                        Console.WriteLine("Did you just...? PISS!? Get out of here,soggy britches! HAHAHAHAHA WEAKLING!");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I dont understand that command...");
                        Console.WriteLine("Press enter to try again.");
                        first();
                        break;
                    }



            }

        }
         public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = {"In the hall way, you see that the cops are searching lockers." ,
                "In the hallway you see your stalker walking right toward you." ,
                "In the hallway, the fire alarm goes off." };
            int randomNumber = rnd.Next(0, 3);
            string secondText = secondOptions[randomNumber];

            string secondChoice;

            Console.WriteLine(secondText);
            Console.WriteLine("Do you try to hide in the bathroom; Yes or No?");
            Console.WriteLine("Choice:");
            secondChoice = Console.ReadLine().ToLower();

            if (secondChoice == "yes" || secondChoice == "y")
            {
                third();
            }
            else if (secondChoice == "no" || secondChoice == "n")
            {
                Console.WriteLine("A meteor slams into the school at that exact moment, you dead!");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOver();


            }
            else
            {
                Console.WriteLine("I dont understand that command...");
                Console.WriteLine("Press enter to try again.");
                second();

            }
            


        }

        public static void third()
        {
            int age;
            Console.WriteLine("You burst into the bathroom");
            Console.WriteLine("All of your friends and family are there!");
            Console.WriteLine("They yell 'Surprise!' and you remember its your birthday.");
            Console.WriteLine("How old are you today?");
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);

            while (age < 100)
            {
                Console.WriteLine("SEriously? You look older than that!");
                Console.WriteLine("How old are you really?");
                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine("Wow, you're old! you mustve been held back alot!");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            youWin();


        }
        public static void gameOver()
        { 
            Console.Clear();
            Console.WriteLine("At your funeral, they sing songs of your bravery!");
            Console.WriteLine("Then they remember who's funeral they are attending...");
            Console.WriteLine("They all take it back...:/");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            gameTitle();

        }
        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Your bday party was a big hit!");
            Console.WriteLine("The cake gave everyone super powers!");
            Console.WriteLine("Youw will all live for another 100 years");
            Console.WriteLine("Grat job! you won!");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            gameTitle();
        }
            


        
    }
}   
