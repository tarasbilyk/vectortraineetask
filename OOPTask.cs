using System;
using System.Collections.Generic;

namespace OOPTask
{
    class Program
    {
        abstract class Shape : IComparable<Shape>
        {
            protected double respectiveArea;

            public int CompareTo(Shape other)
            {
                if (other == null) return 1;
                return this.respectiveArea.CompareTo(other.respectiveArea);
            }

            public override string ToString()
            {
                return $"respectiveArea = {respectiveArea}";
            }
        }

        class Square : Shape
        {
            public Square(double side)
            {
                respectiveArea = Math.Pow(side, 2);
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(double width, double height)
            {
                respectiveArea = width * height;
            }
        }

        class Triangle : Shape
        {
            public Triangle(double baseSize, double height)
            {
                respectiveArea = baseSize * height / 2;
            }
        }

        class Circle : Shape
        {
            public Circle(double radius)
            {
                respectiveArea = Math.Pow(radius, 2) * Math.PI;
            }
        }


        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Square(5),
                new Rectangle(2, 2),
                new Triangle(5, 2),
                new Circle(10)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            shapes.Sort();
            Console.WriteLine("After sort");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
