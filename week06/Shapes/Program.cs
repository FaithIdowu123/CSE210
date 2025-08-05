using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Circle circle = new Circle(14.69);
        circle.SetColor("Red");
        shapes.Add(circle);

        Square square = new Square(6.57);
        square.SetColor("Green");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(20.55, 16.30);
        rectangle.SetColor("Blue");
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}