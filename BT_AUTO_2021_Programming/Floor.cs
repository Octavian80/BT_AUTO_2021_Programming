using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Floor: Building 
    {

        int totalMeetingRoom;
        int totalKitchen;
        int totalWorkingSpace;
        int totalDepositSpace;
        Room room;
        

        public Floor(int totalMeetingRoom, int totalKitchen, int totalWorkingSpace, int totalDepositSpace, Room room)
        {
            this.totalMeetingRoom = totalMeetingRoom;
            this.totalKitchen = totalKitchen;
            this.totalWorkingSpace = totalWorkingSpace;
            this.totalDepositSpace = totalDepositSpace;
            this.room = room;
            
        }

        public Floor()
        {
        }
    }
}
