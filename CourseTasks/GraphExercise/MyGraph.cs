using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExercise
{
    class MyGraph
    {
        private readonly double[][] graph;

        public int Count { get; private set; }

        public MyGraph(double[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Число столбцов или колонок не может быть 0");
            }

            graph = new double[array.GetLength(0)][];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                graph[i] = new double[array.GetLength(1)];

                for (var j = 0; j < array.GetLength(1); j++)
                {
                    graph[i][j] = array[i, j];
                }
            }

            Count = array.GetLength(0);
        }

        public void GoThroughWide(Action<double> f)
        {
            var visited = new bool[Count];

            var queue = new Queue<int>();

            for (var i = 0; i < visited.Length; i++)
            {
                if (visited[i] != false)
                {
                    continue;
                }

                queue.Enqueue(i);

                while (queue.Count > 0)
                {
                    var row = queue.Dequeue();

                    if (visited[row])
                    {
                        continue;
                    }

                    f(row);

                    visited[row] = true;

                    for (var j = 0; j < graph[row].Length; j++)
                    {
                        if (graph[row][j] > 0)
                        {
                            queue.Enqueue(j);
                        }
                    }
                }
            }
        }

        public void GoThroughDeep(Action<double> f)
        {
            var visited = new bool[Count];

            var stack = new Stack<int>();

            for (var i = 0; i < visited.Length; i++)
            {
                if (visited[i] != false)
                {
                    continue;
                }

                stack.Push(i);

                while (stack.Count > 0)
                {
                    var row = stack.Pop();

                    if (visited[row])
                    {
                        continue;
                    }

                    f(row);

                    visited[row] = true;

                    for (var j = graph[row].Length - 1; j > 0; j--)
                    {
                        if (graph[row][j] > 0)
                        {
                            stack.Push(j);
                        }
                    }
                }
            }
        }
    }
}
