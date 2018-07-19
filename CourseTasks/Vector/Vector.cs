using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        //public int VectorSize { get; set; }
        private double[] vectorComponents;

        public Vector(int n)
        {
            this.vectorComponents = new double[n];
        }

        public Vector(Vector vect)
        {
            //this.VectorSize = vect.GetSize();
            this.vectorComponents = new double[vect.GetSize()];

            for (int i = 0; i < vect.GetSize(); i++)
            {
                this.vectorComponents[i] = vect.vectorComponents[i];
            }
        }

        public Vector(double[] array)
        {
            this.vectorComponents = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                this.vectorComponents[i] = array[i];
            }
        }

        public Vector(int n, double[] array)
        {
            //this.VectorSize = n;

            this.vectorComponents = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                if (i < array.Length)
                {
                    this.vectorComponents[i] = array[i];

                }
                else
                {
                    this.vectorComponents[i] = 0;
                }
            }
        }

        public int GetSize()
        {
            return vectorComponents.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.GetSize() - 1; i++)
            {
                sb.Append($"{this.vectorComponents[i]}, ");
            }
            sb.Append($"{this.vectorComponents[this.GetSize() - 1]}");

            return sb.ToString();
        }
    }
}
