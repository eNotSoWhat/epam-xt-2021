using System;
using System.Collections.Generic;

namespace newString
{
    class Circle
    {
        protected double x0 = 0;
        protected double y0 = 0;
        protected double R0 = 1;
        public void Param (double x, double y, double r)
        {
            x0 = x;
            y0 = y;
            R0 = r;
        }
        public double Perimetr ()
        {
            return Math.PI * 2 * R0;
        }
        public double Area ()
        {
            return Math.PI * R0 * R0;
        }

        public void Show ()
        {
            Console.WriteLine("Type: Circle");
            Console.WriteLine ($"Parametrs:\n(x0, y0) = ({x0}, {y0}. Radius = {R0}");
            Console.WriteLine ($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }

    class Ring : Circle
    {
        protected double r = 0;
        public double Perimetr ()
        {
            return Math.PI * 2 * (R0 - r);
        }
        public double Area ()
        {
            return Math.PI * (R0 * R0 + r * r);
        }
        public void Show ()
        {
            Console.WriteLine("Type: Ring");
            Console.WriteLine ($"Parametrs:\n(x0, y0) = ({x0}, {y0}. Radius = {R0}");
            Console.WriteLine ($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }

    class Square
    {
        protected double x0 = 0;
        protected double y0 = 0;
        protected double a0 = 0;
        public void Param (double x, double y, double a)
        {
            x0 = x;
            y0 = y;
            a0 = a;
        }
        public double Perimetr ()
        {
            return 4 * a0;
        }
        public double Area ()
        {
            return a0 * a0;
        }
        public void Show ()
        {
            Console.WriteLine("Type: Square");
            Console.WriteLine ($"Parametrs:\n(x0, y0) = ({x0}, {y0}. Syde = {a0}");
            Console.WriteLine ($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }
    class Rectangle : Square
    {
        protected double b0 = 0;
        public void Param (double x, double y, double a, double b)
        {
            b0 = b;
        }
        public double Perimetr ()
        {
            return 2 * (a0 + b0);
        }
        public double Area ()
        {
            return a0 * b0;
        }
        public void Show ()
        {
            Console.WriteLine("Type: Rectangle");
            Console.WriteLine($"Parametrs:\n(x0, y0) = ({x0}, {y0}. 1 syde = {a0}, 2 syde = {b0}");
            Console.WriteLine($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }
    class Line
    {
        protected double x0 = 0;
        protected double y0 = 0;
        protected double a0 = 0;
        public double Perimetr()
        {
            return a0;
        }
        public double Area()
        {
            return 0;
        }
        public void Show()
        {
            Console.WriteLine("Type: Line");
            Console.WriteLine($"Parametrs:\n(x0, y0) = ({x0}, {y0}. Length = {a0}");
            Console.WriteLine($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }
    class Triangle : Line
    {
        protected double b0;
        protected double c0;
        public double Perimetr()
        {
            return a0 + b0 + c0;
        }
        public double Area()
        {
            double p = (a0 + b0 + c0) / 2;
            return p * (p - a0) * (p - b0) * (p - c0);
        }
        public void Show()
        {
            Console.WriteLine("Type: Triangle");
            Console.WriteLine($"Parametrs:\n(x0, y0) = ({x0}, {y0}. 1 syde = {a0}, 2 syde = {a0}, 3 syde = {c0}");
            Console.WriteLine($"Perimetr = {Perimetr()}, Area = {Area()}");
        }
    }
    class User
    {
        private List<Circle> circle_list;
        private List<Ring> ring_list;
        private List<Square> square_list;
        private List<Rectangle> rectangle_list;
        private List<Line> line_list;
        private List<Triangle> triangle_list;

        public Circle Add_circle
        {
            set
            {
                circle_list.Add(value);
            }
        }
        public List<Circle> Print_circle
        {
            get
            {
                return circle_list;
            }
        }
        public Ring Add_ring
        {
            set
            {
                ring_list.Add(value);
            }
        }
        public List<Ring> Print_ring
        {
            get
            {
                return ring_list;
            }
        }
        public Square Add_square
        {
            set
            {
                square_list.Add(value);
            }
        }
        public List<Square> Print_square
        {
            get
            {
                return square_list;
            }
        }
        public Rectangle Add_rectangle
        {
            set
            {
                rectangle_list.Add(value);
            }
        }
        public List<Rectangle> Print_rectanlge
        {
            get
            {
                return rectangle_list;
            }
        }
        public Line Add_line
        {
            set
            {
                line_list.Add(value);
            }
        }
        public List<Line> Print_line
        {
            get
            {
                return line_list;
            }
        }
        public Triangle Add_triangle
        { 
            set
            {
                triangle_list.Add(value);
            }
        }
        public List<Triangle> Print_triangle
        {
            get
            {
                return triangle_list;
            }
        }
        public void Clear()
        {
            circle_list = null;
            ring_list = null;
            square_list = null;
            rectangle_list = null;
            line_list = null;
            triangle_list = null;
        }
        static void Main()
        {
            
        }
    }
}
