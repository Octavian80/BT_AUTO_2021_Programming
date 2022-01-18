using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Kitchen : Room
    {
        int coffeeMachine;
        int microwave;

        public Kitchen(double roomArea, int numberOfDoors, int numberOfWindows, int capacity, int coffeeMachine, int microwave) : base(roomArea, numberOfDoors, numberOfWindows, capacity)
        {
           
        }
         
    }
}
