using System;
using System.Collections.Generic;
using System.Text;


namespace Shape_put_10_please_
{
    class RightTriangle : Triangle
    {
        public double FSide { get; set; }


        public double SSide { get; set; }


        public RightTriangle(double aSide, double bSide) : base(aSide, bSide, Hypotenuse(aSide, bSide))
        {
            FSide = aSide;
            SSide = bSide;
        }


        public static double Hypotenuse(double side1, double side2)
        {
            return Math.Sqrt(side1 * side1 + side2 * side2);
        }


        public override string ToString()
        {
            return "Right triangle with Cathetuses: " + FSide.ToString() + " , " + SSide.ToString() + " , Hypotenuse: " + Hypotenuse(FSide, SSide) + $"S: {Square}, P: {Perimeter}";
        }
    }
}