using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balraj_Game
{
    class BalrajPunter
    {
        //static variables  
        public static int ist = 100, scnd = 100, thrd = 100;

        //static methods to pass the budget to the player 
        public static int firstbetter(int budget) { ist = budget; return ist; }
        public static int scndbetter(int budget) { scnd = budget; return scnd; }
        public static int thrdbetter(int budget) { thrd = budget; return thrd; }
    }
}
