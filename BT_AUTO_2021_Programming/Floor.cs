using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Floor 
    {

        List<Room> roomList;

        public Floor(List<Room> roomList)
        {
            this.roomList = roomList;
        }

        public int GetCapacity()
        {

            int nr = 0;
            foreach (Room rom in roomList)
                nr = nr + rom.GetRoomCapacity();
            return nr;
        }

        public int GetNrRooms()
        {
            return roomList.Count; ;
        }

        public double ComputeArea()
        {

            double nr = 0;
            foreach (Room rom in roomList)
                nr = nr + rom.GetRoomArea();
            return nr;
        }
         
    }
}
