using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClaases
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy the shape");
        }
        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
