using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public int PlayerPosition = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1,7);
            return roll;
          
        }
        
    }
}
