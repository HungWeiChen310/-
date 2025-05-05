using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH9實作第二題
{
    internal class Box
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Length { get; private set; }

        public Box(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public double Volume() => Width * Height * Length;
        public double Area() =>
            2 * (Width * Height + Width * Length + Height * Length);
    }
}
