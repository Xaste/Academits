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
            const int neededArea = 1;
            const int neededPerimeter = 2;

            Triangle triangle = new Triangle(0, 0, 2, 0, 1, 2);

            Console.WriteLine(triangle.ToString());
            Console.WriteLine();

            Circle circle = new Circle(5);

            Console.WriteLine(circle.ToString());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(5, 10);

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine();

            Square square = new Square(5);

            Console.WriteLine(square.ToString());
            Console.WriteLine();

            IShape[] shapes = new IShape[] { triangle, circle, rectangle, square, new Triangle(3, 5, 7, 2, 1, 7), new Circle(10), new Rectangle(3, 22), new Square(6.3) };

            Array.Sort(shapes, new ShapesAreaComparer());

            IShape areaShapeAnswer = shapes[shapes.Length - neededArea];

            Array.Sort(shapes, new ShapesPerimeterComparer());

            IShape perimeterShapeAnswer = shapes[shapes.Length - neededPerimeter];

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
