using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Room:Floor
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

        public virtual double RoomArea()
        {
            return roomArea;
        }

        public virtual  int Capacity()
        {
            return capacity;
        }

        public double GetRoomArea()
        {
            return this.roomArea;
        }

        public int GetCapacity()
        {
            return this.capacity;
        }
    }
}
