using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{

    
    public class Volume
    {

        
        const double TORUS = 4 / 3.00;
        int x = 2;
       





        //volume of cube =side*side*side
        //volume of a sphere (vs) = 4/3* π* r* r*r
        //volume of cylinder = 3.14 *a*a*h
        //volume of the pyramid =0.333*l*w*h
        // volume of the torus =2 * pi * pi * R * r * r



        public double GetVolume(double side) //cube
        {
            return side * side * side;
        }

        public double GetVolume(double a, double h) // cylinder //volume of cylinder = 3.14 *a*a*h
        {
            return Math.PI * a * a * h;
        }

        public double GetVolume(double l, double w, double h) //pyramid
        {
            return 1 / 3.00 * l * w * h;

        }

        public double GetVolume (int torus , double R, double r) // TORUS
        {
            return torus * r * r * Math.PI * Math.PI * R;
        }
       
       
        public double GetVolume ( int r)   //sphere 
        {
            return 4 / 3.00 * Math.PI * r * r * r;
        }
        






    }
}
