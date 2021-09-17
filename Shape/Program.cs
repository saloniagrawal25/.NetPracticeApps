using System;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;

            Text text2 = (Text)shape;

            Console.WriteLine(text.Width);
        }
    }
}
