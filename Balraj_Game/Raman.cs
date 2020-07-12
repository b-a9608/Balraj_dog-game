using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balraj_Game
{
    public class Raman
    {
        public static int winnner(String budget, int frst, int winner)
        {
            //Raman choose dog 
            String[] data = budget.Split(' ');
            if (winner == Convert.ToInt32(data[3]))
            {
                return frst + Convert.ToInt32(data[5]);
            }
            else
            {
                return frst - Convert.ToInt32(data[5]);

            }
        }
    }
}
