using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class WorkingSpace : Room
    {
        int numberOfLamps;
        int laptop;

        public WorkingSpace(double roomArea, int numberOfDoors, int numberOfWindows, int capacity, int numberOfLamps, int laptop) : base(roomArea, numberOfDoors, numberOfWindows, capacity)
        {
            this.numberOfLamps = numberOfLamps;
            this.laptop = laptop;
        }
         

    }
}
