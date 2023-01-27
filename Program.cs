using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape str = new Circle();
            Console.WriteLine(str.getType());
            
            Rectangle obj = new Rectangle();
            obj.Height = 10;
            obj.Base = 2;
            Console.WriteLine("Rectangle : " + obj.getArea());
            Console.WriteLine("Type : " + obj.getType());
            
            Circle obj1 = new Circle();
            obj1.radius = 10;
            Console.WriteLine("Circle : " + obj1.getArea());
            Console.WriteLine("Type : " + obj1.getType());

            Console.ReadKey();
        }
    }

    abstract class Shape
    {
        public string getType()
        {
            return "Shape";
        }

        public abstract double getArea();
    }

    class Rectangle : Shape
    {
        public int Height;
        public int Base;

        public override double getArea()
        {
            return Height * Base;
        }
    }

    class Circle : Shape
    {
        public double radius;

        public override double getArea()
        {
           return Math.PI * Math.Pow(radius, 2);
        }
    }
}
