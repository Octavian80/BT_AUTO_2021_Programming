using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    interface IShape
    {
        void Draw();
        void Color();

        //This is valid only for newer versions
        void State()
        {
            Console.WriteLine("State of the Shape");
        }
    }
}
