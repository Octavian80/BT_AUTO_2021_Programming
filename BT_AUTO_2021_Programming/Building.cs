using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Building :AbstractBuilding
    {
         
          List <Floor> floorsList; 
          
          

        public Building(List<Floor> floorsList)
        {
            this.floorsList = floorsList;
        }

        public override int GetNumberOfFloors()
        {
            return floorsList.Count;
        }

        public override int GetTotalNumberOfRooms()
        {
            int nr = 0;
            foreach (Floor flor in floorsList)
                nr = nr + flor.GetNrRooms();
            return nr ;
        }

        public override int TotalCapacity()
        {
            int nr = 0;
            foreach (Floor flor in floorsList)
                nr = nr + flor.GetCapacity();
            return nr;
        }


        public override double ComputingArea()
        {
            double nr = 0;
            foreach (Floor flor in floorsList)
                nr = nr + flor.ComputeArea();
            return nr;
        }

        public static void PrintBuilding(Building b)
        {
            Console.WriteLine(" Total Rooms: " + b.GetTotalNumberOfRooms());
            Console.WriteLine(" Total Floors: " + b.GetNumberOfFloors());
            Console.WriteLine(" Total Area: " + b.ComputingArea());
            Console.WriteLine(" Total Capacity: " + b.ComputingArea());
        }

    }
}
