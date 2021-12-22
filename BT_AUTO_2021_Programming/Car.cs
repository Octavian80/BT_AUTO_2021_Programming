using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Car
    {

        bool carStatus;
        double currentAcceleration ;
        double direction;

        public Car(bool carStatus, double currentAcceleration, double direction)
        {
            this.carStatus = carStatus;
            this.currentAcceleration = currentAcceleration;
            this.direction = direction;
        }

        public Car()
        {
        }

        public void Accelerate()
        {
            currentAcceleration += 5;
        }
        public void Start()
        {
            carStatus = true;
        }
        public void Stop()
        {
            carStatus = false;
        }
        public void TurnLeft()
        {
            direction-= 90;
        }

        public void TurnRight()
        {
            direction += 90;
        }

        public static double ConvertHpToKw(double hp)
        {
            return hp = 0.735499;
        }
    }
}
