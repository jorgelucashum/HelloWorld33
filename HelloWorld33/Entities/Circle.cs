using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld33.Entities.Enums;

namespace HelloWorld33.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area() // É obrigatoria a sobreescrição do método abstrato da clase 'Shape'.
        {
            return Math.PI * Radius * Radius;
        }
    }
}
