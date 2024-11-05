using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Figure
    {
        internal string name {  get; set; }

        internal Figure(string name)
        {
            this.name = name;
        }

        internal virtual void Display()
        {
            Console.WriteLine("Figure: " + this.name);
        }
    }

    internal class Rectangle : Figure
    {
        internal int LeftTopX { get; set; }
        internal int LeftTopY { get; set; }

        internal int RightBottomX { get; set; }
        internal int RightBottomY { get; set; }

        internal Rectangle(string name, int leftTopX, int leftTopY, int rightBottomX, int rightBottomY) : base(name) 
        {
            this.LeftTopX = leftTopX;
            this.LeftTopY = leftTopY;
            this.RightBottomX = rightBottomX;
            this.RightBottomY = rightBottomY;
        }

        internal Rectangle() : this("Rectangle", 0, 0, 1, 1) { }

        internal override void Display()
        {
            base.Display();
            Console.WriteLine("Coordinates:\nLeft-Top: (" + this.LeftTopX + ";" + this.LeftTopY + ")\nRight-Bottom: (" + this.RightBottomX + ";" + this.RightBottomY + ")");
        }

        internal virtual int Area()
        {
            int width = Math.Abs(RightBottomX - LeftTopX);
            int height = Math.Abs(RightBottomY - LeftTopY);
            return width * height;
        }
    }

    internal class RectangleColor : Rectangle
    {
        internal string color { get; set; }

        internal RectangleColor(string name, int leftTopX, int leftTopY, int rightBottomX, int rightBottomY, string color) : base(name, leftTopX, leftTopY, rightBottomX, rightBottomY)
        {
            this.color = color;
        }

        internal RectangleColor() : this("Rectangle", 0, 0, 1, 1, "white") { }

        internal override void Display()
        {
            base.Display();
            Console.WriteLine("Figure color: " + this.color);
        }

        internal override int Area()
        {
            return base.Area();
        }
    }
}

