using System;
using System.Collections.Generic;
using System.Text;


namespace Shape_put_10_please_
{
    class SquareFigure : Rectangle
    {
        public double Side { get; set; }


        public SquareFigure(double side) : base(side, side) { }


        public override string ToString()
        {
            return "Square with side: " + Side.ToString() + " , S: " + Square.ToString() + " , P: " + Perimeter.ToString();
        }
    }
}