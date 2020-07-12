using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balraj_Game
{
    public static class BalrajGreyhound
    {
        //object of the random class
        static Random balrajRandom = new Random();

        // move static method for movement 
        public static int move()
        {
            //return the random no 
            return balrajRandom.Next(1, 40);
        }

        public static int pause(int position)
        {
            if (position >= 730)
            {
                return 1;
            }
            return 0;
        }
    }
}
