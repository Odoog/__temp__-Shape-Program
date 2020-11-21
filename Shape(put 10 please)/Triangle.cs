using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_put_10_please_
{
    class Triangle : Shape
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }
        public double AAngle { get; set; }
        public double BAngle { get; set; }
        public double CAngle { get; set; }


        public static double getAngleBySides(double oppositeSide, double side1, double side2)
        {
            return Math.Acos((side1 * side1 + side2 * side2 - oppositeSide * oppositeSide) / (2 * side1 * side2));
        }


        public Triangle(double aSide, double bSide, double cSide, double aAngle, double bAngle, double cAngle)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
            AAngle = aAngle;
            BAngle = bAngle;
            CAngle = cAngle;
        }


        public Triangle(double aSide, double bSide, double cSide) : this(aSide, bSide, cSide, getAngleBySides(aSide, bSide, cSide), getAngleBySides(bSide, aSide, cSide), getAngleBySides(cSide, aSide, bSide))
        {}


        public override double Perimeter
        {
            get
            {
                return ASide + BSide + CSide;
            }
        }


        public override double Square
        {
            get
            {
                var pPerimeter = Perimeter / 2;
                return Math.Sqrt(pPerimeter * (pPerimeter - ASide) * (pPerimeter - BSide) * (pPerimeter - CSide));
            }
        }


        public override string ToString()
        {
            return "Triangle with sides: " + ASide.ToString() + " , " + BSide.ToString() + " , " + CSide.ToString() + " , P: " + Square.ToString() + " , P: " + Perimeter.ToString();
        }


        public override string Serialize()
        {
            return this.JSONSerialize();
        }
    }
}