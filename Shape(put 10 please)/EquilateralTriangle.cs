using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_put_10_please_
{
    class EquilateralTriangle : Triangle
    {
        public double Side { get; set; }


        public EquilateralTriangle(double side) : base(side, side, side)
        {
            Side = side;
        }


        public override string ToString()
        {
            return "Right triangle with side: " + Side.ToString() + $"S: {Square}, P: {Perimeter}";
        }
    }
}