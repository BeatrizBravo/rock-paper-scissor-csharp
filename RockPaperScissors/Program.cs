using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Rock Paper Scissors Game\n");
            Console.WriteLine("Choose your move:");
            Console.WriteLine("\t1 = rock");
            Console.WriteLine("\t2 = paper");
            Console.WriteLine("\t3 = scissor");

            Human humanPlayer = new Human();
            Computer computerPlayer = new Computer();
            string resultGame;
            int humanInput = humanPlayer.GetUserInput();
            int computerInput = computerPlayer.GetComputerInput();

            do
            {
                do
                {
                    humanInput = humanPlayer.PlayerMove();
                    computerInput = computerPlayer.PlayerMove();

                    Console.WriteLine("\nYou selected: " + humanInput);
                    Console.WriteLine("The computer selected: " + computerInput + "\n");

                    resultGame = GameLogic.CompareResult(humanInput, computerInput);

                } while (resultGame == "It is a draw");

            } while (humanPlayer.WouldYouLikeToPlayAgain());
        }
    }
}
