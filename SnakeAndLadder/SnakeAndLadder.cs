using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;

        public int PlayerPosition = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1,7);
            return roll;
     
        }
        public void PlayerCheck()
        {
            int dieRolling = this.DieRolling();
            int option = random.Next(0,3);
            switch (option)
            {
                case No_Play:
                    break;

                case Ladder:
                    this.PlayerPosition += dieRolling;
                    break;
                case Snake:
                    this.PlayerPosition -= dieRolling;
                    break;

            }
            Console.WriteLine(this.PlayerPosition); 
        }
        
    }
}
