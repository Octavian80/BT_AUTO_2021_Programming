using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Building 
    {
        int floorsNumbers;
        int roomsNumbers;
        double totalArea;
        int capacity;

        public Building(int floorsNumbers, int roomsNumbers, double totalArea, int capacity)
        {
            this.floorsNumbers = floorsNumbers;
            this.roomsNumbers = roomsNumbers;
            this.totalArea = totalArea;
            this.capacity = capacity;
        }

        public Building()
        {

        }
    }
}
