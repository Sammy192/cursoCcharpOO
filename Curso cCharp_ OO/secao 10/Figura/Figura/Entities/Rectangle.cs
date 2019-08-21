using System;
using System.Collections.Generic;
using System.Text;
using Figura.Entities.Enums;

namespace Figura.Entities {
    class Rectangle : ShapeFigura {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) :base(color) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}
