﻿using Exercicio.Entities.Enums;

namespace Exercicio.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }


        public abstract double Area();
        

    }
}
