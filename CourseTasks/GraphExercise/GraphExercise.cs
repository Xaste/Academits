using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExercise
{
    class GraphExercise
    {
        static void Main(string[] args)
        {
            var array1 = new double[,]
            {
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 0}, {1, 0, 1, 1, 1, 1, 0, 0, 0, 0}, {0, 1, 0, 0, 0, 0, 1, 0, 0, 0}, {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 1, 0, 0, 0, 0}, {0, 1, 0, 0, 1, 0, 1, 0, 0, 0}, {0, 0, 1, 0, 0, 1, 0, 0, 0, 0},{0,0,0,0,0,0,0,0,1,1},{0,0,0,0,0,0,0,1,0,0}, {0,0,0,0,0,0,0,1,0,0}
            };

            var graph1 = new MyGraph(array1);

            graph1.GoThroughWide((x) => Console.WriteLine(x));

            Console.WriteLine("-----------------------------------------");

            graph1.GoThroughDeep(x => Console.WriteLine(x));

        }
    }
}
