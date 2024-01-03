using System;

namespace RockPaperScissors
{
    public class Computer : IPlayer
    {
        private int computerInput;

        public Computer()
        {
            computerInput = 0;
        }

        public int GetComputerInput()
        {
            return computerInput;
        }

        public int PlayerMove()
        {
            Random random = new Random();
            int min = 1;
            int max = 3;
            computerInput = random.Next(min, max + 1);
            return computerInput;
        }
    }
}
