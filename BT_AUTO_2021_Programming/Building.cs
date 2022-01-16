using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Building :AbstractBuilding
    {
        double buildingArea;
        int totalFloors;
        int totalRooms;
        int totalCapacity;
        Floor  floor ;
        Room room;
        


        public Building(double buildingArea, int totalFloors, int totalRooms, int totalCapacity)
        {
            this.buildingArea = buildingArea;
            this.totalFloors = totalFloors;
            this.totalRooms = totalRooms;
            this.totalCapacity = totalCapacity;
        }

        public Building()
        {

        }

        public Building(double buildingArea, int totalFloors, int totalRooms, int totalCapacity, Floor floor, Room room)
        {
            this.buildingArea = buildingArea;
            this.totalFloors = totalFloors;
            this.totalRooms = totalRooms;
            this.totalCapacity = totalCapacity;
            this.floor = floor;
            this.room = room;
        }

        public override double ComputingArea()
        {
            return room.GetRoomArea();
        }

        public override int GetNumberOfFloors()
        {
            return totalFloors;
        }

        public override int GetTotalNumberOfRooms()
        {
            return totalRooms ;
        }

        public override int TotalCapacity()
        {
            return room.GetCapacity();
        }

        public static void PrintBuilding(Building b)
        {
            Console.WriteLine("Total rooms ");
        }

    }
}
