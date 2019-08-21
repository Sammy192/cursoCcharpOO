using System;
using System.Collections.Generic;
using System.Text;
using Figura.Entities.Enums;

namespace Figura.Entities {
    abstract class ShapeFigura {
        public Color Color { get; set; }

        public ShapeFigura(Color color) {
            Color = color;
        }

        public abstract double Area();

    }
}
