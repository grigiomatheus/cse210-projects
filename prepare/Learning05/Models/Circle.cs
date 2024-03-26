﻿namespace Learning05.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea() => _radius * _radius * Math.PI;
    }
}
