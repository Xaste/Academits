using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExercise
{
    class VectorExercise
    {
        static void Main(string[] args)
        {
            var array1 = new double[] { 17, 22, 33, 14, 5 };
            var array2 = new double[] { 1, 2, 3, 4, 5, 22, 22, 22, 22 };
            var array3 = new double[] { 1, 2, 3, 4, 5 };

            var vector1 = new Vector(array1);
            var vector2 = new Vector(array2);
            var vector3 = new Vector(array3);
            var vector4 = new Vector(vector1);
            var vector5 = new Vector(3, array1);
            var vector6 = new Vector(10, array1);
            var vector7 = new Vector(5, array1);

            Console.WriteLine(vector1);

            vector1.SetVectorCombonentByIndex(55, 10);
            Console.WriteLine(vector1);

            var component = vector1.GetVectorComponentByIndex(0);
            Console.WriteLine(component);

            vector1.ScalarMultiplication(5);
            Console.WriteLine(vector1);

            vector1.TurnBackVector();
            Console.WriteLine(vector1);

            Console.WriteLine(Vector.ScalarMultiply(vector1, vector3));

            Console.WriteLine(Vector.ScalarMultiply(vector3, vector1));

            Console.WriteLine(Vector.ScalarMultiply(vector2, vector3));

            Console.WriteLine(Vector.ScalarMultiply(vector3, vector2));

            Console.WriteLine();
        }
    }
}
