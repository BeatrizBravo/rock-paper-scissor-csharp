using System;

namespace RockPaperScissors
{
    public static class GameLogic
    {
        public static string CompareResult(int userInput, int computerInput)
        {
            string result = "";
            switch (userInput)
            {
                case 1: // rock
                    switch (computerInput)
                    {
                        case 1: // rock
                            result = "It is a draw";
                            break;
                        case 2: // paper
                            result = "The computer won";
                            break;
                        case 3: // scissor
                            result = "You won";
                            break;
                    }
                    break;
                case 2: // paper
                    switch (computerInput)
                    {
                        case 1: // rock
                            result = "You won";
                            break;
                        case 2: // paper
                            result = "It is a draw";
                            break;
                        case 3: // scissor
                            result = "The computer won";
                            break;
                    }
                    break;
                case 3: // scissor
                    switch (computerInput)
                    {
                        case 1: // rock
                            result = "The computer won";
                            break;
                        case 2: // paper
                            result = "You won";
                            break;
                        case 3: // scissor
                            result = "It is a draw";
                            break;
                    }
                    break;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
