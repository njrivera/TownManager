using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class AuxFunctions
    {
        private static Random rand = new Random();

        public static int Drought()
        {
            if (rand.Next(100) == 66)
            {
                Globals.notifications.Add(new Messages("A Drought has befallen the town. "
                    + "Until the drought has passed, no food will be produced from any farms.", "Catastrophe"));
                return rand.Next(12) + 1;
            }
            else
                return 0;
        }
    }
}
