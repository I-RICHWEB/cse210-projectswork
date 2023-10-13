using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle("Blue", 8, 10));

        shapes.Add(new Square("Green", 10));

        shapes.Add(new Circle("Orange", 7));

        foreach (Shape shape in shapes){
            Console.WriteLine();
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}