using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Figure
    {
        protected string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Figure: {name}");
        }

        public abstract double Area();
    }

    class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Area()
        {
            // Використовуємо формулу Герона для обчислення площі
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Sides: {sideA}, {sideB}, {sideC}");
            Console.WriteLine($"Area: {Area()}");
        }
    }

    class TriangleColor : Triangle
    {
        private string color;

        public TriangleColor(string name, double sideA, double sideB, double sideC, string color)
            : base(name, sideA, sideB, sideC)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Area2
        {
            get { return Area(); }
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Color: {color}");
        }

        public new double Area()
        {
            return base.Area(); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleColor triangleColor = new TriangleColor("Colored Triangle", 3, 4, 5, "Red");
            triangleColor.Display();
            Console.WriteLine($"Area using Area2 property: {triangleColor.Area2}");
        }
    }
}
