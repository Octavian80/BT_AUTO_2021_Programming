using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Rectangle: Shape
    {
        double lenght;//private is by default 
        double width;

        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public Rectangle()
        {
            
        }

        public double GetLenght()
        {
            return lenght;
        }
        public void SetLenght(double lenght)
        {
            if (lenght > 0)
            {


                this.lenght = lenght;
            }
            else
            {
                Console.WriteLine("You cannot set a length to a negative number !!!");
            }
        }

        public void SetSize(double lenght ,double width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public virtual double GetArea()
            {
            return lenght * width;

        }

        public virtual Double GetPerimeter()
        {
            return 2 * (lenght + width);
        }
        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2)+ Math.Pow(lenght,2));

        }
        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with lenght{0} and width{1} has area{2}", lenght, width, GetArea());
            Console.WriteLine("Area is {0} Perimeter is {1} Diagonal is {2}", GetArea(), GetPerimeter(), GetDiagonal());
        }

        public override string ToString()
        {
            return "This is a rectangle with " + width +  "width and" + lenght + " lenght !!";
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
