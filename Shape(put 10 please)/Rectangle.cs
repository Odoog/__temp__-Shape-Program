using System;
using System.Collections.Generic;
using System.Text;


namespace Shape_put_10_please_
{
    class Rectangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }


        public override double Perimeter
        {
            get
            {
                return Side1 * 2 + Side2 * 2;
            }
        }


        public override double Square
        {
            get
            {
                return Side1 * Side2;
            }
        }


        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }


        public override string ToString()
        {
            return "Rectangle with sides: " + Side1.ToString() + " , " + Side2.ToString() + " , S: " + Square.ToString() + " , P: " + Perimeter.ToString();
        }


        public override string Serialize()
        {
            return this.JSONSerialize();
        }
    }
}