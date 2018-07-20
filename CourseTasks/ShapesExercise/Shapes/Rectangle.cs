﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public virtual double GetArea()
        {
            return Height * Width;
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetPerimeter()
        {
            return 2 * Height + 2 * Width;
        }

        public double GetWidth()
        {
            return Width;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Тип фигуры: {GetType()}");
            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Rectangle rectangle = (Rectangle)obj;

            return (Height == rectangle.Height && Width == rectangle.Width) || (Height == rectangle.Width && Width == rectangle.Height);
        }

        public override int GetHashCode()
        {
            int prime = 7;
            int hash = 1;
            hash = prime * hash + Height.GetHashCode();
            hash = prime * hash + Width.GetHashCode();

            return hash;
        }
    }
}
