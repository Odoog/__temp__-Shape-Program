using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_put_10_please_
{
    abstract class Shape
    {
        public abstract double Perimeter { get; }


        public abstract double Square { get; }


        public int NumberOfApex { get; }


        public abstract string Serialize();


        public override string ToString()
        {
            return $"P: {Perimeter}, S: {Square}, NOA: {NumberOfApex}";
        }
    }
}