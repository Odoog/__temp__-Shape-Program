using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Shape_put_10_please_
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            List<Shape> figures = new List<Shape>();


            int trianglesCount;
            int rightTrianglesCount;
            int equilateralTrianglesCount;
            int squaresCount;
            int rectanglesCount;


            do
            {
                Console.WriteLine("Введите необходимое количество прямоугольных треугольников.");
            }
            while (!int.TryParse(Console.ReadLine(), out rightTrianglesCount));


            do
            {
                Console.WriteLine("Введите необходимое количество равносторонних треугольников.");
            }
            while (!int.TryParse(Console.ReadLine(), out equilateralTrianglesCount));


            do
            {
                Console.WriteLine("Введите необходимое количество обычных треугольников.");
            }
            while (!int.TryParse(Console.ReadLine(), out trianglesCount));


            do
            {
                Console.WriteLine("Введите необходимое количество квадратов.");
            }
            while (!int.TryParse(Console.ReadLine(), out squaresCount));


            do
            {
                Console.WriteLine("Введите необходимое количество прямоугольников.");
            }
            while (!int.TryParse(Console.ReadLine(), out rectanglesCount));


            for (int i = 0; i < squaresCount; i++)
            {
                figures.Add(new SquareFigure(rnd.Next(1, 100)));
            }


            for (int i = 0; i < rectanglesCount; i++)
            {
                figures.Add(new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100)));
            }


            for (int i = 0; i < rightTrianglesCount; i++)
            {
                figures.Add(new RightTriangle(rnd.Next(1, 100), rnd.Next(1, 100)));
            }


            for (int i = 0; i < equilateralTrianglesCount; i++)
            {
                figures.Add(new EquilateralTriangle(rnd.Next(1, 100)));
            }
            for (int i = 0; i < trianglesCount; i++)
            {
                while (true)
                {
                    int a = rnd.Next(1, 100);
                    int b = rnd.Next(1, 100);
                    int c = rnd.Next(1, 100);
                    if ((a < b + c) && (b < a + c) && (c < a + b))
                    {
                        figures.Add(new Triangle(a, b, c));
                        break;
                    }
                }
            }


            foreach (var el in figures)
            {
                Console.WriteLine(el.ToString());
            }


            using (var sw = new StreamWriter("result.txt"))
            {
                foreach (var el in figures)
                {
                    sw.WriteLine(el.Serialize());
                }
            }
        }
    }
}