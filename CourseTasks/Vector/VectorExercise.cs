using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class VectorExercise
    {
        static void Main(string[] args)
        {
            Vector vect1 = new Vector(10);

            Vector vect2 = new Vector(vect1);

            double[] array = new double[] { 17, 22, 33, 14, 5 };
            var array2 = new double[] {1, 2, 3, 4, 5, 22, 22, 22, 22};

            Vector vect3 = new Vector(array);

            var vect5 = new Vector(array2);

            var vectorSum = vect3.SumVector(vect5);
            Console.WriteLine(vect3);
            Console.WriteLine(vect5);
            Console.WriteLine(vectorSum);

            Vector vect4 = new Vector(10, array);

            Console.WriteLine(vect4.ToString());
            Console.WriteLine();
        }
    }
}
