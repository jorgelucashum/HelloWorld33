using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld33.Entities.Enums;

namespace HelloWorld33.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        Rectangle()
        {
        }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() // É obrigatoria a sobreescrição do método abstrato da clase 'Shape'.
        {
           return  Width * Height;
        }

    }
}
