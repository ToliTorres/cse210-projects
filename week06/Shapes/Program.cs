using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual objects
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        Console.WriteLine("Single Tests:");
        Console.WriteLine($"Square Color: {square.GetColor()}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        Console.WriteLine("\nList Test:");

        // Build List<Shape>
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate list
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea():F2}");
        }
    }
}
