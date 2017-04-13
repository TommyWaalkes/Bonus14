using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus14
{
    class Space
    {
        private bool isFilled = false;
        private int size;
        private IVehicle parkedVehicle;

        public Space(int s)
        {
            //0 is small
            //1 is medium
            //2 is large
            //ints will make doing size comparisons easier
            if (s < 3 && s >= 0)
            {
                size = s;
            }
            else
            {
                size = -1;
                Console.WriteLine("Invalid Size Given to space");
            }
        }

        public bool Park(IVehicle v)
        {
            if(isFilled == true)
            {
                Console.WriteLine("Parking Space is already filled");
                return false;
            }
            else
            {
                if (v.GetSize() <= GetSize())
                {
                    isFilled = true;
                    parkedVehicle = v;
                }
            }
            return true;
        }

        public int GetSize()
        {
            return size;
        }

        
    }
}
