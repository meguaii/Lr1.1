//Задание 1
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("byte: min = {0}, max = {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("sbyte: min = {0}, max = {1}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("short: min = {0}, max = {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("ushort: min = {0}, max = {1}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("int: min = {0}, max = {1}", int.MinValue, int.MaxValue);
        Console.WriteLine("uint: min = {0}, max = {1}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("long: min = {0}, max = {1}", long.MinValue, long.MaxValue);
        Console.WriteLine("ulong: min = {0}, max = {1}", ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("float: min = {0}, max = {1}", float.MinValue, float.MaxValue);
        Console.WriteLine("double: min = {0}, max = {1}", double.MinValue, double.MaxValue);
        Console.WriteLine("decimal: min = {0}, max = {1}", decimal.MinValue, decimal.MaxValue);
    }
}




//Задание 2
//using System;


//    public class Rectangle
//    {
//        private double sideA;
//        private double sideB;

//        public Rectangle(double sideA, double sideB)
//        {
//            this.sideA = sideA;
//            this.sideB = sideB;
//        }

//        private double CalculateArea()
//        {
//            return sideA * sideB;
//        }

//        private double CalculatePerimeter()
//        {
//            return 2 * (sideA + sideB);
//        }

//        public double Area
//        {
//            get { return CalculateArea(); }
//        }

//        public double Perimeter
//        {
//            get { return CalculatePerimeter(); }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите длину стороны A: ");
//            double sideA = double.Parse(Console.ReadLine());

//            Console.Write("Введите длину стороны B: ");
//             double sideB = double.Parse(Console.ReadLine());

//            Rectangle rectangle = new Rectangle(sideA, sideB);
//            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
//            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
//        }
//    }


//Задание 3
//using System;

//namespace Lab1
//{
//    public class Point
//    {
//        private int x;
//        private int y;

//        public int X
//        {
//            get { return x; }
//        }

//        public int Y
//        {
//            get { return y; }
//        }

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    public class Figure
//    {
//        private string name;
//        private Point[] points;

//        public string Name
//        {
//            get { return name; }
//        }

//        public Figure(Point p1, Point p2, Point p3)
//            : this("Треугольник", p1, p2, p3)
//        {
//        }

//        public Figure(Point p1, Point p2, Point p3, Point p4)
//            : this("Четырехугольник", p1, p2, p3, p4)
//        {
//        }

//        public Figure(string name, Point p1, Point p2, Point p3)
//        {
//            this.name = name;
//            points = new Point[] { p1, p2, p3 };
//        }

//        public Figure(string name, Point p1, Point p2, Point p3, Point p4)
//        {

//            this.name = name;
//            points = new Point[] { p1, p2, p3, p4 };
//        }

//        private double LengthSide(Point a, Point b)
//        {
//            double dx = a.X - b.X;
//            double dy = a.Y - b.Y;
//            return Math.Sqrt(dx * dx + dy * dy);
//        }

//        public double PerimeterCalculator()
//        {
//            double perimeter = 0;
//            for (int i = 0; i < points.Length; i++)
//            {
//                int j = (i + 1) % points.Length;
//                perimeter += LengthSide(points[i], points[j]);
//            }
//            return perimeter;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point p1 = new Point(0, 0);
//            Point p2 = new Point(3, 0);
//            Point p3 = new Point(3, 4);
//            Point p4 = new Point(0, 4);

//            Figure triangle = new Figure(p1, p2, p3);
//            Figure rectangle = new Figure(p1, p2, p3, p4);

//            Console.WriteLine($"Название фигуры: {triangle.Name}");
//            Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");

//            Console.WriteLine($"Название фигуры: {rectangle.Name}");
//            Console.WriteLine($"Периметр фигуры: {rectangle.PerimeterCalculator()}");
//        }
//    }
//}


