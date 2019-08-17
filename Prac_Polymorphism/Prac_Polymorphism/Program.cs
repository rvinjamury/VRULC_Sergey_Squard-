using System;

namespace Prac_Polymorphism
{ 
        public class Draw
        {
            //virtual method
            public virtual double Area()
            {
                return 0;
            }
        }

        public class Circle : Draw
        {
            //Code to calculate area of circle
            public double Radius { get; set; }
            public Circle()
            {
                Radius = 8;
            }
            public override double Area()
            {
                return (3.14) * Math.Pow(Radius, 2);
            }
        }

        public class Square : Draw
        {
            //Code to calculate area of square
            public double Length { get; set; }
            public Square()
            {
                Length = 6;
            }
            public override double Area()
            {
                return Math.Pow(Length, 2);
            }
        }

        public class Rectangle : Draw
        {
            //Code to calculate area of rectangle
            public double Height { get; set; }
            public double Width { get; set; }
            public Rectangle()
            {
                Height = 5.3;
                Width = 3.4;
            }
            public override double Area()
            {
                return Height * Width;
            }
        }

        //Main method
        class Program
        {
            static void Main(string[] args)
            {

                Draw circle = new Circle();
                Console.WriteLine("Circle Area :" + circle.Area());

                Draw square = new Square();
                Console.WriteLine("Square Area :" + square.Area());

                Draw rectangle = new Rectangle();
                Console.WriteLine("Rectangle Area :" + rectangle.Area());
            }
        }
    }

