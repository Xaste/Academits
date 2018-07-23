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

            var vectorResult1 = Vector.SumVectors(vector1, vector2);
            var vectorResult2 = Vector.SumVectors(vector2, vector1);
            var vectorResult3 = Vector.SumVectors(vector1, vector3);

            Console.WriteLine(vectorResult1);
            Console.WriteLine(vectorResult2);
            Console.WriteLine(vectorResult3);

            var vectorResult4 = Vector.SubtractionVectors(vector1, vector2);
            var vectorResult5 = Vector.SubtractionVectors(vector2, vector1);
            var vectorResult6 = Vector.SubtractionVectors(vector1, vector3);
            var vectorResult7 = Vector.SubtractionVectors(vector3, vector1);


            Console.WriteLine(vectorResult4);
            Console.WriteLine(vectorResult5);
            Console.WriteLine(vectorResult6);
            Console.WriteLine(vectorResult7);

            Console.WriteLine();
        }
    }
}
