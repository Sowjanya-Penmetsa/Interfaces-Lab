using System;

namespace Interfaces_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius");
            var radius = int.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);
            Console.WriteLine("enter the width and height");

            var width = int.Parse(Console.ReadLine());

            var height = int.Parse(Console.ReadLine());

            IDrawable rect = new Rectangle(width, height);

            circle.Draw();

            rect.Draw();
            Console.ReadLine();
        }
    }
}
