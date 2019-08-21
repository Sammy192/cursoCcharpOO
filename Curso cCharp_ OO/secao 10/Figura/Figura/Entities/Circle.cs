using System;
using System.Collections.Generic;
using System.Text;
using Figura.Entities.Enums;

namespace Figura.Entities {
    class Circle : ShapeFigura {

        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }


    }
}
