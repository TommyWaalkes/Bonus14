using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus14
{
    class ParkingGarage
    {
        List<Level> levels = new List<Level>();

        public Level GetLevel(int index)
        {
            Level l = levels[index];
            return l;
        }
    }
}
