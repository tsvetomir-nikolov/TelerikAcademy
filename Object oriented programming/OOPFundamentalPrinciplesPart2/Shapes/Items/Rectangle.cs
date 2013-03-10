﻿using System;

namespace Shapes.Items
{
    class Rectangle : ShapeBase
    {
        public Rectangle(double width, double height)
            : base(width, height) 
        {
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        } 
    }
}