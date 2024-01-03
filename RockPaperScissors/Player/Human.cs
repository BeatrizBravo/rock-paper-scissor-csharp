using System;

namespace RockPaperScissors
{
    public class Human : IPlayer
    {
        private int userInput;

        public Human()
        {
            userInput = 0;
        }

        public int GetUserInput()
        {
            return userInput;
        }

        public int PlayerMove()
        {
            int min = 1;
            int max = 3;
            bool validInput = false;

            do
            {
                Console.WriteLine("\nEnter your choice 1, 2, or 3");
                string userInputString = Console.ReadLine();

                if (int.TryParse(userInputString, out int parsedInput))
                {
                    if (parsedInput >= min && parsedInput <= max)
                    {
                        userInput = parsedInput;
                        validInput = true;
                    }
                }

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            } while (!validInput);

            return userInput;
        }

        public bool WouldYouLikeToPlayAgain()
        {
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("yes or no: ");
            string playAgain = Console.ReadLine().ToLower();

            return playAgain == "yes";
        }
    }
}
