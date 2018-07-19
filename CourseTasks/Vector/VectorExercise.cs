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
            Vector vect3 = new Vector(array);

            Vector vect4 = new Vector(10, array);

            Console.WriteLine(vect4.ToString());
            Console.WriteLine();
        }
    }
}
