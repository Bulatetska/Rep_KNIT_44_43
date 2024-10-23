using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Vector
    {
        private double x;
        private double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.x, -v.y);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.x == v2.x && v1.y == v2.y;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public static Vector operator *(Vector v, double scalar)
        {
            return new Vector(v.x * scalar, v.y * scalar);
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector v)
            {
                return this == v;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (x, y).GetHashCode();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector(1, -2);

            Vector v1Negated = -v1;
            Console.WriteLine($"Negated v1: {v1Negated}");

            Vector vSum = v1 + v2;
            Console.WriteLine($"Sum of v1 and v2: {vSum}");

            Vector v2Scaled = v2 * 2;
            Console.WriteLine($"v2 scaled by 2: {v2Scaled}");

            bool areEqual = v1 == v2;
            Console.WriteLine($"Are v1 and v2 equal? {areEqual}");

            Console.WriteLine($"Length of v1: {v1.Length()}");
        }
    }
}
