using System;
using System.Reflection.Metadata;

public class Circle : Shape {

    private double _radius;

    public Circle(string color, double radius) : base(color) {
        _radius = radius;
    }

    public override double GetArea()
    {
        double radiusSquare = _radius * _radius;
        return Math.PI * radiusSquare;
    }
}