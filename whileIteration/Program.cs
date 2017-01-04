using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Pick the Number of the Option " +
                "You Would Like to Select:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit\n");
            
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                Goodbye();
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please press enter and then " +
                    "pick an option '1, 2, or 3'...");
                Console.ReadLine();
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            ReturnToMenu();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a Number Between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Sorry, Try Again!");
            } while (incorrect);
            Console.Clear();
            Console.WriteLine("Nice Job! You correctly guessed {0} in just {1} guesses.", randomNumber, guesses);
            ReturnToMenu();  
        }

        private static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("GoodBye! \nThanks for Playing!");
            Console.ReadLine();
        }

        private static void ReturnToMenu()
        {
            Console.WriteLine("\n\nPress Enter to Return to Main Menu");
            Console.ReadLine();
        }
    }
}
