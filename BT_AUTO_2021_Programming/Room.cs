using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Room
    {
        double roomArea;
        int numberOfDoors;
        int numberOfWindows;
        int capacity;

        public Room(double roomArea, int numberOfDoors, int numberOfWindows, int capacity)
        {
            this.roomArea = roomArea;
            this.numberOfDoors = numberOfDoors;
            this.numberOfWindows = numberOfWindows;
            this.capacity = capacity;
        }

        public Room()
        {
        }

        public virtual  int GetRoomCapacity()
        {
            return this.capacity;
        }

        public virtual double GetRoomArea()
        {
            return this.roomArea;
        }
         
    }
}
