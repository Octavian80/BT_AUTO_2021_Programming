using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    abstract class AbstractBuilding : IBuilding
    {
       abstract public double ComputingArea();


        public abstract int GetNumberOfFloors();


        public abstract int GetTotalNumberOfRooms();


        public abstract int TotalCapacity();
        
    }
}
