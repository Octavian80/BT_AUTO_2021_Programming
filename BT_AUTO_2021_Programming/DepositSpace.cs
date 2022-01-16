using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class DepositSpace : Room
    {
        int numberOfShelves;

        public DepositSpace(double roomArea, int numberOfDoors, int numberOfWindows, int capacity, int numberOfShelves) : base(roomArea, numberOfDoors, numberOfWindows, capacity)
        {
            this.numberOfShelves = numberOfShelves;
        }

        public DepositSpace()
        {

        }

        public override double RoomArea()
        {
            return GetRoomArea();
        }

        public override int Capacity()
        {
            return GetCapacity();
        }


    }
}
