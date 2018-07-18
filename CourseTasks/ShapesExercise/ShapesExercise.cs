using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class ShapesExercise
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(0, 0, 2, 0, 1, 2);

            Console.WriteLine($"Triangele Width = {triangle.GetWidth()};");
            Console.WriteLine($"Triangele Height = {triangle.GetHeight()};");
            Console.WriteLine($"Triangele Area = {triangle.GetArea()};");
            Console.WriteLine($"Triangele Perimeter = {triangle.GetPerimeter()};");
            Console.WriteLine();

            Circle circle = new Circle(5);

            Console.WriteLine($"Circle Width = {circle.GetWidth()};");
            Console.WriteLine($"Circle Height = {circle.GetHeight()};");
            Console.WriteLine($"Circle Area = {circle.GetArea()};");
            Console.WriteLine($"Circle Perimeter = {circle.GetPerimeter()};");
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine($"Rectangle Width = {rectangle.GetWidth()};");
            Console.WriteLine($"Rectangle Height = {rectangle.GetHeight()};");
            Console.WriteLine($"Rectangle Area = {rectangle.GetArea()};");
            Console.WriteLine($"Rectangle Perimeter = {rectangle.GetPerimeter()};");
            Console.WriteLine();

            Square square = new Square(5);
            Console.WriteLine($"Square Width = {square.GetWidth()};");
            Console.WriteLine($"Square Height = {square.GetHeight()};");
            Console.WriteLine($"Square Area = {square.GetArea()};");
            Console.WriteLine($"Square Perimeter = {square.GetPerimeter()};");

            IShape[] shapes = new IShape[] { triangle, circle, rectangle, square, new Triangle(3, 5, 7, 2, 1, 7), new Circle(10), new Rectangle(3, 22), new Square(6.3) };

            Array.Sort(shapes, new ShapesAreaComparer());

            IShape answer = FindMaxAreaShape(shapes);

            

            Console.ReadLine();

        }

        public static IShape FindMaxAreaShape(IShape[] shapes)
        {
            IShape answer = null;
            double maxArea = -1;
            foreach (var item in shapes)
            {
                if (item.GetArea() > maxArea)
                {
                    maxArea = item.GetArea();
                    answer = item;
                }
            }
            return answer;
        }
    }
}
