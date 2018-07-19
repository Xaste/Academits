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

            Console.WriteLine(triangle.ToString());
            Console.WriteLine();

            Circle circle = new Circle(5);
            Console.WriteLine(circle.GetHashCode());

            Console.WriteLine(circle.ToString());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(5, 10);

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine();

            Square square = new Square(5);

            Console.WriteLine(square.ToString());
            Console.WriteLine();

            IShape[] shapes = new IShape[] { triangle, circle, rectangle, square, new Triangle(3, 5, 7, 2, 1, 7), new Circle(10), new Rectangle(3, 22), new Square(6.3) };

            IShape maxAreaShape = FindNeededAreaShape(shapes, 1);

            IShape SecondPerimeterShape = FindNeededPerimeterShape(shapes, 2);

            Console.ReadLine();

        }

        public static IShape FindNeededAreaShape(IShape[] shapes, int neededArea)
        {
            if (neededArea > shapes.Length)
            {
                return null;
            }

            IShape[] tempArray = shapes;
            Array.Sort(tempArray, new ShapesAreaComparer());
            return tempArray[shapes.Length - neededArea];
        }

        public static IShape FindNeededPerimeterShape(IShape[] shapes, int neededPerimeter)
        {
            if (neededPerimeter > shapes.Length)
            {
                return null;
            }

            IShape[] tempArray = shapes;
            Array.Sort(tempArray, new ShapesPerimeterComparer());
            return tempArray[shapes.Length - neededPerimeter];
        }
    }
}
